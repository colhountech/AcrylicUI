# AcrylicPanel

`AcrylicPanel` is the base panel control for AcrylicUI, providing a simple container for grouping other controls with themed background and border styling. It replaces the standard `System.Windows.Forms.Panel`.

## Basic Usage

Add `AcrylicPanel` to your form or another container, set its layout properties (like `Dock`, `Size`, `Location`), and add child controls to its `Controls` collection.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using AcrylicUI.Resources;
using System.Windows.Forms;
using System.Drawing;

public partial class MyForm : AcrylicForm
{
    public MyForm()
    {
        InitializeComponent();

        // Panel acting as a toolbar area
        var topPanel = new AcrylicPanel
        {
            Dock = DockStyle.Top, // Dock to the top of the form
            Height = 40, 
            BackColor = Colors.MediumBackground, // Use a themed background color
            Padding = new Padding(5) // Add internal padding for child controls
        };
        Controls.Add(topPanel);

        // Add controls to the panel
        var btnAction1 = new AcrylicButton { Text = "Action 1", Dock = DockStyle.Left };
        var btnAction2 = new AcrylicButton { Text = "Action 2", Dock = DockStyle.Left };
        topPanel.Controls.Add(btnAction2); // Added in reverse to appear left-to-right when docked left
        topPanel.Controls.Add(btnAction1);

        // Another panel for content
        var contentPanel = new AcrylicPanel
        {
            Dock = DockStyle.Fill, // Fill remaining space
            Padding = new Padding(10)
        };
        Controls.Add(contentPanel); // Add below topPanel
        contentPanel.BringToFront(); // Ensure it's layered correctly if overlapping docks

        var contentLabel = new AcrylicLabel { Text = "Main content area", Dock = DockStyle.Top };
        contentPanel.Controls.Add(contentLabel);
    }
}
```

## Key Properties

*   `BackColor`: Gets or sets the background color of the panel. Use `AcrylicUI.Resources.Colors` for theme consistency.
*   `BorderColor`: Gets or sets the color of the panel's border.
*   `BorderStyle`: Gets or sets the style of the border (`None`, `FixedSingle`).
*   `Controls`: The collection of controls contained within the panel.
*   Standard layout properties like `Location`, `Size`, `Dock`, `Anchor`, `Padding`, `Margin`.

---

**See also:** Example Forms [`Form10_Panels.cs`](../../Examples/Form10_Panels.cs), [`Form14_SectionPanel.cs`](../../Examples/Form14_SectionPanel.cs) 