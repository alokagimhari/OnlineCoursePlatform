using OnlineCourseEnrollment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseEnrollement.Data
{
    /*public interface ICourseCategoryRepository
    {
        CourseCategory? GetById(int id);

        List<CourseCategory> GetCourseCategories();
    }*/

    public interface ICourseCategoryRepository
    {
        //async methods will always return task>t> and its method named as async as suffix
        Task<CourseCategory?> GetByIdAsync(int id);

        Task<List<CourseCategory>> GetCourseCategoriesAsync();
    }

}
