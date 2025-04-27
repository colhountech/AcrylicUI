# AcrylicGlassPanel

`AcrylicGlassPanel` is a panel control that renders a semi-transparent background, mimicking a "glass" effect. It can be used as a container for other controls or as a decorative element to layer UI components.

## Basic Usage

Add `AcrylicGlassPanel` to your form or another container. Set its `BackColor` to a semi-transparent color (using `Color.FromArgb` with an alpha value less than 255, or predefined colors like `AcrylicUI.Resources.Colors.AcrylicInnerPanel`). You can also set `ForeColor` for a subtle border and optionally enable `HasRoundedCorners`.

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

        // Example Glass Panel
        var glassPanel = new AcrylicGlassPanel
        {
            Location = new Point(30, 60),
            Size = new Size(300, 150),
            BackColor = Color.FromArgb(50, 200, 200, 200), // Semi-transparent white
            // Or use a predefined theme color:
            // BackColor = Colors.AcrylicInnerPanel, 
            ForeColor = Color.FromArgb(90, 220, 220, 220), // Subtle border color
            // Or use a predefined theme color:
            // ForeColor = Colors.AcrylicHairline,
            HasRoundedCorners = true,
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right // Example anchoring
        };
        Controls.Add(glassPanel);

        // Add controls inside the glass panel if needed
        var labelInside = new AcrylicLabel
        {
            Text = "Content on Glass",
            Location = new Point(15, 15),
            BackColor = Color.Transparent, // Make label background transparent
            ForeColor = Colors.LightText // Use a contrasting text color
        };
        glassPanel.Controls.Add(labelInside);
    }
}
```

## Key Properties

*   `BackColor`: Gets or sets the background color. Use `Color.FromArgb(alpha, red, green, blue)` with an `alpha` value below 255 for transparency.
*   `ForeColor`: Gets or sets the color used to draw the panel's border.
*   `HasRoundedCorners`: Gets or sets whether the panel should render with rounded corners.
*   `BorderThickness`: Gets or sets the thickness of the border.
*   Standard layout properties like `Location`, `Size`, `Dock`, `Anchor`.

---

**See also:** Example Form [`Form5_Borderless.cs`](../../Examples/Form5_Borderless.cs) 