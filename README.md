
# Kong Admin Api Client
This is a .NET client to interact with the Kong Admin API.

Kong 1.0.x had a nice documentation but no client was available for it. We processed the documentation and created a [swagger.yaml](docs/swagger.yaml) file from the most important endpoints, then we generated a client with [Autorest](https://github.com/Azure/autorest). We added a couple of extensions to the generated classes so with this library it is easy to operate Kong.

## API documentation
Though Kong 1.0.x has a community maintained documentation about it's REST interface:

* [Admin Api](https://docs.konghq.com/1.0.x/admin-api/)
* [JWT plugin](https://docs.konghq.com/hub/kong-inc/jwt/)
* [ACL plugin](https://docs.konghq.com/hub/kong-inc/acl/)

We decided to create our version of the documentation in swagger 2.0 so the [Autorest](https://github.com/Azure/autorest) can generate the code from it. **Documentation can be found in [/docs/swagger.yaml](docs/swagger.yaml)**.

**Note** that we've never tested with newer versions of Kong, just with Kong 1.0.x

## Usage
It is recommended to reference this project as a git submodule. Later we will make a NuGet from it.

Instantiate the KongAdminAPI class

```
var client = new HttpClient();
var api = new KongAdminAPI(client, false)
{
	BaseUri = new Uri($"http://{KongAdminHost}:{KongAdminPort}")
};
```

Then use the methods of the KongAdminAPI class. There is a method for every documented endpoint.

### Create a service in Kong:

```
var serviceUpsert = new ServiceUpsert
{
	Name = "TestService",
	Protocol = "http",
	Host = "test-service.com",
	Port = 80,
};
var service = await api.AddServiceAsync(serviceUpsert);
```

### Create a route in Kong:
```
var routeUpsert = new RouteUpsert
{
    Name = "routes",
    Paths = new List<string>
    {
        "/test-endpoint",
    },
    StripPath = false
};
var route = await api.AddRouteAsync(service.Id, routeUpsert);
```

### Add JWT plugin to Kong:
```
var jwtPlugin = new PluginUpsert
{
    Name = "jwt",
};
await api.AddPluginAsync(service.Id, jwtPlugin);
```

## Modify the code
* If you want to change something in the client you'll have to update the [swagger.yaml](docs/swagger.yaml) file
* You have to install and run [Autorest](https://github.com/Azure/autorest) to regenerate the code. Run the power shell script: `/docs/build.ps1`
* This will regenerate the KongAdminAPI and the Model classes
* In the [Override](Override/) folder you can modify the partial classes manually. Here we provide some comfort functionality for the Model classes.

Feel free to add a pull request if you believe you extended the client or added some value to our project. So it will be easier to operate with Kong thru the admin API for others as well.
