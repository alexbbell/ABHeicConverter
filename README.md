
# ABHeicConverter


I like HEIC, but I ran into a few problems:
- Many online converters are not free
- Most free tools are full of ads
- Some don’t support batch conversion
- I don’t use macOS, only Windows

- So I decided to build my own solution.

## What is this?
This is a simple Windows console application that converts HEIC images to JPG.I do not use Mac, I use Windows. And I couldn't find a free heic converter without advertisment. Also I wanted it to work with multiple images.
It’s designed to be:

- Free
- Fast
- Ad-free
- Batch-friendly
- Easy to use from Command Prompt or PowerShell

## Features
- Convert HEIC → JPG
- Process multiple images at once
- Works on Windows
- No GUI, no ads, no tracking
- Ideal for scripting and automation


## Examples of usage
```
ABHeicConverter.exe -d C:\Dest\TestImages2
ABHeicConverter.exe -f C:\Dest\TestImages2\1234.heic
```

| Param | Description                                                            |
| ----- | ---------------------------------------------------------------------- |
| `-d`  | Converts all `.heic` files in the specified directory                  |
| `-f`  | Converts a single `.heic` file and saves the JPG in the same directory |


## Requirements
- Net Core 8
