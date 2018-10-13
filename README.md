# EmojiPicker
[![Build Status](https://bezysoftware.visualstudio.com/Emoji%20Picker/_apis/build/status/Emoji%20Picker)](https://bezysoftware.visualstudio.com/Emoji%20Picker/_build/latest?definitionId=40)

Emoji Picker Dialog for UWP

![Demo](https://i.imgur.com/oFMU7AD.gif) 

It also supports the dark theme :)

<img src="https://camo.githubusercontent.com/137e6ac2348744696494fd925aedbfac21609984/68747470733a2f2f692e696d6775722e636f6d2f445a53454975302e706e67" alt="Dark theme" data-canonical-src="https://i.imgur.com/DZSEIu0.png" style="max-width:100%" width="400" height="400">

## Installation

```
Install-Package EmojiPicker
```

[Nuget](https://www.nuget.org/packages/EmojiPicker)

## Usage

```csharp
using EmojiPicker;
...
var emoji = await EmojiPicker.ShowAsync();
```
