using Courses.API.Configuration;
using Courses.API.Endpoints;
using Courses.API.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

_ = builder.Services.AddDbContext<SchoolDbContext>(options => options.UseInMemoryDatabase(InMemoryDatabase.Name));

_ = builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{  // TODO: To be removed once we have .sqlproj
    using var scope = app.Services.CreateScope();
    using var context = scope.ServiceProvider.GetService<SchoolDbContext>();
    _ = (context?.Database.EnsureCreated());
}

app.MapHelloWorldEndpoints();
app.MapUserEndpoints();
app.MapCourseEndpoints();

app.Run();
