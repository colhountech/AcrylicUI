# DockContent

`DockContent` is the **abstract base class** for all content that can be docked within an `AcrylicUI.Docking.DockPanel`. You do not typically use this class directly.

## Usage

To create dockable content, inherit from one of its derived classes:

*   [`Document`](Document.md): Use for primary content windows that typically reside in the central document area (tabbed interface).
*   [`ToolWindow`](ToolWindow.md): Use for secondary tool palettes or informational windows that usually dock to the sides (Left, Right, Bottom) or float.
*   [`BoxControl`](../controls/BoxControl.md): A simpler tool window without a close button by default.

Your custom class inheriting from `Document`, `ToolWindow`, or `BoxControl` will automatically inherit the necessary `DockContent` functionality.

```csharp
using AcrylicUI.Docking;
using AcrylicUI.Controls;
using System.Windows.Forms;

// Example Tool Window inheriting from ToolWindow (which inherits from DockContent)
public class MyProjectExplorer : ToolWindow
{
    public MyProjectExplorer()
    {
        // Set properties inherited from DockContent
        DockText = "Project Explorer"; // Text for tab/header
        DefaultDockArea = DockArea.Left; // Preferred initial location
        // Icon = ...; // Optional icon
        SerializationKey = "ProjectExplorer"; // For saving/loading layout

        // Add controls to this ToolWindow
        var treeView = new AcrylicTreeView { Dock = DockStyle.Fill };
        Controls.Add(treeView);
        // ... populate treeView ...
    }
}

// Example Document inheriting from Document (which inherits from DockContent)
public class MyEditor : Document
{
    public MyEditor(string documentName)
    {
        DockText = documentName; // Tab text (often filename)
        // Documents typically default to DockArea.Document
        SerializationKey = $"Editor_{documentName}"; 

        var textBox = new AcrylicTextBox 
        { 
            Dock = DockStyle.Fill, 
            Multiline = true 
        };
        Controls.Add(textBox);
        // ... load document into textBox ... 
    }
}
```

## Key Properties (Inherited by derived classes)

*   `DockText`: Gets or sets the text displayed in the tab header or tool window title bar.
*   `Icon`: Gets or sets the icon displayed next to the `DockText`.
*   `DefaultDockArea`: Gets or sets the preferred `DockArea` (`Document`, `Left`, `Right`, `Bottom`) where the content should initially appear when added to a `DockPanel`.
*   `SerializationKey`: A unique string key used by the `DockPanel`'s `SaveDockState` and `LoadDockState` methods to identify this content when saving/restoring layouts.
*   `DockGroup`: Gets the `DockGroup` this content currently belongs to.
*   `DockArea`: Gets the `DockArea` where this content is currently docked.
*   `DockPanel`: Gets the parent `DockPanel` hosting this content.

## Key Events (Inherited by derived classes)

*   `DockTextChanged`: Occurs when the `DockText` property value changes.
*   Standard `UserControl` events (`Load`, `Paint`, `Resize`, etc.).

---

**See also:** [`DockPanel`](DockPanel.md), [`Document`](Document.md), [`ToolWindow`](ToolWindow.md) 