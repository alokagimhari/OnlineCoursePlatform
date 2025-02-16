using OnlineCourseEnrollement.Data;
using OnlineCourseEnrollment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseEnrollment.Service
{
    public interface ICourseService
    {
        Task<List<CourseModel>> GetAllCoursesAsync(int ? categoryId = null);

        Task<CourseDetailModel> GetCousesDetailsAsync(int courseId);

    }

    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null)
        {
            return courseRepository.GetAllCoursesAsync(categoryId);
        }

        public Task<CourseDetailModel> GetCousesDetailsAsync(int courseId)
        {
            return courseRepository.GetCousesDetailsAsync(courseId);
        }
    }
}
