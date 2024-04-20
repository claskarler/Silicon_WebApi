using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class CourseFactory
{
    public static CourseModel Create(CourseEntity entity)
    {
        try
        {
            return new CourseModel
            {
                Id = entity.Id,
                Title = entity.Title,
                Author = entity.Author,
                OriginalPrice = entity.OriginalPrice,
                DiscountPrice = entity.DiscountPrice,
                Hours = entity.Hours,
                LikesInProcent = entity.LikesInProcent,
                NumberOfLikes = entity.NumberOfLikes,
                IsBestseller = entity.IsBestseller,
                IsDigital = entity.IsDigital,
                Image = entity.Image,
                Category = entity.Category != null ? entity.Category.CategoryName : null
            };
        }
        catch { }
        return null!;
    }

    public static IEnumerable<CourseModel> Create(List<CourseEntity> entities)
    {
        List<CourseModel> courses = [];

        try
        {
            foreach (var entity in entities)
            {
                courses.Add(Create(entity));
            }

        }
        catch { }
        return courses;
    }

}
