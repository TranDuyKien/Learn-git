using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories.Categories;
using WebAPI.ViewModels;

namespace WebAPI.Services.Categories
{
    public class CategoryService : BaseService<CategoryViewModel>, ICategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }


        /// <summary>
        /// Get all Category
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Category>> GetAllCategory()
        {
            return await _categoryRepository.GetAllAsync();
        }

        /// <summary>
        /// Create Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<CategoryViewModel> InsertCategory(Category category)
        {
            model.Category = category;
            category.CreatedBy = "anhnh";
            category.UpdatedBy = "anhnh";
            if (await _categoryRepository.CheckCategoryAsync(category.Name))
                model.AppResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
            else
            {
                var modelCategory = await _categoryRepository.CheckCategoryOnDeleteAsync(category.Name);
                if (modelCategory == null)
                {
                    int result = await _categoryRepository.InsertAsync(category);
                    if (result > 0)
                        model.AppResult = new AppResult { Result = true, StatusCd = "201", Message = "Success" };
                    else
                        model.AppResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
                }
                else
                {
                    
                    int result = await _categoryRepository.UpdateCategoryToInsert(category);
                    if (result > 0)
                        model.AppResult = new AppResult { Result = true, StatusCd = "201", Message = "Success" };
                    else
                        model.AppResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
                }
            }
            return model;
        }

        /// <summary>
        /// Update Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<CategoryViewModel> UpdateCategory(Category category)
        {
            model.Category = category;
            category.UpdatedAt = DateTime.Now;
            category.UpdatedBy = "anhnh";
            if(await _categoryRepository.CheckCategoryAsync(category.Name))
                model.AppResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
            else
            {
                Category modelCategory = await _categoryRepository.CheckCategoryOnDeleteAsync(category.Name);
                if (modelCategory == null)
                {
                    int result = await _categoryRepository.UpdateAsync(category);
                    if (result > 0)
                    {
                        model.AppResult = new AppResult { Result = true, StatusCd = "200", Message = "Success" };
                    }
                    else
                    {
                        model.AppResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
                    }
                }
                else
                {
                    int result = await _categoryRepository.UpdateCategoryToInsert(category);
                    if (result > 0)
                        model.AppResult = new AppResult { Result = true, StatusCd = "201", Message = "Success" };
                    else
                        model.AppResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
                }
            }
            
            return model;
        }

        /// <summary>
        /// Delete Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoryViewModel> DeleteCategory(int id)
        {
            int result = await _categoryRepository.DeleteAsync(id);
            AppResult appResult = new AppResult();
            if (result > 0)
            {
                model.AppResult = new AppResult { Result = true, StatusCd = "200", Message = "Success" };
            }
            else
            {
                model.AppResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
            }
            return model;
        }
    }
}
