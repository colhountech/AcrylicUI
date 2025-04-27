# DockArea Enum

`AcrylicUI.Docking.DockArea` is an enumeration used to define the different regions within a `DockPanel` where content can be docked.

## Enum Values

*   **`None`**: Represents an unknown or invalid area. Content is typically not in this state while docked.
*   **`Document`**: The central area, usually displaying tabbed documents.
*   **`Left`**: The region docked to the left edge of the `DockPanel`.
*   **`Right`**: The region docked to the right edge of the `DockPanel`.
*   **`Bottom`**: The region docked to the bottom edge of the `DockPanel`.
*   **`Top`**: (Value exists but seems unused in current examples/implementation - typically main menus/toolbars occupy the top).

## Usage

This enum is primarily used in two ways:

1.  **Setting Default Location:** Assign a `DockArea` value to the `DefaultDockArea` property of a `DockContent` (or derived `Document`/`ToolWindow`) instance *before* adding it to the `DockPanel`. This suggests where the content should initially appear.

    ```csharp
    using AcrylicUI.Docking;
    // ... inside your form or setup code ...

    var myToolWindow = new MyToolWindow();
    myToolWindow.DefaultDockArea = DockArea.Right; // Suggest docking to the right
    myDockPanel.AddContent(myToolWindow);

    var myDocument = new MyDocument();
    // No need to set DefaultDockArea for Document, it defaults to DockArea.Document
    myDockPanel.AddContent(myDocument);
    ```

2.  **Checking Current Location:** You can query the `DockArea` property of a `DockContent` instance to determine where it is currently located within the `DockPanel`.

    ```csharp
    using AcrylicUI.Docking;
    // ...

    DockContent currentContent = myDockPanel.ActiveContent;
    if (currentContent != null)
    {
        DockArea area = currentContent.DockArea; 
        // area will be DockArea.Document, DockArea.Left, etc.
        if (area == DockArea.Left)
        {
            // Content is currently in the left region
        }
    }
    ```

3.  **Accessing Regions:** Used internally by `DockPanel` to manage its `DockRegion` collections.

---

**See also:** [`DockPanel`](DockPanel.md), [`DockContent`](DockContent.md), [`DockRegion`](DockRegion.md) 