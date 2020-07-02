# Class TooltipConfigurator

Configures Tooltip prefab based on the provided settings and implements the logic to display the tooltip.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [lastFacadeLineOriginPosition]
  * [lastLineAnchorPosition]
* [Properties]
  * [Facade]
  * [InnerImage]
  * [LineRenderer]
  * [OuterImage]
  * [TooltipLineAnchor]
  * [TooltipText]
* [Methods]
  * [ConfigureBackground()]
  * [ConfigureLine()]
  * [ConfigureText()]
  * [LookAtFacingSource()]
  * [OnEnable()]
  * [Process()]
  * [ToggleLineVisibility()]
  * [UpdateLinePosition()]
* [Implements]

## Details

##### Inheritance

* System.Object
* TooltipConfigurator

##### Implements

IProcessable

##### Namespace

* [Tilia.Visuals.Tooltip]

##### Syntax

```
public class TooltipConfigurator : MonoBehaviour, IProcessable
```

### Fields

#### lastFacadeLineOriginPosition

The last frame position of the Facade.LineOrigin.

##### Declaration

```
protected Vector3 lastFacadeLineOriginPosition
```

#### lastLineAnchorPosition

The last frame position of the [TooltipLineAnchor].

##### Declaration

```
protected Vector3 lastLineAnchorPosition
```

### Properties

#### Facade

The public interface facade.

##### Declaration

```
public TooltipFacade Facade { get; protected set; }
```

#### InnerImage

The Image to render as the tooltip inner background.

##### Declaration

```
public Image InnerImage { get; protected set; }
```

#### LineRenderer

The UnityEngine.LineRenderer to draw a line from tooltip to target.

##### Declaration

```
public LineRenderer LineRenderer { get; protected set; }
```

#### OuterImage

The Image to render as the tooltip outer background.

##### Declaration

```
public Image OuterImage { get; protected set; }
```

#### TooltipLineAnchor

The GameObject use as the anchor point for the line.

##### Declaration

```
public GameObject TooltipLineAnchor { get; protected set; }
```

#### TooltipText

The Text to render onto the tooltip.

##### Declaration

```
public Text TooltipText { get; protected set; }
```

### Methods

#### ConfigureBackground()

Configures the tooltip background.

##### Declaration

```
public virtual void ConfigureBackground()
```

#### ConfigureLine()

Configures the rendered line to the tooltip.

##### Declaration

```
public virtual void ConfigureLine()
```

#### ConfigureText()

Configures the tooltip text.

##### Declaration

```
public virtual void ConfigureText()
```

#### LookAtFacingSource()

Forces the tooltip to point towards the Facade.FacingSource.

##### Declaration

```
protected virtual void LookAtFacingSource()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### Process()

Processes the visualization of the tooltip.

##### Declaration

```
public virtual void Process()
```

#### ToggleLineVisibility()

Toggles the visibility of the tooltip line depending on whether there is a valid origin.

##### Declaration

```
protected virtual void ToggleLineVisibility()
```

#### UpdateLinePosition()

Updates the position of the tooltip line.

##### Declaration

```
protected virtual void UpdateLinePosition()
```

### Implements

IProcessable

[Tilia.Visuals.Tooltip]: README.md
[TooltipLineAnchor]: TooltipConfigurator.md#TooltipLineAnchor
[TooltipFacade]: TooltipFacade.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[lastFacadeLineOriginPosition]: #lastFacadeLineOriginPosition
[lastLineAnchorPosition]: #lastLineAnchorPosition
[Properties]: #Properties
[Facade]: #Facade
[InnerImage]: #InnerImage
[LineRenderer]: #LineRenderer
[OuterImage]: #OuterImage
[TooltipLineAnchor]: #TooltipLineAnchor
[TooltipText]: #TooltipText
[Methods]: #Methods
[ConfigureBackground()]: #ConfigureBackground
[ConfigureLine()]: #ConfigureLine
[ConfigureText()]: #ConfigureText
[LookAtFacingSource()]: #LookAtFacingSource
[OnEnable()]: #OnEnable
[Process()]: #Process
[ToggleLineVisibility()]: #ToggleLineVisibility
[UpdateLinePosition()]: #UpdateLinePosition
[Implements]: #Implements
