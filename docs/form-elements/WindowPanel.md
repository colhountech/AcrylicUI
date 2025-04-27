# WindowPanel

`WindowPanel` is a fundamental container control in AcrylicUI, typically used as the main content panel directly within an `AcrylicForm` or `AcrylicDialog`. It provides support for rendering optional Acrylic/Glass backdrop effects (`IsAcrylic` property) and can display an optional header (`SectionHeader` and `Icon` properties).

It also plays a role in handling the window's non-client area interactions (like resizing) when used in a borderless form context.

## Basic Usage

Place a `WindowPanel` onto your `AcrylicForm` (usually via the designer), set its `Dock` property to `Fill`, and add other controls inside it.

```csharp
using AcrylicUI.Forms;
using AcrylicUI.Controls;
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    private WindowPanel mainPanel;

    public MyForm()
    {
        InitializeComponent(); // Assume mainPanel is added via designer

        // Configure the WindowPanel (can also be done in designer)
        mainPanel.Dock = DockStyle.Fill;
        mainPanel.IsAcrylic = true; // Enable acrylic effect for this panel
        mainPanel.SectionHeader = "Main Content Area";
        // Example: Set an icon (ensure you have an IconFactory and SVG source)
        // mainPanel.Icon = new IconFactory(...).BitmapFromSvg(...);
        mainPanel.RoundCorners = true; // Enable if using on Windows 11

        // Add content to the WindowPanel
        var label = new AcrylicLabel 
        { 
            Text = "Content goes here", 
            Location = new Point(10, 40), // Position below potential header 
            AutoSize = true 
        };
        mainPanel.Controls.Add(label);
    }
    
    // Required for resize support in borderless forms
    protected override void WndProc(ref Message message)
    {
        if (DesignMode) { base.WndProc(ref message); return; }

        var cursor = PointToClient(Cursor.Position);

        // Check if the message is related to non-client area mouse interactions
        if (WindowPanel.CheckResizeClientAreaHit(ClientSize, ref message, cursor))
        {                   
            return; // Message handled by WindowPanel for resizing
        }

        base.WndProc(ref message);
    }
}
```

## Key Properties

*   `IsAcrylic`: Gets or sets whether the panel background should render with the acrylic effect (requires Windows 10/11 and appropriate settings).
*   `SectionHeader`: Gets or sets the text displayed in the panel's header area (if visible).
*   `Icon`: Gets or sets the `Image` displayed in the header area next to the `SectionHeader`.
*   `RoundCorners`: Gets or sets whether the panel should attempt to round its corners (primarily for Windows 11 style).
*   `ProfileFeature`: (Usage unclear from examples, likely internal or specific feature toggle).
*   `Dock`: Standard WinForms property to control how the panel fills its parent.

## Static Methods

*   `CheckResizeClientAreaHit(clientSize, ref message, cursor)`: A helper method used within a Form's `WndProc` to delegate non-client area hit testing (like border resizing) to the `WindowPanel` when using borderless forms. 