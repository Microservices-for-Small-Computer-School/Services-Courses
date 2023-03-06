using Courses.API.Business;
using Courses.API.Data.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet(HelloWorldRoutes.Root, () => "Hello Minimal API World from Root !!");

app.MapGet(HelloWorldRoutes.HelloWorld, () =>
{
    return ApiResponseDto<string>.Create("Hello Minimal API World from /hw !!");
});

app.MapGet(HelloWorldRoutes.Api, DefaultResponseBusiness.SendDefaultApiEndpointOutput);

app.MapGet(HelloWorldRoutes.ApiV1, () => DefaultResponseBusiness.SendDefaultApiEndpointV1Output());

app.Run();
