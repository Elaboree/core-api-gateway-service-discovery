# Implementation web api gateway with service discovery using ocelot and consul  :earth_americas:

### Built With

* NET6
* [Ocelot](https://ocelot.readthedocs.io/en/latest/introduction/gettingstarted.html)
* [Consul](https://www.consul.io/)

<br/>


<!-- Keynotes -->
## Configuration insights :rocket:

- For the ocelot settings please check `Web.ApiGateway/Configurations/ocelot.json`
- Service registration for `consul` please check `Services/SomeService/Extensions/ConsulRegistration.cs`
- Services needs service discovery address for registration `Services/SomeService/appsettings.json`
- Project includes basic docker configuration about consul `docker-compose-files/consul` :whale2:
