using OnlineCourseEnrollment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseEnrollement.Data
{
    public interface ICourseRepository
    {
        Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null);

        Task<CourseDetailModel> GetCousesDetailsAsync(int couseId);
    }
}
