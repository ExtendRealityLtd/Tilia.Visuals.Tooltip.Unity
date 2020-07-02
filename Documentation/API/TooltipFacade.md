# Class TooltipFacade

The public interface for the Tooltip prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [FacingSource]
  * [FontColor]
  * [FontSize]
  * [InnerBackgroundColor]
  * [LineOrigin]
  * [OuterBackgroundColor]
  * [TooltipText]
* [Methods]
  * [OnAfterFontColorChange()]
  * [OnAfterFontSizeChange()]
  * [OnAfterInnerBackgroundColorChange()]
  * [OnAfterLineOriginChange()]
  * [OnAfterOuterBackgroundColorChange()]
  * [OnAfterTooltipTextChange()]

## Details

##### Inheritance

* System.Object
* TooltipFacade

##### Namespace

* [Tilia.Visuals.Tooltip]

##### Syntax

```
public class TooltipFacade : MonoBehaviour
```

### Properties

#### Configuration

The linked Internal Setup.

##### Declaration

```
public TooltipConfigurator Configuration { get; protected set; }
```

#### FacingSource

The source that the tooltip will face towards.

##### Declaration

```
public GameObject FacingSource { get; set; }
```

#### FontColor

The font color for the text of the tooltip.

##### Declaration

```
public Color FontColor { get; set; }
```

#### FontSize

The font size for the text of the tooltip.

##### Declaration

```
public int FontSize { get; set; }
```

#### InnerBackgroundColor

The color for the inner background of the tooltip.

##### Declaration

```
public Color InnerBackgroundColor { get; set; }
```

#### LineOrigin

The origin to draw the tooltip line from.

##### Declaration

```
public GameObject LineOrigin { get; set; }
```

#### OuterBackgroundColor

The color for the outer background of the tooltip.

##### Declaration

```
public Color OuterBackgroundColor { get; set; }
```

#### TooltipText

The text to display on the tooltip.

##### Declaration

```
public string TooltipText { get; set; }
```

### Methods

#### OnAfterFontColorChange()

Called after [FontColor] has been changed.

##### Declaration

```
protected virtual void OnAfterFontColorChange()
```

#### OnAfterFontSizeChange()

Called after [FontSize] has been changed.

##### Declaration

```
protected virtual void OnAfterFontSizeChange()
```

#### OnAfterInnerBackgroundColorChange()

Called after [InnerBackgroundColor] has been changed.

##### Declaration

```
protected virtual void OnAfterInnerBackgroundColorChange()
```

#### OnAfterLineOriginChange()

Called after [LineOrigin] has been changed.

##### Declaration

```
protected virtual void OnAfterLineOriginChange()
```

#### OnAfterOuterBackgroundColorChange()

Called after [OuterBackgroundColor] has been changed.

##### Declaration

```
protected virtual void OnAfterOuterBackgroundColorChange()
```

#### OnAfterTooltipTextChange()

Called after [TooltipText] has been changed.

##### Declaration

```
protected virtual void OnAfterTooltipTextChange()
```

[Tilia.Visuals.Tooltip]: README.md
[TooltipConfigurator]: TooltipConfigurator.md
[FontColor]: TooltipFacade.md#FontColor
[FontSize]: TooltipFacade.md#FontSize
[InnerBackgroundColor]: TooltipFacade.md#InnerBackgroundColor
[LineOrigin]: TooltipFacade.md#LineOrigin
[OuterBackgroundColor]: TooltipFacade.md#OuterBackgroundColor
[TooltipText]: TooltipFacade.md#TooltipText
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[FacingSource]: #FacingSource
[FontColor]: #FontColor
[FontSize]: #FontSize
[InnerBackgroundColor]: #InnerBackgroundColor
[LineOrigin]: #LineOrigin
[OuterBackgroundColor]: #OuterBackgroundColor
[TooltipText]: #TooltipText
[Methods]: #Methods
[OnAfterFontColorChange()]: #OnAfterFontColorChange
[OnAfterFontSizeChange()]: #OnAfterFontSizeChange
[OnAfterInnerBackgroundColorChange()]: #OnAfterInnerBackgroundColorChange
[OnAfterLineOriginChange()]: #OnAfterLineOriginChange
[OnAfterOuterBackgroundColorChange()]: #OnAfterOuterBackgroundColorChange
[OnAfterTooltipTextChange()]: #OnAfterTooltipTextChange
