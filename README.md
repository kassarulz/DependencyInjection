
# Dependency Injection in .NET Core

Dependency Injection (DI) is a software design pattern that helps decouple components in a system by allowing them to depend on abstractions instead of concrete implementations. This allows for greater flexibility, maintainability, and testability in your code.

In .NET, the built-in Dependency Injection framework makes it easy to implement this pattern in your applications. In this article, we'll explore the basics of Dependency Injection in .NET and the three main methods for registering services: AddScoped, AddTransient, and AddSingleton

# Getting Started with Dependency Injection
At its core, Dependency Injection involves two main components: a service (or interface) that needs to be implemented, and a class that provides that implementation. The goal is to separate the interface from its implementation, so that the implementation can be changed without affecting the rest of the code that depends on the interface

# Step-by-Step Instructions
1.	Open Visual Studio and select "Create a new project"
2.	Select ".NET 6.0" as the target framework
3.	Choose "Console App (.NET)" as the project template
4.	Give the project a name (e.g. "DependencyInjectionDemo") and choose a location to save it
5.	Click "Create"

Now that we have our project set up, let's create an interface for our service. In the Solution Explorer, right-click on the project name and select "Add > New Item". Choose "Interface" from the list of options, and name the interface "IService.cs". Here's the code for the interface:

    namespace DependencyInjection
    {
        public interface IService
        {
            public string GetObjectCreationDateTime();
        }
    }
As you can see, we've defined an interface called `IService` with a single method called `GetObjectCreationDateTime()`.

Next, let's create a class that implements this interface. In the Solution Explorer, right-click on the project name and select "Add > Class". Name the class "MyService.cs". Here's the code for the class:

    namespace DependencyInjection
    {
        public class MyService : IService
        {
            string _currentDateTime;
            public MyService()
            {
                this._currentDateTime = DateTime.Now.ToString("MMMM-dd hh.mm.ss.ffffff");
            }
            public void PrintMethod()
            {
                Console.WriteLine("Hello from MyService!");
            }
    
            public string GetObjectCreationDateTime
            {
                get { return this._currentDateTime; }
            }
        }
    }
This class implements the `IService` interface and provides an implementation for the `GetObjectCreationDateTime()` method that writes the object's creation time to the console.

Now we're ready to set up our dependency injection container. In the `Program.cs` file, replace the existing code with the code provided in the repository

This code sets up a `ServiceCollection`, which is used to register our services with the dependency injection container. We register our `MyService` implementation with the container using `AddScoped`, `AddTransient`, and `AddSingleton`.

-   `AddScoped`: A new instance of the registered service will be created for each scope. A scope is typically created around a web request or a unit of work.
-   `AddTransient`: A new instance of the registered service will be created each time it is requested.
-   `AddSingleton`: A single instance of the registered service will be created for the lifetime of the application.
