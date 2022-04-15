# Class BaseTextProcessor

A basis for text elements that can be set and processed.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [SetColor(Color)]
  * [SetSize(Single)]
  * [SetText(String)]

## Details

##### Inheritance

* System.Object
* BaseTextProcessor
* [UITextProcessor]

##### Namespace

* [Tilia.Visuals.Tooltip.TextProcessing]

##### Syntax

```
public abstract class BaseTextProcessor : MonoBehaviour
```

### Methods

#### SetColor(Color)

Sets the color of the font on the associated text processor.

##### Declaration

```
public abstract void SetColor(Color color)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Color | color | The color to use. |

#### SetSize(Single)

Sets the size of the font on the associated text processor.

##### Declaration

```
public abstract void SetSize(float size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | size | The size to use. |

#### SetText(String)

Sets the text of the associated text processor.

##### Declaration

```
public abstract void SetText(string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text | The text to set. |

[UITextProcessor]: UITextProcessor.md
[Tilia.Visuals.Tooltip.TextProcessing]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[SetColor(Color)]: #SetColorColor
[SetSize(Single)]: #SetSizeSingle
[SetText(String)]: #SetTextString
