# AcrylicProgressBar

`AcrylicProgressBar` provides a progress bar control with AcrylicUI styling, visually indicating the progress of a lengthy operation.

## Basic Usage

Add `AcrylicProgressBar` to your form. Set its `Minimum` and `Maximum` properties (often 0 and 100 for percentage-based progress) and update its `Value` property as the operation progresses.

```csharp
using AcrylicUI.Controls;
using AcrylicUI.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

public partial class MyForm : AcrylicForm
{
    private AcrylicProgressBar progressBar;
    private AcrylicButton btnStartTask;

    public MyForm()
    {
        InitializeComponent();

        progressBar = new AcrylicProgressBar
        {
            Location = new Point(20, 50),
            Width = 300, 
            Height = 20,
            Minimum = 0,
            Maximum = 100,
            Value = 0
        };
        Controls.Add(progressBar);

        btnStartTask = new AcrylicButton
        {
            Text = "Start Long Task",
            Location = new Point(20, progressBar.Bottom + 10),
            Size = new Size(120, 32)
        };
        btnStartTask.Click += BtnStartTask_Click;
        Controls.Add(btnStartTask);
    }

    private async void BtnStartTask_Click(object sender, System.EventArgs e)
    {
        btnStartTask.Enabled = false;
        progressBar.Value = 0;

        // Simulate a long task
        for (int i = 0; i <= 100; i++)
        {
            // Update progress bar (ensure UI update is on the UI thread)
            UpdateProgress(i);
            
            // Simulate work
            await Task.Delay(50); 
        }

        AcrylicMessageBox.ShowInformation(this, "Task Completed!", "Progress");
        btnStartTask.Enabled = true;
    }

    private void UpdateProgress(int value)
    {
        // Ensure update happens on the UI thread if called from a background thread
        if (progressBar.InvokeRequired)
        {
            progressBar.Invoke(new Action(() => progressBar.Value = value));
        }
        else
        {
            progressBar.Value = value;
        }
    }
}
```

## Key Properties

*   `Value`: Gets or sets the current value (position) of the progress bar.
*   `Minimum`: Gets or sets the minimum value of the range (usually 0).
*   `Maximum`: Gets or sets the maximum value of the range (e.g., 100 for percentage).
*   `Step`: Gets or sets the amount by which to increment the current position when `PerformStep()` is called.
*   `Style`: Gets or sets the manner in which progress is indicated (`Blocks`, `Continuous`, `Marquee`). `Marquee` is useful for indicating activity without a specific progress value.

## Methods

*   `PerformStep()`: Advances the current position by the amount set in the `Step` property.
*   `Increment(value)`: Advances the current position by the specified amount. 