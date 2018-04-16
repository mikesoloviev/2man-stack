using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

public class CustomDesignTimeServices : IDesignTimeServices
{
    public void ConfigureDesignTimeServices(IServiceCollection serviceCollection) {
        serviceCollection.AddSingleton<IPluralizer, CustomPluralizer>();
    }
}

public class CustomPluralizer : IPluralizer
{
    public string Pluralize(string name) {
        return name + "s";
    }

    public string Singularize(string name) {
        return name;
    }
}
