var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet(HelloWorldRoutes.Root, () => "Hello Minimal API World from Root !!");

//app.MapGet(HelloWorldRoutes.HelloWorld, () =>
//{
//    return ApiResponseDto<string>.Create("Hello Minimal API World from /hw !!");
//});

//app.MapGet(HelloWorldRoutes.Api, DefaultResponseBusiness.SendDefaultApiEndpointOutput);

//app.MapGet(HelloWorldRoutes.ApiV1, () => DefaultResponseBusiness.SendDefaultApiEndpointV1Output());

app.Run();

//public static class Constants
//{
//    public static class HelloWorldRoutes
//    {
//        public static string Root => "/";

//        public static string HelloWorld => "/hw";

//        public static string Api => "/api";

//        public static string ApiV1 => "/api/v1";
//    }
//}

//public record ApiResponseDto<T>
//{
//    public bool Success { get; set; }

//    public string? Message { get; set; }

//    public DateTimeOffset DateRequested => DateTimeOffset.UtcNow;

//    public T? Data { get; set; }

//    public static ApiResponseDto<T> Create(T? data = default, string message = "Success", bool success = true)
//    {
//        return new()
//        {
//            Success = success,
//            Message = message,
//            Data = data
//        };
//    }
//}

//public static class DefaultResponseBusiness
//{
//    public static ApiResponseDto<string> SendDefaultApiEndpointOutput()
//    {
//        return ApiResponseDto<string>.Create("Welcome to Minimal API Endpoint");
//    }

//    public static ApiResponseDto<string> SendDefaultApiEndpointV1Output()
//    {
//        return ApiResponseDto<string>.Create("Welcome to Minimal API Endpoint V1");
//    }
//}

