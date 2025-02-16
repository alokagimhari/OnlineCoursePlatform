using Microsoft.EntityFrameworkCore;
using OnlineCourseEnrollment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseEnrollement.Data


{


    /* 
     * All thse are called sync method 
     * this is the primary constructior 
     * public class CourseCategoryRepository(OnlineCourseDbContext dbContext) : ICourseCategoryRepository
     {
         private readonly OnlineCourseDbContext dbContext = dbContext;

     this meand if the record is not present in will return null
         public CourseCategory? GetById(int id)
         {
             var data = dbContext.CourseCategories.Find(id);
             return data;
          }

         public List<CourseCategory> GetCourseCategories()
         {
             throw new NotImplementedException();
         }
     }*/

    public class CourseCategoryRepository : ICourseCategoryRepository
    {
        private readonly OnlineCourseDbContext dbContext;

        public CourseCategoryRepository(OnlineCourseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<CourseCategory?> GetByIdAsync(int id)
        {
            var data = dbContext.CourseCategories.FindAsync(id).AsTask();
            return data;
        }

        public Task<List<CourseCategory>> GetCourseCategoriesAsync()
        {

            var data = dbContext.CourseCategories.ToListAsync();
            return data;
        }
    }
}
