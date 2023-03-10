using Courses.API.Business;
using Courses.API.Data.Dtos;

namespace Courses.API.Endpoints;

public static class HelloWorldEndpoints
{

    public static void MapHelloWorldEndpoints(this IEndpointRouteBuilder routes)
    {
        _ = routes.MapGet(HelloWorldRoutes.Root, () => "Minimal API. Please visit /swagger for full documentation");

        _ = routes.MapGet(HelloWorldRoutes.HelloWorld, () =>
        {
            return ApiResponseDto<string>.Create("Hello Minimal API World from /hw !!");
        });

        _ = routes.MapGet(HelloWorldRoutes.Api, DefaultResponseBusiness.SendDefaultApiEndpointOutput);

        _ = routes.MapGet(HelloWorldRoutes.ApiV1, () => DefaultResponseBusiness.SendDefaultApiEndpointV1Output());
    }

}
