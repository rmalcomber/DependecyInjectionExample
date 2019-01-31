# Dependency Injection Example
Here is a simple example of using dependency injection within a DotNetCore console application. This is provided to show how easy it is to set up and run dependency injection. 


### Runing the code
I have only tested this in Visual Studio 2017/2019 Preview on a windows machine. However this should be applicable for Mac and Linux with DotNetCore. 


In `Program.cs` there are this lines 

``` csharp
var writers = provider.GetServices<IWriter>();
foreach (var writer in writers)
{
    TextToWrite.WriteText(writer, authorProvider);
}
```

It should be faily simple to only add one item to your service collection, for example in the function `ConfigureWriters()`

``` csharp
private static void ConfigureWriters(IServiceCollection serviceCollection)
{
    serviceCollection.AddTransient<IWriter, ConsoleWriter>();

}
```

And update the lines as follows

``` csharp
var writer = provider.GetService<IWriter>();

TextToWrite.WriteText(writer, authorProvider);
```