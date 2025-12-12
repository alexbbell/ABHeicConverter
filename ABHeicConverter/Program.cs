using ABHeicConverter;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using System.CommandLine;

Console.WriteLine("----- ABHEICConverter Started ----");

// 1. Define CLI options
Option<string> fileOption = new Option<string>("--file", "-f")
{
    Description = "Path to the file"
};
Option<string> dirOption = new Option<string>("--dir", "-d")
{
    Description = "Path to the directory with images"
};


var verboseOption = new Option<bool>("--verbose", "-v")
{
    Description = "Enable verbose logging"
};

// 2. Setup DI container
var services = new ServiceCollection();
services.AddLogging(builder =>
{
    builder.ClearProviders();
    builder.AddNLog();  // standard NLog provider
});

var serviceProvider = services.BuildServiceProvider();
var logger = serviceProvider.GetRequiredService<ILoggerFactory>()
                            .CreateLogger("App");

// 3. Create root command & handlers
var root = new RootCommand("My App");

root.Add(fileOption);
root.Add(dirOption);
root.Add(verboseOption);




root.SetAction( (parseResult ) =>
{

    string fname = parseResult.GetValue(fileOption);
    string dirname= parseResult.GetValue(dirOption);

    var imageProcessing = new ImageProcessing();
    Console.WriteLine($"Hello, {fname ?? "World"}!");
    logger.LogInformation($"File: {fname}");

    bool verbose = parseResult.GetValue(verboseOption);
    if(dirname!=null)
    {
        logger.LogInformation($"{dirname} is processed");
        var dirObj = new DirectoryReader(dirname);
        string[] files = dirObj.GetDirectoryFiles();
        string[] newImages = new string[files.Length];
        for(int i=0; i< files.Length-1; i++)
        {
            newImages[i] = imageProcessing.ProcessImage(dirname, files[i]);
            Console.WriteLine(newImages[i]);
        }
        return;
    }
    if (verbose)
        logger.LogInformation("Verbose mode enabled");

    if (fname != null)
    {
        dirname = Path.GetDirectoryName(fname);
        
        string newImage = imageProcessing.ProcessImage(dirname, fname);

        Console.WriteLine(newImage);
        if (fname is not null)
        {
            logger.LogInformation("Processing file: {file}", fname);
        }
    }

});

// 4. Run command parser
root.Parse(args).Invoke();

