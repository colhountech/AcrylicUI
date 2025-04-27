# AcrylicTitle

`AcrylicTitle` is a label control specifically styled for use as a title or prominent heading within the AcrylicUI theme. It inherits from `AcrylicLabel` and typically renders with a larger or bolder font and a distinct color.

## Basic Usage

Add `AcrylicTitle` to your form where you need a heading, and set its `Text` property.

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

        var mainTitle = new AcrylicTitle
        {
            Text = "User Configuration",
            Location = new Point(20, 20),
            AutoSize = true
            // ForeColor can often be left as default for titles
        };
        Controls.Add(mainTitle);

        // Add other controls below the title
        var subLabel = new AcrylicLabel
        {
            Text = "Adjust settings below:",
            Location = new Point(20, mainTitle.Bottom + 10),
            AutoSize = true
        };
        Controls.Add(subLabel);
    }
}
```

## Key Properties

Inherits all properties from `AcrylicLabel`:
*   `Text`: The title text.
*   `ForeColor`: The color of the title text (often defaults to `Colors.LightText` or similar).
*   `AutoSize`: Controls automatic resizing.
*   `TextAlign`: Controls text alignment.
*   Standard layout properties (`Location`, `Size`, `Dock`, `Anchor`).

---

**See also:** [`AcrylicLabel`](AcrylicLabel.md), Example Forms [`Form11_Labels.cs`](../../Examples/Form11_Labels.cs), [`Form15_ComboBox.cs`](../../Examples/Form15_ComboBox.cs) 