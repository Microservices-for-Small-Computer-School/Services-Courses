using Courses.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

_ = builder.Services.ConfigureDependedServices();

var app = builder.Build();

app.ConfigureHttpRequestPipeline();

app.Run();
