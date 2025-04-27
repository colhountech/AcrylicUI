# AcrylicToolStrip

`AcrylicToolStrip` provides a toolbar control with AcrylicUI styling, designed to host `ToolStripButton`, `ToolStripSeparator`, `ToolStripComboBox`, and other `ToolStripItem` objects. It replaces the standard `System.Windows.Forms.ToolStrip` and uses a custom renderer for appearance.

## Basic Usage

Add `AcrylicToolStrip` to your form (often docked to the top or sides). Add items like `ToolStripButton` and `ToolStripSeparator` to its `Items` collection, typically using the WinForms designer. Assign icons and event handlers to the items.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources; // For Icons
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    private AcrylicToolStrip toolStrip;
    private ToolStripButton tsbNew;
    private ToolStripButton tsbSave;
    private ToolStripSeparator tssSeparator1;
    private ToolStripButton tsbCut;
    private ToolStripButton tsbCopy;
    private ToolStripButton tsbPaste;

    public MyForm()
    {
        InitializeComponent(); // Assumes ToolStrip and items are added in designer
        SetupToolStripEventHandlers();
    }

    private void SetupToolStripEventHandlers()
    {   
        // Example: Access items by name if added in designer
        // tsbNew = (ToolStripButton)toolStrip.Items["tsbNew"]; 
        // ... etc ...
        
        // Attach event handlers
        if (tsbNew != null) tsbNew.Click += (s, e) => { /* New action */ };
        if (tsbSave != null) tsbSave.Click += (s, e) => { /* Save action */ };
        if (tsbCut != null) tsbCut.Click += (s, e) => { /* Cut action */ };
        if (tsbCopy != null) tsbCopy.Click += (s, e) => { /* Copy action */ };
        if (tsbPaste != null) tsbPaste.Click += (s, e) => { /* Paste action */ };
    }

    // Example adding programmatically
    private void CreateToolStrip()
    {
        toolStrip = new AcrylicToolStrip { Dock = DockStyle.Top };
        
        tsbNew = new ToolStripButton("New", Icons.NewFile_16x, (s,e) => {/*...*/}) { DisplayStyle = ToolStripItemDisplayStyle.ImageAndText };
        tsbSave = new ToolStripButton("Save", Icons.Save_16x, (s,e) => {/*...*/}) { DisplayStyle = ToolStripItemDisplayStyle.Image }; // Icon only
        tssSeparator1 = new ToolStripSeparator();
        tsbCopy = new ToolStripButton("Copy", Icons.Copy_16x, (s,e) => {/*...*/}) { DisplayStyle = ToolStripItemDisplayStyle.Image };
        tsbPaste = new ToolStripButton("Paste", Icons.Paste_16x, (s,e) => {/*...*/}) { DisplayStyle = ToolStripItemDisplayStyle.Image };

        toolStrip.Items.AddRange(new ToolStripItem[] {
            tsbNew, tsbSave, tssSeparator1, tsbCopy, tsbPaste
        });
        
        Controls.Add(toolStrip);
    }
}
```

## Key Properties

*   `Items`: Gets the collection of `ToolStripItem` objects hosted by the tool strip.
*   `Renderer`: Controls how the tool strip is painted (set to `AcrylicToolStripRenderer` by default).
*   `GripStyle`: Controls visibility of the move handle (`Hidden` or `Visible`).
*   `Stretch`: Gets or sets whether the `ToolStrip` stretches from end to end in its container (relevant when docked).
*   Standard layout properties (`Dock`, `Location`, `Size`, etc.).

## Adding Items

Common items to add to the `Items` collection include:
*   `ToolStripButton`: Standard clickable button.
*   `ToolStripSeparator`: Divides groups of items.
*   `ToolStripLabel`: Displays text.
*   `ToolStripComboBox`: Embeds a combo box.
*   `ToolStripTextBox`: Embeds a text box.
*   `ToolStripDropDownButton`, `ToolStripSplitButton`: Buttons with dropdowns.

Items are most easily configured using the WinForms designer, setting properties like `Text`, `Image`, `DisplayStyle`, `ToolTipText`, and assigning `Click` event handlers. 