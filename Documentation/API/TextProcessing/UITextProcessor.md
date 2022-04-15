# Class UITextProcessor

A text processor that uses the Unity UI Text element for display.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [TooltipText]
* [Methods]
  * [SetColor(Color)]
  * [SetSize(Single)]
  * [SetText(String)]

## Details

##### Inheritance

* System.Object
* [BaseTextProcessor]
* UITextProcessor

##### Namespace

* [Tilia.Visuals.Tooltip.TextProcessing]

##### Syntax

```
public class UITextProcessor : BaseTextProcessor
```

### Properties

#### TooltipText

The Text to render onto the tooltip.

##### Declaration

```
public Text TooltipText { get; set; }
```

### Methods

#### SetColor(Color)

Sets the color of the font on the associated text processor.

##### Declaration

```
public override void SetColor(Color color)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Color | color | The color to use. |

##### Overrides

[BaseTextProcessor.SetColor(Color)]

#### SetSize(Single)

Sets the size of the font on the associated text processor.

##### Declaration

```
public override void SetSize(float size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | size | The size to use. |

##### Overrides

[BaseTextProcessor.SetSize(Single)]

#### SetText(String)

Sets the text of the associated text processor.

##### Declaration

```
public override void SetText(string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text | The text to set. |

##### Overrides

[BaseTextProcessor.SetText(String)]

[BaseTextProcessor]: BaseTextProcessor.md
[Tilia.Visuals.Tooltip.TextProcessing]: README.md
[BaseTextProcessor.SetColor(Color)]: BaseTextProcessor.md#Tilia_Visuals_Tooltip_TextProcessing_BaseTextProcessor_SetColor_Color_
[BaseTextProcessor.SetSize(Single)]: BaseTextProcessor.md#Tilia_Visuals_Tooltip_TextProcessing_BaseTextProcessor_SetSize_System_Single_
[BaseTextProcessor.SetText(String)]: BaseTextProcessor.md#Tilia_Visuals_Tooltip_TextProcessing_BaseTextProcessor_SetText_System_String_
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[TooltipText]: #TooltipText
[Methods]: #Methods
[SetColor(Color)]: #SetColorColor
[SetSize(Single)]: #SetSizeSingle
[SetText(String)]: #SetTextString
