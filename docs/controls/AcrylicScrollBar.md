# AcrylicScrollBar

`AcrylicScrollBar` is the internal scroll bar control used by other AcrylicUI controls like `AcrylicListView` and `AcrylicDataGridView` to provide a themed scrolling experience. It is not typically intended for direct use in application forms.

## Usage

This control is used internally by other AcrylicUI container controls that require scrolling. You interact with scrolling via the properties and methods of the parent container (e.g., `AcrylicListView.ScrollTo()`, `AcrylicDataGridView.FirstDisplayedScrollingRowIndex`).

## Key Properties (Internal)

*   `Minimum`, `Maximum`: Defines the scroll range.
*   `Value`: The current scroll position.
*   `LargeChange`, `SmallChange`: The amount to scroll when clicking the track or arrow buttons.
*   `ScrollOrientation`: Determines if it's a `Vertical` or `Horizontal` scroll bar.

## Events (Internal)

*   `ValueChanged`: Occurs when the scroll position (`Value`) changes. 