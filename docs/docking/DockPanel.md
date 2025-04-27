# DockPanel

`DockPanel` is the central control of the AcrylicUI docking framework. It manages the layout of dockable content (documents and tool windows) within regions (Document, Left, Right, Bottom) and handles splitting and rearranging.

## Basic Usage

Typically, you add a single `DockPanel` to your main form, usually docked to fill a container like `WindowPanel`. You then create instances of `DockContent` (or derived classes like `Document` or `ToolWindow`) and add them to the `DockPanel` using the `AddContent` method.

**Important:** You must add the `DockPanel.DockResizeFilter` to your application's message filters for docking resize operations (like dragging splitters) to work correctly.

```csharp
using AcrylicUI.Docking;
using AcrylicUI.Forms;
using AcrylicUI.Controls; // For WindowPanel if used
using System.Windows.Forms;

public partial class MyMainForm : AcrylicForm
{
    private WindowPanel mainContainerPanel; // Optional container
    private AcrylicUI.Docking.DockPanel dockPanel;

    // Example content windows
    private MyToolWindow toolWindow1;
    private MyDocument document1;
    private MyDocument document2;

    public MyMainForm()
    {
        InitializeComponent();

        // Add the required message filter ONCE in application startup
        // (e.g., in Program.cs before Application.Run)
        // Application.AddMessageFilter(AcrylicUI.Docking.DockPanel.DockResizeFilter);
        // Alternatively, if added here, ensure it's only added once.
        if (!Application.MessageLoop)
           Application.AddMessageFilter(AcrylicUI.Docking.DockPanel.DockResizeFilter);

        // Setup DockPanel (often done in designer)
        dockPanel = new AcrylicUI.Docking.DockPanel
        {
            Dock = DockStyle.Fill, 
            BackColor = AcrylicUI.Resources.Colors.GreyBackground // Or other theme color
        };
        
        // Add to form or a container panel
        // Assuming mainContainerPanel fills the form below Menu/ToolStrips
        if (mainContainerPanel != null)
             mainContainerPanel.Controls.Add(dockPanel); 
        else 
             Controls.Add(dockPanel);
        
        // Create and add content
        toolWindow1 = new MyToolWindow { DefaultDockArea = DockArea.Left }; // Specify default area
        document1 = new MyDocument { DockText = "Document A" }; // Documents default to Document area
        document2 = new MyDocument { DockText = "Document B" };

        dockPanel.AddContent(toolWindow1); // Add tool window
        dockPanel.AddContent(document1); // Add document
        dockPanel.AddContent(document2); // Add another document
        
        // DockPanel handles layout automatically
    }
}

// Example Content Classes (must inherit from DockContent)
public class MyToolWindow : ToolWindow 
{ 
    public MyToolWindow() { /* Add controls here */ } 
}
public class MyDocument : Document 
{ 
    public MyDocument() { /* Add controls here */ } 
}
```

## Key Methods

*   `AddContent(DockContent content)`: Adds a dockable window (ToolWindow or Document) to the panel, placing it in its `DefaultDockArea` or the Document area if unspecified.
*   `RemoveContent(DockContent content)`: Removes a previously added content window.
*   `GetDocuments()`: Returns a list of all `DockContent` items currently in the Document area.
*   `LoadDockState(Stream stream)`, `SaveDockState(Stream stream)`: Methods for serializing and deserializing the layout of docked windows.

## Key Properties

*   `ActiveContent`: Gets or sets the currently focused `DockContent`.
*   `ActiveDocument`: Gets the currently focused `DockContent` within the Document area.
*   `BackColor`: Sets the background color for the panel's empty areas and splitters.

## Key Events

*   `ActiveContentChanged`: Occurs when the focused content changes.
*   `ContentAdded`, `ContentRemoved`: Occur when content is added to or removed from the panel.

---

**See also:** [`DockContent`](DockContent.md), [`Document`](Document.md), [`ToolWindow`](ToolWindow.md), Example Form [`Form6_DockPanel.cs`](../../Examples/Form6_DockPanel.cs) 