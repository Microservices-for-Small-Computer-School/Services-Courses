using Courses.API.Business;
using Courses.API.Data.Dtos;
using Courses.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

_ = builder.Services.AddDbContext<SchoolDbContext>(options =>
                options.UseInMemoryDatabase(InMemoryDatabase.Name));

var app = builder.Build();

# region Hello World Endpoints
app.MapGet(HelloWorldRoutes.Root, () => "Hello Minimal API World from Root !!");

app.MapGet(HelloWorldRoutes.HelloWorld, () =>
{
    return ApiResponseDto<string>.Create("Hello Minimal API World from /hw !!");
});

app.MapGet(HelloWorldRoutes.Api, DefaultResponseBusiness.SendDefaultApiEndpointOutput);

app.MapGet(HelloWorldRoutes.ApiV1, () => DefaultResponseBusiness.SendDefaultApiEndpointV1Output());
#endregion

#region User Endpoints
app.MapGet(UsersRoutes.ActionById, ([FromRoute] string id, [FromQuery] string name) =>
{
    return ApiResponseDto<dynamic>.Create(new
    {
        UserId = id,
        Message = $"Hello {name}, Welcome to Minimal API World !!"
    });
});

app.MapPost(UsersRoutes.Root, ([FromBody] PersonDto person) =>
{
    return ApiResponseDto<dynamic>.Create(new
    {
        UserId = person.Id,
        UserName = person.Name,
    });
});
#endregion

#region Courses Endpoints
app.MapGet(CoursesRoutes.Root, async ([FromServices] SchoolDbContext schoolDbContext) =>
{
    return Results.Ok(await schoolDbContext.Courses.ToListAsync());
});
#endregion

if (app.Environment.IsDevelopment())
{
    // TODO: To be removed once we have .sqlproj
    using var scope = app.Services.CreateScope();
    using var context = scope.ServiceProvider.GetService<SchoolDbContext>();
    _ = (context?.Database.EnsureCreated());
}

app.Run();
