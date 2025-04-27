# DockSplitter

`DockSplitter` is an internal class within the AcrylicUI docking framework that represents the draggable divider displayed between adjacent `DockRegion`s.

## Usage

Developers do not interact directly with `DockSplitter`. The `DockPanel` and its `DockRegion`s automatically create and manage the necessary `DockSplitter` instances based on the layout of the regions.

*   When two dock regions (e.g., Left and Document, or Document and Bottom) are adjacent and visible, a `DockSplitter` is typically displayed between them.
*   The `DockPanel.DockResizeFilter` (which must be added to `Application.MessageFilters`) monitors mouse events over these splitters.
*   When a user clicks and drags a `DockSplitter`, the filter initiates a resize operation, adjusting the sizes of the adjacent `DockRegion`s.

## Key Functionality (Internal)

*   Represents a specific edge (Left, Right, Top, Bottom) between two `DockRegion`s.
*   Calculates its screen bounds for drawing and hit-testing.
*   Provides properties (`Target`, `ResizeTarget`) indicating which `DockRegion`s it affects.
*   Used by `DockPanel.DockResizeFilter` to detect mouse interaction and manage resize operations.

---

**See also:** [`DockPanel`](DockPanel.md), [`DockRegion`](DockRegion.md) 