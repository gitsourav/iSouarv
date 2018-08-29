using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using iSourav.Domain.Interfaces.Repositories;
using iSourav.Domain.Entities;

namespace iSourav.Business
{
    public class Course123Repository : ICourseRepository
    {
        public void Add(Course entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Course> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> Find(Expression<Func<Course, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            var c = new Course(){ Id = 1, Description = "Test description" };
            return c;
        }

        public IEnumerable<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            throw new NotImplementedException();
        }

        public void Remove(Course entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Course> entities)
        {
            throw new NotImplementedException();
        }

        public Course SingleOrDefault(Expression<Func<Course, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
