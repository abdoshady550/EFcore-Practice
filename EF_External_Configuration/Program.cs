using EF_External_Configuration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

internal class Program
{
    private static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var connStr = configuration.GetSection("constr").Value;




        var service = new ServiceCollection();


        // dependence injection

        service.AddDbContext<AppDbContext>(option =>
        option.UseSqlServer(connStr)
        );

        IServiceProvider serviceProvider = service.BuildServiceProvider();

        using (var context = serviceProvider.GetService<AppDbContext>())
        {
            foreach (var item in context!.Wallets)
            {
                Console.WriteLine(item);
            }
        }

        //}
        //cnotextFactory
        // service.AddDbContextFactory<AppDbContext>(option =>
        //option.UseSqlServer(connStr));

        // IServiceProvider serviceProvider = service.BuildServiceProvider();

        // var contextFactory = serviceProvider
        //     .GetService<IDbContextFactory<AppDbContext>>();

        // using (var context = contextFactory!.CreateDbContext())
        // {
        //     foreach (var item in context!.Wallets)
        //     {
        //         Console.WriteLine(item);
        //     }
        // }

        // ***********************************************
        //var optionsBuilder = new DbContextOptionsBuilder();
        //optionsBuilder.UseSqlServer(connStr);
        //var option = optionsBuilder.Options;

        //using (var context = new AppDbContext(option))
        //{
        //    foreach (var item in context.Wallets)
        //    {
        //        Console.WriteLine(item);

        //    }

        Console.ReadKey();
    }
}