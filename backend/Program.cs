using Microsoft.JSInterop.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!"); // Using "anonomous functions"
app.MapGet("hellous/", HelloMehthod);

app.Run();

string HelloMehthod()
{
    var helloFolder = new DirectoryInfo(Directory.GetCurrentDirectory());
    var helloPath = Path.Combine(helloFolder.FullName, "hello.txt");


    // print to console absolute path (FullName)
    Console.WriteLine($"Reading hello from: {helloPath}");
    // in spe

    var message = File.ReadAllText(helloPath);
    return "Read from FILE:\n\n" + message;


}
