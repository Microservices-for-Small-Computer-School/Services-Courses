namespace Courses.API.ApplicationCore.Common;

public static class Constants
{
    public static class HelloWorldRoutes
    {
        public static string Root => "/";

        public static string HelloWorld => "/hw";

        public static string Api => "/api";

        public static string ApiV1 => "/api/v1";
    }

    public static class UsersRoutes
    {
        public static string Root => "/api/users";

        public static string ActionById => "/api/users/{id}";
    }

    public static class CoursesRoutes
    {
        public static string Root { get; } = "/api/courses";
    }

    public static class InMemoryDatabase
    {
        public static string Name { get; } = "SchoolDatabase";
    }
}