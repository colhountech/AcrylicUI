# AcrylicMenuStrip

`AcrylicMenuStrip` provides the main menu bar for a form, styled according to the AcrylicUI theme. It replaces the standard `System.Windows.Forms.MenuStrip`.

## Basic Usage

Add `AcrylicMenuStrip` to your `AcrylicForm` (usually placed at the top). Add top-level menu items (`ToolStripMenuItem`) and nested sub-items to its `Items` collection, typically using the WinForms designer. Assign event handlers to the `Click` event of the menu items that should perform actions.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    private AcrylicMenuStrip mainMenuStrip;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem fileOpenToolStripMenuItem;
    private ToolStripMenuItem fileSaveToolStripMenuItem;
    private ToolStripSeparator fileSeparator1;
    private ToolStripMenuItem fileExitToolStripMenuItem;
    private ToolStripMenuItem helpAboutToolStripMenuItem;
    
    // ... other controls ...

    public MyForm()
    {
        InitializeComponent(); // Assumes MenuStrip and items are created in designer
        SetupMenuEventHandlers();
    }

    // It's common practice to set up event handlers separately 
    // if not done directly in the designer.
    private void SetupMenuEventHandlers()
    {
        // Example: Find items by name if added in designer
        // fileOpenToolStripMenuItem = (ToolStripMenuItem)mainMenuStrip.Items.Find("fileOpenToolStripMenuItem", true).FirstOrDefault();
        // fileSaveToolStripMenuItem = (ToolStripMenuItem)mainMenuStrip.Items.Find("fileSaveToolStripMenuItem", true).FirstOrDefault();
        // fileExitToolStripMenuItem = (ToolStripMenuItem)mainMenuStrip.Items.Find("fileExitToolStripMenuItem", true).FirstOrDefault();
        // helpAboutToolStripMenuItem = (ToolStripMenuItem)mainMenuStrip.Items.Find("helpAboutToolStripMenuItem", true).FirstOrDefault();
        
        // Or access directly if you have field references (like from designer.cs)
        if (fileOpenToolStripMenuItem != null) 
            fileOpenToolStripMenuItem.Click += FileOpen_Click;
        if (fileSaveToolStripMenuItem != null) 
            fileSaveToolStripMenuItem.Click += FileSave_Click;
        if (fileExitToolStripMenuItem != null) 
            fileExitToolStripMenuItem.Click += FileExit_Click;
        if (helpAboutToolStripMenuItem != null) 
            helpAboutToolStripMenuItem.Click += HelpAbout_Click;
    }

    private void FileOpen_Click(object sender, System.EventArgs e)
    {
        AcrylicMessageBox.ShowInformation(this, "File -> Open Clicked!", "Menu Action");
        // Add Open File logic here
    }

    private void FileSave_Click(object sender, System.EventArgs e)
    {
        AcrylicMessageBox.ShowInformation(this, "File -> Save Clicked!", "Menu Action");
        // Add Save File logic here
    }

    private void FileExit_Click(object sender, System.EventArgs e)
    {
        this.Close();
    }

    private void HelpAbout_Click(object sender, System.EventArgs e)
    {
        AcrylicMessageBox.ShowInformation(this, "Help -> About Clicked!", "Menu Action");
        // Show About dialog
    }
}
```

*Note: The above example assumes menu items (`fileToolStripMenuItem`, `fileOpenToolStripMenuItem`, etc.) are declared as fields, which typically happens automatically when using the WinForms designer.* 

## Key Properties

*   `Items`: Gets the collection of `ToolStripItem` objects (usually `ToolStripMenuItem` for top-level menus) displayed in the menu strip.
*   `Renderer`: Controls how the menu strip is painted (automatically set by AcrylicUI).
*   `GripStyle`: Controls visibility of the move handle (usually `Hidden`).
*   Standard layout properties (`Dock`, `Location`, etc.). `Dock` is typically set to `Top` or `None`.

## Adding Items

While possible programmatically, menu structures are most easily built using the WinForms designer. Add `ToolStripMenuItem` for clickable menu entries and `ToolStripSeparator` for dividing lines. Configure text, shortcuts, icons, and `Click` event handlers in the designer's properties window.

---

**See also:** Example Form [`Form6_DockPanel.cs`](../../Examples/Form6_DockPanel.cs) 