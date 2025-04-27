# ToolWindow

`ToolWindow` is a base class, derived from `DockContent`, used for creating standard dockable tool windows within the AcrylicUI framework. These are typically used for auxiliary panels like property grids, explorers, output windows, etc., that dock to the sides or bottom of the main `DockPanel`.

It provides a themed title bar with text, an optional icon, and a close button.

## Basic Usage

Create a new class that inherits from `AcrylicUI.Docking.ToolWindow`. Add controls to it using the designer or code. Set properties like `DockText`, `Icon`, `DefaultDockArea`, and `SerializationKey` in the constructor. Finally, add an instance of your class to the `DockPanel`.

```csharp
using AcrylicUI.Docking;
using AcrylicUI.Controls;
using AcrylicUI.Resources; // For Icons
using System.Windows.Forms;
using System.Drawing;

// 1. Define your custom ToolWindow
public class PropertiesToolWindow : ToolWindow
{
    private AcrylicTreeView propertyGrid;

    public PropertiesToolWindow()
    {
        // Configure ToolWindow properties (inherited from DockContent)
        DockText = "Properties";
        Icon = Icons.properties_16x; // Example icon
        DefaultDockArea = DockArea.Right; // Common area for properties
        SerializationKey = "PropertiesWindow";

        // Add controls 
        propertyGrid = new AcrylicTreeView
        {
            Dock = DockStyle.Fill
        };
        Controls.Add(propertyGrid);

        // Populate propertyGrid based on application state...
        LoadProperties(null); 
    }

    public void LoadProperties(object selectedObject)
    {
        propertyGrid.Nodes.Clear();
        if (selectedObject != null)
        {
            propertyGrid.Nodes.Add(new AcrylicTreeNode($"Object Type: {selectedObject.GetType().Name}"));
            // Add actual properties...
        }
        else
        {
            propertyGrid.Nodes.Add(new AcrylicTreeNode("(No object selected)"));
        }
    }
}

// 2. Use your custom ToolWindow in your main form
public partial class MyMainForm : AcrylicUI.Forms.AcrylicForm
{
    private AcrylicUI.Docking.DockPanel dockPanel;
    private PropertiesToolWindow propertiesWindow;

    public MyMainForm()
    {
        InitializeComponent(); // Assume dockPanel exists
        
        // Create and add the tool window
        propertiesWindow = new PropertiesToolWindow();
        dockPanel.AddContent(propertiesWindow);

        // You might update the properties window later
        // propertiesWindow.LoadProperties(someSelectedObject);
    }
}
```

## Key Properties

*   Inherits all key properties from `DockContent`:
    *   `DockText`: Text for the title bar/tab.
    *   `Icon`: Icon for the title bar/tab.
    *   `DefaultDockArea`: Preferred initial docking location (`Left`, `Right`, `Bottom`).
    *   `SerializationKey`: Key for layout persistence.
*   `IsAcrylic`: Gets or sets whether the tool window background uses the acrylic effect.
*   Standard `UserControl` properties (`Controls`, `Padding`, etc.). Note that padding is automatically added for the header.

## Events

*   Inherits events from `DockContent` (`DockTextChanged`, etc.).
*   Standard `UserControl` events.

---

**See also:** [`DockContent`](DockContent.md), [`DockPanel`](DockPanel.md), [`Document`](Document.md), Example Form [`Form6_DockPanel.cs`](../../Examples/Form6_DockPanel.cs) 