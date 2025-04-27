# AcrylicTreeView

`AcrylicTreeView` provides a tree view control with AcrylicUI styling, displaying a hierarchical collection of `AcrylicTreeNode` objects. It features custom drawing for nodes, expand/collapse icons, indentation lines, and themed scrollbars.

## Basic Usage

Add `AcrylicTreeView` to your form. Create `AcrylicTreeNode` objects, set their `Text` and optionally `Icon`/`SvgIcon`, add child nodes to the parent's `Nodes` collection, and finally add the root nodes to the `AcrylicTreeView`'s `Nodes` collection.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources; // For Icons
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    private AcrylicTreeView treeView;

    public MyForm()
    {
        InitializeComponent();

        treeView = new AcrylicTreeView
        {
            Location = new Point(20, 50),
            Size = new Size(300, 400),
            Dock = DockStyle.Left, // Example docking
            ShowIcons = true,     // Enable icons
            Indent = 19,          // Indentation space per level
            ItemHeight = 20       // Height of each node item
        };
        Controls.Add(treeView);

        BuildTreeNodes();

        // Handle events
        treeView.SelectedNodesChanged += TreeView_SelectedNodesChanged;
        treeView.NodeExpanded += (s, e) => { /* Optional: Handle node expand */ };
        treeView.NodeCollapsed += (s, e) => { /* Optional: Handle node collapse */ };
    }

    private void BuildTreeNodes()
    {
        // Root Node 1
        var root1 = new AcrylicTreeNode("Documents")
        {
            Icon = Icons.folder_16x, // Standard icon
            ExpandedIcon = Icons.folder_Open_16x // Icon when expanded
        };
        treeView.Nodes.Add(root1);

        // Child nodes for Root 1
        root1.Nodes.Add(new AcrylicTreeNode("Report.docx") { Icon = Icons.document_16x });
        root1.Nodes.Add(new AcrylicTreeNode("Budget.xlsx") { Icon = Icons.document_16x });
        
        var subFolder = new AcrylicTreeNode("Archive") { Icon = Icons.folder_16x, ExpandedIcon = Icons.folder_Open_16x };
        root1.Nodes.Add(subFolder);
        subFolder.Nodes.Add(new AcrylicTreeNode("OldReport.docx") { Icon = Icons.document_16x });

        // Root Node 2
        var root2 = new AcrylicTreeNode("Pictures")
        {
             Icon = Icons.folder_16x, 
             ExpandedIcon = Icons.folder_Open_16x 
        };
        treeView.Nodes.Add(root2);
        root2.Nodes.Add(new AcrylicTreeNode("Vacation.jpg") { Icon = Icons.document_16x }); // Use generic doc icon if no specific pic icon

        // Expand a node initially (optional)
        root1.Expand();
    }

    private void TreeView_SelectedNodesChanged(object sender, System.EventArgs e)
    {
        if (treeView.SelectedNodes.Count > 0)
        {
            AcrylicTreeNode selectedNode = treeView.SelectedNodes[0];
            AcrylicMessageBox.ShowInformation(this, $"Selected: {selectedNode.Text}", "Node Selected");
            // Access node data via selectedNode.Tag if needed
        }
    }
}
```

## Layout Considerations

**Preventing Overlap with Parent Header:**

When placing an `AcrylicTreeView` inside a container control (like a `ToolWindow` or `UserControl`) that has its own header or title bar, setting the `AcrylicTreeView`'s `Dock` property to `DockStyle.Fill` might cause the TreeView to overlap the parent's header area.

To prevent this, ensure the *parent container control* has standard WinForms AutoScale properties set, typically in its constructor or `InitializeComponent` method:

```csharp
// In the constructor or InitializeComponent of the PARENT control (e.g., MyToolWindow.cs)
this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F); 
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
```

This helps the parent control respect its own non-client areas (like the header) when its client area is being filled by the docked `AcrylicTreeView`.

## Key Properties

*   `Nodes`: Gets the collection of root `AcrylicTreeNode` objects.
*   `SelectedNodes`: Gets a list of the currently selected `AcrylicTreeNode` objects.
*   `MultiSelect`: Gets or sets a value indicating whether multiple nodes can be selected.
*   `ShowIcons`: Gets or sets a value indicating whether icons assigned to nodes should be displayed.
*   `Indent`: Gets or sets the indentation width (in pixels) for each level of the tree.
*   `ItemHeight`: Gets or sets the height (in pixels) of each node item.
*   `MaxDragChange`: (Related to internal drag-drop handling, check source/examples for usage).

## AcrylicTreeNode Properties

*   `Text`: The text displayed for the node.
*   `Icon`: The `Image` displayed when the node is collapsed.
*   `ExpandedIcon`: The `Image` displayed when the node is expanded (if different from `Icon`).
*   `SvgIcon`/`SvgExpandedIcon`: Alternative way to set icons using SVG strings (requires appropriate resource handling).
*   `Nodes`: The collection of child `AcrylicTreeNode` objects.
*   `ParentNode`: Gets the parent node.
*   `IsExpanded`: Gets or sets whether the node is currently expanded.
*   `Tag`: Stores custom data associated with the node.

## Events

*   `SelectedNodesChanged`: Occurs when the selection changes.
*   `NodeExpanded`, `NodeCollapsed`: Occur when a node is expanded or collapsed.
*   `ItemClicked`, `ItemDoubleClicked`: Occur when a node area is clicked or double-clicked.

---

**See also:** [`AcrylicTreeNode`](AcrylicTreeNode.md) (Consider creating this page), Example Form [`Form13_TreeView.cs`](../../Examples/Form13_TreeView.cs) 