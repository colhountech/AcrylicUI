# WindowPanel

## Explanation of `SnapOverlayThreshold` and `MaxSnapOverlay`


The constants `SnapOverlayThreshold` and `MaxSnapOverlay` are used in the `WndProc` method to control the behavior of the snap overlay when the maximize button is hovered over or pressed.

### Constants
* `SnapOverlayThreshold`: Defines the number of times the maximize button needs to be hovered over (or "hot") before the snap overlay is triggered.
* `MaxSnapOverlay`: Defines the maximum value for the `_showSnapOverlay` counter to prevent it from growing indefinitely.

### Purpose

The purpose of these constants is to control the behavior of the snap overlay when the maximize button is hovered over. The snap overlay is a visual indication that the window can be maximized. By using these constants, the code ensures that the snap overlay is only shown after the maximize button has been hovered over and received a certain number of Windows Pump message, preventing it from being triggered too easily.


### How It Works

1.	Initialization and Reset:

* The `_showSnapOverlay` counter is incremented each time the maximize button is hovered over.
* If the counter exceeds `MaxSnapOverlay`, it is reset to 0 to prevent it from growing indefinitely.

2.	Hover Detection:

* When the `WM_NCHITTEST` message is received, the code checks if the cursor is over the maximize button.
* If the maximize button is pressed, the counter is reset to 0.
* If the maximize button is hovered over (hot), the counter is incremented.

3.	Snap Overlay Trigger:

* If the counter exceeds `SnapOverlayThreshold`, the snap overlay is triggered by setting the message.Result to `HT_MAXBUTTON`.
* This indicates that the maximize button has been hovered over enough times to show the snap overlay.


##  Issue: Snap Overlay Popup Not Triggering Consistently


### Description

The current implementation of the snap overlay popup relies on receiving a certain number of events from the Windows message pump before triggering the snap overlay. This is controlled by the `SnapOverlayThreshold` and `MaxSnapOverlay` constants. The `_showSnapOverlay` counter is incremented each time the maximize button is hovered over, and the snap overlay is triggered once the counter exceeds the SnapOverlayThreshold.

### Problem

If the user hovers over the maximize button without making micro movements, the Windows message pump does not trigger any messages to the `WndProc` method. As a result, the `_showSnapOverlay` counter does not increment, and the snap overlay is not triggered. When the user clicks on the maximize button, it is still in the increment loop, and the window does not maximize as expected.


### Steps to Reproduce
1.	Hover over the maximize button without making micro movements.
2.	Observe that the snap overlay does not appear.
3.	Click on the maximize button.
4.	Notice that the window does not maximize as expected.

### Impact
This issue affects the user experience by preventing the snap overlay from appearing consistently and causing the maximize button to not function correctly when clicked.

### Proposed Solution

To address this issue, consider implementing a different mechanism to trigger the snap overlay that does not rely solely on the message pump. For example, you could use a timer to periodically check the hover state of the maximize button and trigger the snap overlay if the button is hovered over for a certain duration.


### Step-by-Step Implementation
1.	Add a Timer:

```c#
private Timer _hoverTimer;
```

2.	Initialize the Timer in the constructor:

	Initialize the Timer in the constructor and set its interval.


```c#
ublic WindowPanel()
{
    // ...
    // current init code
    // ..

    // Initialize the hover timer
    _hoverTimer = new Timer();
    _hoverTimer.Interval = 100; // Check every 100 milliseconds
    _hoverTimer.Tick += HoverTimer_Tick;
    _hoverTimer.Start();
}
```

3.	Check Hover State in Timer Tick Event:

In the Timer tick event, check if the maximize button is hovered over and increment the _showSnapOverlay counter accordingly.

```c#

private void HoverTimer_Tick(object sender, EventArgs e)
{
    const int SnapOverlayThreshold = 30;

    var cursor = this.PointToClient(Cursor.Position);

    if (IsControlBoxHit(cursor))
    {
        if (_max.IsPressed)
        {
            _showSnapOverlay = 0;
        }
        else if (_max.IsHot)
        {
            _showSnapOverlay++;
            if (_showSnapOverlay > SnapOverlayThreshold)
            {
                // Trigger the snap overlay
                var message = new Message();
                message.Msg = WinUserH.WM_NCHITTEST;
                message.Result = (IntPtr)(WinUserH.HT_MAXBUTTON);
                base.WndProc(ref message);
                _showSnapOverlay = 0; // Reset the counter after triggering
            }
        }
    }
    else
    {
        _showSnapOverlay = 0;
    }
}

```

4.	Trigger Snap Overlay:
•	If the counter exceeds the SnapOverlayThreshold, trigger the snap overlay.


5. remove increment code in winproc

```c#
protected override void WndProc(ref Message message)
{
    if (message.Msg == WinUserH.WM_NCHITTEST)
    {
        base.WndProc(ref message);

        if ((int)message.Result == WinUserH.HT_CLIENT)
        {
            var cursor = this.PointToClient(Cursor.Position);

            if (IsControlBoxHit(cursor))
            {
                if (_max.IsPressed)
                {
                    _showSnapOverlay = 0;
                }
                else if (_max.IsHot)
                {
                    // No need to increment here, handled by the timer
                }
                return;
            }
            _showSnapOverlay = 0;
            message.Result = (IntPtr)(WinUserH.HT_TRANSPARENT);
        }
    }
    else
    {
        base.WndProc(ref message);
    }
}
```

How do other developer trigger the snap overlay on customer controls that have customer max button?