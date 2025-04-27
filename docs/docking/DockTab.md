# DockTab

`DockTab` is an internal class within the AcrylicUI docking framework that represents a single tab displayed within a `DockGroup`'s tab area.

## Usage

Developers do not interact directly with `DockTab`. The `DockGroup` automatically creates and manages `DockTab` instances for each `DockContent` it contains (if tabs are visible).

*   When a `DockGroup` contains more than one `DockContent` (or exactly one in the `Document` area), it creates a `DockTab` for each `DockContent`.
*   The `DockGroup` is responsible for calculating the width, position, and appearance of each `DockTab`.
*   It handles mouse interactions with the tabs (clicks for activation, clicks on the close button, dragging for reordering).

## Key Functionality (Internal)

*   Associated with a specific `DockContent`.
*   Stores calculated layout information (`ClientRectangle`, `CloseButtonRectangle`).
*   Maintains state information (`Hot`, `CloseButtonHot`).
*   Provides methods for calculating width (`CalculateWidth`).

---

**See also:** [`DockGroup`](DockGroup.md), [`DockContent`](DockContent.md) 