# AcrylicTransparentLabel

`AcrylicTransparentLabel` is a label control designed to have a transparent background, allowing controls or images behind it to show through. It performs custom drawing to achieve this effect.

## Basic Usage

Add `AcrylicTransparentLabel` to your form, typically on top of another control or panel where transparency is desired. Set its `Text` and `ForeColor` properties.

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

        // Example: Place over a Glass Panel
        var backgroundPanel = new AcrylicGlassPanel
        {
            Dock = DockStyle.Fill,
            BackColor = Color.FromArgb(50, 100, 100, 150) // Semi-transparent blue
        };
        Controls.Add(backgroundPanel);

        var transparentLabel = new AcrylicTransparentLabel
        {
            Text = "This text has a transparent background",
            Location = new Point(30, 30),
            AutoSize = true,
            ForeColor = Colors.LightText // Choose a color visible against the background
        };
        // Add to the background panel so transparency works relative to it
        backgroundPanel.Controls.Add(transparentLabel);
        transparentLabel.BringToFront(); // Ensure it's layered on top
    }
}
```

## Key Properties

*   `Text`: Gets or sets the text displayed by the label.
*   `ForeColor`: Gets or sets the color of the text.
*   `Font`: Gets or sets the font used to display the text.
*   `AutoSize`: Gets or sets whether the control automatically resizes based on its contents.
*   Standard layout properties (`Location`, `Size`).

**Note:** Unlike standard labels, `BackColor` is not used as the background is inherently transparent. 