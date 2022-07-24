# Color Pallet

This wee document is an attempt to bring all the control colors into aligment

# AcrylicLabel : Label

* BackColor - Transparent 
* ForeColor - LightText

## What I need

 * DefaultBackColor 
*  DefaultFillColor 
 * DefaultForeColor 

# AcrylicTitle : Label

* Text - LightText
* Line - GreyHighlight

Notes: Needs Scaling Work

## What I need

* DefaultText - 
* InnerBorder (a Light Border) - 
* Background is borked - need to remove translucent background inherited from Label

# AcrylicSectionPanel : Panel

* FillBody - GreyBackground
* Text - LightText
* Header Fill = ContainsFocus ? BlueBackground : HeaderBackground
* Header DarkBorder = ContainsFocus ? DarkBlueBorder : DarkBorder;
* Header LightBorder = ContainsFocus ? LightBlueBorder : LightBorder;

Notes: Needs Scaling Work

## What I need

 * DefaultBackColor -
 * DefaultFillColor - 
 * DefaultText - 
 * -
 * HeaderFill - 
 * HeaderFill.InActive - 
 * - 
 * HeaderText - a standard text color for all headers and Titles
 * HeaderText.Inactive - 
 * -
 * InnerBorder - a Light Border
 * OuterBorder - a Dark Border
 * InnerBorder.Inactive - a Light Border for controls that don't have focus
 * OuterBorder.Inactive - a Dark Border for controls that don't have focus

# AcrylicScrollBar : Control

* Background - Not Set (Was MediumBackground )
* Arrow backgrounds - Not Set (Was White)
* ScrollColor - GreySelection;
* ScrollColor.Hot - GreyHighlight;
* ScrollColor.IsScrolling - ActiveControl;

Notes: Needs Scaling Work

## What I need
* ScrollColor 
* ScrollColor.Hot
* ScrollColor.Scrolling

# AcrylicNumericUpDown

* ForeColor - Gainsboro
* BackColor - LightBackground
* FillColor - HeaderBackground
* Border - GreySelection
* Border (Focused && TabStop) - BlueHighlight

Notes: 
* Scaling Enabled
* _arrowDisabledIcon not set
* Icons not scaled (Use to SvgIcon pattern from AcrylitTreeView)

## What I need

 * ControlBackground
 * - 
 * ControlFill
 * ControlBorder
 * ControlText
 * - 
 * ControlFill.Pressed
 * ControlBorder.Pressed
 * ControlText.Pressed
 * - 
 * ControlFill.Hot
 * ControlBorder.Hot
 * ControlText.Hot
 * - 
 * ControlFill.Disabled (maybe not required)
 * ControlBorder.Disabled
 * ControlText.Disabled


# AcrylicCheckBox

* Text - LightText
* Text.Disabled - DisabledText

* Border - LightText
* Border.Focssed - BlueHighlight
* Border.Hover - BlueHighlight
* Border.Pressed - GreyHighlight
* Border.Disabled - GreyHighlight

* FillColor - LightestBackground
* FillColor.Focssed - BlueSelection
* FillColor.Hover - BlueSelection
* FillColor.Pressed - GreySelection
* FillColor.Disabled - GreySelection

Notes: Needs Scaling Work

# AcrylicPanel : Panel

* Border - DarkBorder
* Border (when ForeColor == Transparent) = Transparent
* FillColor - GreyBackground
* FillColor (when BackColor == Transparent) = Transparent

Notes: 
* Needs Scaling Work
* HadRoundedCornder - Default false


# AcrylicDataGridView : UserControl

* BackColor.Header - DataGridTitleBar
* BackColor.IsOdd - DataGridOddRow
* BackColor - DataGridEvenRow
* BackColor.Selection - DataGridCheckboxSelectionBackground
* BackColor.SelectionFocussed - DataGridCheckboxSelectionFocussedBackground
* -
* ForeColor.Selection - DataGridSelectedText
* -
* Outline - InnerBorder
* -
* BackgroundColor				- DocumentBackcolor
* VerticalScrollBar.BackColor	- DocumentScrollbar
* HorizontalScrollBar.BackColor - DocumentScrollbar
* -
* Button.BorderColor			- BtnOutline
* Button.BorderColor.Selection  - BtnHotOutline
* Button.BorderColor.Disabled	- DisabledOutline
* -
* Button.FillColor			- BtnFill
* Button.FillColor.Pressed	- BtnPressedFill
* Button.FillColor.Hover	- BtnHotFill
* -
* Button.TextColor.Disabled - DisabledText


Notes: Needs Scaling Work


