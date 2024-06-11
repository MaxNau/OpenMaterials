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
- by passing your API key as one of the arguments
	```csharp
	builder.Services.AddMaterialsProjectClient("<api-key>");
	```
- by using configuration

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