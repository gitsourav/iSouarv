using iSourav.Domain.Entities;
using System.Collections.Generic;

namespace iSourav.Domain.Interfaces.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}