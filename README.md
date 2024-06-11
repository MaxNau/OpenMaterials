# Open Materials

This library provides unofficial clients for materials open data. As of now next clients are implemented:

|API Provider    |API link                       |Documentation                         |
|----------------|-------------------------------|-----------------------------|
|[The Materials Project](https://next-gen.materialsproject.org/)|https://next-gen.materialsproject.org/api            |https://api.materialsproject.org/docs            |



# Open Materials Providers

## The Materials Project

The Materials Project API allows anyone to have direct access to current, up-to-date information from the Materials Project database in a structured way.

This allows for analysis, development of automated tools, machine learning, downloading personal copies of the Materials Project database and more on a large scale.

### Usage

For DI-ready solutions use `MaterialsProject.DependencyInjection.Extensions` package which provides extensions for `ServiceCollection`:
- by passing your API key as one of the arguments:
	```csharp
	builder.Services.AddMaterialsProjectClient("<api-key>");
	```
- by using configuration:

	```yaml
	{
	  "MaterialsProjectConfiguration": {
		    "ApiKey": "<api key>",
		    "Url": "https://api.materialsproject.org/"
	  }
	}
	```
	and corresponding extension overload to provide `IConfiguration` object
	```csharp
	builder.Services.AddMaterialsProjectClient(configuration);
	```
	
Then in classes where you will use the client inject `IMaterialsProjectClient` via constructor:
```csharp
public class MlService : IMlService
{
	private readonly IMaterialsProjectClient _materialsProjectClient;
    
	public MlService(IMaterialsProjectClient materialsProjectClient)
	{
		_materialsProjectClient = materialsProjectClient;
	}
}
```

For non DI-ready solutions instantiate a client manually. Be aware that under the hood it uses `HttpClient` and to avoid `DNS` refresh issues follow `Microsoft` recommendations on how to use `HttpClient` properly:
- for .NET Core 2.1 or Greater or .NET 5.0 or Greater create single instance of `HttpClient` and configure the `SocketsHttpHandler`:
	```csharp
	var socketHttpHandler = new SocketsHttpHandler
		 {
	         PooledConnectionLifetime = TimeSpan.FromMinutes(2)
		 };
	var httpClient = new HttpClient(socketHttpHandler, false)
		 {
            BaseAddress = new Uri("<api url>")
		 };
	var client = new MaterialsProjectClient(httpClient, "<api key>");
	```
- for other .NET versions (.NET Framework etc) configure `ServicePointManager` - https://learn.microsoft.com/en-us/dotnet/api/system.net.servicepointmanager.dnsrefreshtimeout?view=netframework-4.6.2