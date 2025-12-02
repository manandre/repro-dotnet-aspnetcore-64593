WebApplication.CreateBuilder(args)
    .Build()
    .Run();

// Make the implicit Program class public so test projects can access it
public partial class Program { }
