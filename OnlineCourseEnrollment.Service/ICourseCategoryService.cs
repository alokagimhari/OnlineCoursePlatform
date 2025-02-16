using OnlineCourseEnrollment.Core.Models;
using OnlineCourseEnrollement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseEnrollment.Service
{
    //this is the place we need to perform business logic since our app is small we might not see business logic immediately 
    
    public interface ICourseCategoryService
    {
        Task<CourseCategoryModel?> GetByIdAsync(int id);

        Task<List<CourseCategoryModel>> GetCourseCategoriesAsync();
    }
    
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly ICourseCategoryRepository categoryRepository;

        public CourseCategoryService(ICourseCategoryRepository categoryRepository) { 
        this.categoryRepository = categoryRepository;
        }
        public async Task<CourseCategoryModel?> GetByIdAsync(int id)
        {
            // use the await for the call to get it 
            //we cant directly return as our return model is different that entity model
           var data =  await categoryRepository.GetByIdAsync(id);//this awit jkeyword complier to pause the execution untill data is retrived
            return new CourseCategoryModel()
            {
                CategoryId = data.CategoryId,
                CategoryName = data.CategoryName,
                Description = data.Description,
            };
        }

        public async Task<List<CourseCategoryModel>> GetCourseCategoriesAsync()
        {
            var data = await categoryRepository.GetCourseCategoriesAsync();
           var modelData = data.Select(s => new CourseCategoryModel()
            {
                CategoryId = s.CategoryId,
                CategoryName = s.CategoryName,
                Description = s.Description,
            }).ToList();

            return modelData;
        }
    }

}
