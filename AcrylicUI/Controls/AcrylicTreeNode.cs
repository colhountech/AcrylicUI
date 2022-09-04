using AcrylicUI.Collections;
using Svg;
using System;
using System.Drawing;
using System.IO;

namespace AcrylicUI.Controls
{
    public class AcrylicTreeNode
    {
        #region Event Region

        public event EventHandler<ObservableListModified<AcrylicTreeNode>> ItemsAdded;
        public event EventHandler<ObservableListModified<AcrylicTreeNode>> ItemsRemoved;

        public event EventHandler TextChanged;
        public event EventHandler NodeExpanded;
        public event EventHandler NodeCollapsed;

        #endregion

        #region Field Region

        private string _text;
        private bool _isRoot;
        private int _iconSize = 16;

        private AcrylicTreeView _parentTree;
        private AcrylicTreeNode _parentNode;

        private ObservableList<AcrylicTreeNode> _nodes;

        private bool _expanded;

        #endregion

        #region Property Region

        public string Text
        {
            get { return _text; }
            set
            {
                if (_text == value)
                    return;

                _text = value;

                OnTextChanged();
            }
        }

        public Rectangle ExpandArea { get; set; }

        public Rectangle IconArea { get; set; }

        public Rectangle TextArea { get; set; }

        public Rectangle FullArea { get; set; }

        public bool ExpandAreaHot { get; set; }

        #endregion Property Region


        #region Icon

        private byte[] _svgIcon;

        public byte[] SvgIcon
        {
            set
            {
                _svgIcon = value;
                RescaleImage();
            }
        }

        private void RescaleImage()
        {
            if (_svgIcon is not null)
            {
                using (var stream = new MemoryStream(_svgIcon))
                {
                    var svgDoc = SvgDocument.Open<SvgDocument>(stream, null);
                    Icon = svgDoc.Draw(Scale(_iconSize), Scale(_iconSize));
                }
            }
        }

        private Image _icon;
        /// <summary>
        /// Set the svgIcon before getting the Icon.
        /// call the UpdateScale(dpiScale) before gettingIcon
        /// 
        /// </summary>
        /// 
        public Image Icon
        {
            get
            {
                if (_icon is not null)
                {
                    return _icon;
                }

                return null;
            }
            set
            {
                _icon = value;
            }

        }
        #endregion


        #region ExpandedIcon

        private byte[] _svgExpandedIcon;

        public byte[] SvgExpandedIcon
        {
            set
            {
                _svgExpandedIcon = value;
            }
        }

        /// <summary>
        /// Set the SvgExpandedIcon before getting the ExpandedIcon
        /// call the UpdateScale(dpiScale) before getting the ExpandedIcon
        /// 
        /// </summary>
        public Bitmap ExpandedIcon
        {
            get
            {
                if (_svgExpandedIcon is null) return null;
                using (var stream = new MemoryStream(_svgExpandedIcon))
                {
                    var svgDoc = SvgDocument.Open<SvgDocument>(stream, null);
                    return svgDoc.Draw(Scale(_iconSize), Scale(_iconSize));
                }
            }
        }

        #endregion

        public bool Expanded
        {
            get { return _expanded; }
            set
            {
                if (_expanded == value)
                    return;

                if (value == true && Nodes.Count == 0)
                    return;

                _expanded = value;

                if (_expanded)
                {
                    if (NodeExpanded != null)
                        NodeExpanded(this, null);
                }
                else
                {
                    if (NodeCollapsed != null)
                        NodeCollapsed(this, null);
                }
            }
        }

        public ObservableList<AcrylicTreeNode> Nodes
        {
            get { return _nodes; }
            set
            {
                if (_nodes != null)
                {
                    _nodes.ItemsAdded -= Nodes_ItemsAdded;
                    _nodes.ItemsRemoved -= Nodes_ItemsRemoved;
                }

                _nodes = value;

                _nodes.ItemsAdded += Nodes_ItemsAdded;
                _nodes.ItemsRemoved += Nodes_ItemsRemoved;
            }
        }

        public bool IsRoot
        {
            get { return _isRoot; }
            set { _isRoot = value; }
        }

        public AcrylicTreeView ParentTree
        {
            get { return _parentTree; }
            set
            {
                if (_parentTree == value)
                    return;

                _parentTree = value;

                foreach (var node in Nodes)
                    node.ParentTree = _parentTree;
            }
        }

        public AcrylicTreeNode ParentNode
        {
            get { return _parentNode; }
            set { _parentNode = value; }
        }

        public bool Odd { get; set; }

        public object NodeType { get; set; }

        public object Tag { get; set; }

        public string FullPath
        {
            get
            {
                var parent = ParentNode;
                var path = Text;

                while (parent != null)
                {
                    path = string.Format("{0}{1}{2}", parent.Text, "\\", path);
                    parent = parent.ParentNode;
                }

                return path;
            }
        }

        public AcrylicTreeNode PrevVisibleNode { get; set; }

        public AcrylicTreeNode NextVisibleNode { get; set; }

        public int VisibleIndex { get; set; }

        public bool IsNodeAncestor(AcrylicTreeNode node)
        {
            var parent = ParentNode;
            while (parent != null)
            {
                if (parent == node)
                    return true;

                parent = parent.ParentNode;
            }

            return false;
        }

        #region Constructor Region

        public AcrylicTreeNode()
        {
            Nodes = new ObservableList<AcrylicTreeNode>();
        }

        public AcrylicTreeNode(string text)
            : this()
        {
            Text = text;
        }

        #endregion

        #region Method Region

        public void Remove()
        {
            if (ParentNode != null)
                ParentNode.Nodes.Remove(this);
            else
                ParentTree.Nodes.Remove(this);
        }

        public void EnsureVisible()
        {
            var parent = ParentNode;

            while (parent != null)
            {
                parent.Expanded = true;
                parent = parent.ParentNode;
            }
        }

        #endregion

        #region Event Handler Region

        private void OnTextChanged()
        {
            if (ParentTree != null && ParentTree.TreeViewNodeSorter != null)
            {
                if (ParentNode != null)
                    ParentNode.Nodes.Sort(ParentTree.TreeViewNodeSorter);
                else
                    ParentTree.Nodes.Sort(ParentTree.TreeViewNodeSorter);
            }

            if (TextChanged != null)
                TextChanged(this, null);
        }

        private void Nodes_ItemsAdded(object sender, ObservableListModified<AcrylicTreeNode> e)
        {
            foreach (var node in e.Items)
            {
                node.ParentNode = this;
                node.ParentTree = ParentTree;
            }

            if (ParentTree != null && ParentTree.TreeViewNodeSorter != null)
                Nodes.Sort(ParentTree.TreeViewNodeSorter);

            if (ItemsAdded != null)
                ItemsAdded(this, e);
        }

        private void Nodes_ItemsRemoved(object sender, ObservableListModified<AcrylicTreeNode> e)
        {
            if (Nodes.Count == 0)
                Expanded = false;

            if (ItemsRemoved != null)
                ItemsRemoved(this, e);
        }

        #endregion

        #region Dpi Scale

        private const float DEFAULT_DPI = 96f;
        private float _dpiScale = 1;


        // call at init too
        internal void UpdateScale(float newDpiScale)
        {

            if (newDpiScale != _dpiScale)
            {
                _dpiScale = newDpiScale;

                // TODO
                // update Icons
            }
        }

        internal int Scale(int pixel)
        {
            return (int)(pixel * _dpiScale);
        }
        #endregion

    }
}
