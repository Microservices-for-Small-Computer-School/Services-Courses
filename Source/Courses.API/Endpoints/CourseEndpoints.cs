using AutoMapper;
using Courses.API.Data.Dtos;
using Courses.API.Data.Entities;
using Courses.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Courses.API.Endpoints;

public static class CourseEndpoints
{
    public static void MapCourseEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup(CoursesRoutes.Prefix).WithTags(nameof(Course));

        _ = group.MapGet(CoursesRoutes.Root, async ([FromServices] SchoolDbContext schoolDbContext, [FromServices] IMapper mapper) =>
        {
            var coursesResponse = ApiResponseDto<IReadOnlyCollection<CourseDto>>
                                    .Create(mapper.Map<IReadOnlyCollection<CourseDto>>(await schoolDbContext.Courses.ToListAsync()));

            return Results.Ok(coursesResponse);
        });

    }
}
