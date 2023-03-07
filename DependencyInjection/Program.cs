// See https://aka.ms/new-console-template for more information
//Author : Kassa
using System;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //uncomment each region at a time to demonstrate the functionality singleton, transient or scoped methods

            #region Singleton Dipendency Injection

            /*var serviceProvider = new ServiceCollection()
            .AddSingleton<IService, MyService>()
            .BuildServiceProvider();

            Console.WriteLine("   Dependency Injection Singleton");
            var serviceObject1 = serviceProvider.GetService<IService>();
            Console.WriteLine($"   Request 1 {serviceObject1.GetObjectCreationDateTime} ");

            for (int i = 0; i < 5000; i++) ;

            var serviceObject2 = serviceProvider.GetService<IService>();
            Console.WriteLine($"   Request 2 {serviceObject2.GetObjectCreationDateTime} ");


            for (int i = 0; i < 5000; i++) ;
            var serviceObject3 = serviceProvider.GetService<IService>();
            Console.WriteLine($"   Request 3 {serviceObject3.GetObjectCreationDateTime} ");*/
            #endregion

            #region Transient Dipendency Injection

            var serviceProvider = new ServiceCollection()
                        .AddTransient<IService, MyService>()
                        .BuildServiceProvider();

            Console.WriteLine(" Dependency Injection Transient");
            var serviceObject1 = serviceProvider.GetService<IService>();
            Console.WriteLine($" Request 1 {serviceObject1.GetObjectCreationDateTime} ");

            for (int i = 0; i < 5000; i++) ;

            var serviceObject2 = serviceProvider.GetService<IService>();
            Console.WriteLine($" Request 2 {serviceObject2.GetObjectCreationDateTime} ");


            for (int i = 0; i < 5000; i++) ;
            var serviceObject3 = serviceProvider.GetService<IService>();
            Console.WriteLine($" Request 3 {serviceObject3.GetObjectCreationDateTime} ");
            #endregion

            #region Scoped Dipendency Injection
            /*var serviceProvider = new ServiceCollection()
                        .AddScoped<IService, MyService>()
                        .BuildServiceProvider();


            Console.WriteLine("   Dependency Injection Scoped");
            Console.WriteLine("   Scope 1");

            using (var scope = serviceProvider.CreateScope())
            {
                Console.WriteLine($"   Request 1 {scope.ServiceProvider.GetService<IService>().GetObjectCreationDateTime}");
                for (int i = 0; i < 5000; i++);
                Console.WriteLine($"   Request 2 {scope.ServiceProvider.GetService<IService>().GetObjectCreationDateTime}");
            }

            Console.WriteLine("");
            Console.WriteLine("   Scope 2");
            using (var scope = serviceProvider.CreateScope())
            {
                Console.WriteLine($"   Request 1 { scope.ServiceProvider.GetService<IService>().GetObjectCreationDateTime }" );
                for (int i = 0; i < 5000; i++) ;
                Console.WriteLine($"   Request 2 { scope.ServiceProvider.GetService<IService>().GetObjectCreationDateTime } ");
            }*/
            #endregion
        }
    }
}
