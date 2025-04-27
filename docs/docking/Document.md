# Document

`Document` is a base class, derived from `DockContent`, used for creating primary document windows within the AcrylicUI docking framework. These typically represent files or main work areas and reside in the central, tabbed document region of the `DockPanel`.

## Basic Usage

Create a new class that inherits from `AcrylicUI.Docking.Document`. Add controls to it using the designer or code. Set properties like `DockText` (often the document name or title) and `SerializationKey` in the constructor. Add an instance of your class to the `DockPanel`.

```csharp
using AcrylicUI.Docking;
using AcrylicUI.Controls;
using System.Windows.Forms;
using System.Drawing;

// 1. Define your custom Document
public class TextEditorDocument : Document
{
    private AcrylicTextBox editorTextBox;
    private string _filePath;

    public TextEditorDocument(string filePath)
    {
        _filePath = filePath;

        // Configure Document properties (inherited from DockContent)
        DockText = System.IO.Path.GetFileName(filePath); // Tab text
        // Icon = ... // Optional icon
        // DefaultDockArea is automatically Document
        SerializationKey = $"TextEditor_{filePath}"; // Unique key for layout saving

        // Add controls
        editorTextBox = new AcrylicTextBox
        {
            Dock = DockStyle.Fill,
            Multiline = true,
            ScrollBars = ScrollBars.Vertical,
            Font = new Font("Consolas", 9.75F) // Example editor font
        };
        Controls.Add(editorTextBox);

        LoadFile();
    }

    private void LoadFile()
    {
        // Placeholder: Load file content into editorTextBox
        try { 
             editorTextBox.Text = System.IO.File.ReadAllText(_filePath); 
        }
        catch (System.Exception ex) {
             editorTextBox.Text = $"Error loading file: {ex.Message}";
        }
    }
    
    // Add Save methods, etc.
}

// 2. Use your custom Document in your main form
public partial class MyMainForm : AcrylicUI.Forms.AcrylicForm
{
    private AcrylicUI.Docking.DockPanel dockPanel;

    public MyMainForm()
    {
        InitializeComponent(); // Assume dockPanel exists
        OpenFile("C:\\path\\to\\myfile.txt"); // Example call
    }

    private void OpenFile(string path)
    {
        // Optional: Check if document is already open
        // ... 

        var newDocument = new TextEditorDocument(path);
        dockPanel.AddContent(newDocument);
    }
}
```

## Key Properties

*   Inherits all key properties from `DockContent`:
    *   `DockText`: Text for the document tab.
    *   `Icon`: Icon for the document tab.
    *   `DefaultDockArea`: Defaults to `DockArea.Document`.
    *   `SerializationKey`: Key for layout persistence.
*   Standard `UserControl` properties (`Controls`, `Padding`, etc.).

## Events

*   Inherits events from `DockContent` (`DockTextChanged`, etc.).
*   Standard `UserControl` events.

---

**See also:** [`DockContent`](DockContent.md), [`DockPanel`](DockPanel.md), [`ToolWindow`](ToolWindow.md), Example Form [`Form6_DockPanel.cs`](../../Examples/Form6_DockPanel.cs) 