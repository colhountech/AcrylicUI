# AcrylicForm

`AcrylicForm` provides a modern Windows 11 style borderless window with custom-rendered chrome (title bar, min/max/close buttons). It supports rounded corners, snap layouts, and optional Acrylic backdrop effects, serving as a base class for application windows.

## Basic Usage

Inherit your form from `AcrylicUI.Forms.AcrylicForm` instead of `System.Windows.Forms.Form`.

```csharp
using AcrylicUI.Forms;
using System.Windows.Forms;

// Make sure your form inherits from AcrylicForm in the designer.cs file too!
public partial class MyCustomForm : AcrylicForm
{
    public MyCustomForm()
    {
        InitializeComponent(); // Standard WinForms designer init

        // Configure appearance (optional)
        this.Text = "My Acrylic Application";
        this.Size = new System.Drawing.Size(800, 600);

        // Add controls as usual via the designer or code
        var button = new AcrylicUI.Controls.AcrylicButton
        {
            Text = "Click Me",
            Location = new System.Drawing.Point(20, 50), // Adjust location below custom title bar
            Size = new System.Drawing.Size(100, 30)
        };
        this.Controls.Add(button);
    }
}
```

**Note:** Ensure the base class is also changed in the form's associated `.designer.cs` file. 