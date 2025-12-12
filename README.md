
# ABHeicConverter


I use IPhone and it saves the fotos in HEIC format. I like it, but not all the services can work with it. That's why I needed an utility to convert the images.
I do not use Mac, I use Windows. And I couldn't find a free heic converter without advertisment. Also I wanted it to work with multiple images.

So I decided to make my own converter. It's a console app, that converts heic to jpg.
You can execute it from command line or powershell.

## Requirements
- Net Core 8

## Examples of usage
```
ABHeicConverter.exe -d C:\Dest\TestImages2
ABHeicConverter.exe -f C:\Dest\TestImages2\1234.heic
```

| Param | Description |
|----|---|
|-d  | Converts all the heic files in the directory |
|-f| Converts the file and saves the converted file in the same directory |
