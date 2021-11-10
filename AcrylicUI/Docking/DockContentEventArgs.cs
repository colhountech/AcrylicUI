using System;

namespace AcrylicUI.Docking
{
    public class DockContentEventArgs : EventArgs
    {
        public DockContent Content { get; private set; }

        public DockContentEventArgs(DockContent content)
        {
            Content = content;
        }
    }
}
