# AcrylicContextMenu

`AcrylicContextMenu` provides a context menu strip with AcrylicUI styling. It inherits from the standard `System.Windows.Forms.ContextMenuStrip` and uses custom renderers to match the application's theme.

## Basic Usage

Create an instance of `AcrylicContextMenu`, add `ToolStripMenuItem` objects to its `Items` collection, and assign it to the `ContextMenuStrip` property of the control that should display it (e.g., a Panel, TextBox, or the Form itself).

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    private AcrylicContextMenu contextMenuForPanel;
    private Panel rightClickPanel;

    public MyForm()
    {
        InitializeComponent();

        // Create a panel to attach the context menu to
        rightClickPanel = new Panel 
        { 
            Location = new Point(20, 50), 
            Size = new Size(200, 100), 
            BackColor = Color.FromArgb(60, 63, 65) // Example background 
        };
        Controls.Add(rightClickPanel);

        // Create the Context Menu
        contextMenuForPanel = new AcrylicContextMenu();

        // Create Menu Items
        var itemCopy = new ToolStripMenuItem("Copy");
        var itemPaste = new ToolStripMenuItem("Paste");
        var itemDelete = new ToolStripMenuItem("Delete");
        var separator = new ToolStripSeparator();
        var itemProperties = new ToolStripMenuItem("Properties...");

        // Add items to the context menu
        contextMenuForPanel.Items.AddRange(new ToolStripItem[] {
            itemCopy,
            itemPaste,
            separator, // Separator item
            itemDelete,
            itemProperties
        });

        // Assign event handlers for menu item clicks
        itemCopy.Click += (s, e) => { AcrylicMessageBox.ShowInformation(this, "Copy clicked!", "Context Menu"); };
        itemPaste.Click += (s, e) => { AcrylicMessageBox.ShowInformation(this, "Paste clicked!", "Context Menu"); };
        itemDelete.Click += (s, e) => { AcrylicMessageBox.ShowInformation(this, "Delete clicked!", "Context Menu"); };
        itemProperties.Click += (s, e) => { AcrylicMessageBox.ShowInformation(this, "Properties clicked!", "Context Menu"); };
        
        // Assign the context menu to the panel
        rightClickPanel.ContextMenuStrip = contextMenuForPanel;
    }
}
```

## Key Properties

*   `Items`: Gets the collection of `ToolStripItem` objects (like `ToolStripMenuItem`, `ToolStripSeparator`) displayed in the menu.
*   `Renderer`: Controls how the menu is painted (automatically set by AcrylicUI).
*   `ShowImageMargin`, `ShowCheckMargin`: Standard `ContextMenuStrip` properties to control visual layout.

## Adding Items

Use the `Items.Add()` or `Items.AddRange()` methods to add `ToolStripMenuItem` or `ToolStripSeparator` instances. Attach event handlers to the `Click` event of each `ToolStripMenuItem` to perform actions. 