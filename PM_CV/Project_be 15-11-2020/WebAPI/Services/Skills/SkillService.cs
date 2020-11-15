using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories.Skills;
using WebAPI.RequestModel;
using WebAPI.ViewModels;

namespace WebAPI.Services.Skills
{
    public class SkillService : BaseService<SkillViewModel>, ISkillService
    {
        ISkillRepository _skillRepository;
        public SkillService(ISkillRepository skillRepository)
        {
            this._skillRepository = skillRepository;
        }

        /// <summary>
        /// Get Skill By PersonId
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Category>> GetSkillByPerson(int personId)
        {
            return await _skillRepository.GetSkillByPersonAsync(personId);
        }

        /// <summary>
        /// Inser Skill
        /// </summary>
        /// <param name="skillRequestModel"></param>
        /// <returns></returns>
        public async Task<AppResult> InserSkill(SkillRequestModel skillRequestModel)
        {
            List<PersonTechnology> personTechnologies = new List<PersonTechnology>();
            PersonCategory personCategory = new PersonCategory
            {
                PersonId = skillRequestModel.PersonId,
                CategoryId = skillRequestModel.CategoryId,
                OrderIndex = skillRequestModel.OrderIndex,
                CreatedBy = skillRequestModel.UserName,
                UpdatedBy = skillRequestModel.UserName
            };
            foreach (var item in skillRequestModel.TechnologyId)
            {
                PersonTechnology personTechnology = new PersonTechnology
                {
                    PersonId = skillRequestModel.PersonId,
                    TechnologyId = item,
                    CreatedBy = skillRequestModel.UserName,
                    UpdatedBy = skillRequestModel.UserName
                };
                personTechnologies.Add(personTechnology);
            }
            if (!await _skillRepository.CheckPersonCategoryAsync(personCategory))
            {
                if (await _skillRepository.CheckPersonCategoryOnDeleteAsync(personCategory))
                {
                    personCategory.UpdatedAt = DateTime.Now;
                    await _skillRepository.UpdatePersonCategoryInsertAsync(personCategory);
                }
                else
                {
                    await _skillRepository.InsertPersonCategoryAsync(personCategory);
                }

            }
            List<PersonTechnology> personTechnologiesUpdate = new List<PersonTechnology>();
            List<PersonTechnology> personTechnologiesInsert = new List<PersonTechnology>();
            foreach (var item in personTechnologies)
            {
                if (await _skillRepository.CheckPersonTechnologyOnDeleteAsync(item))
                {
                    item.UpdatedAt = DateTime.Now;
                    personTechnologiesUpdate.Add(item);
                }
                else
                {
                    personTechnologiesInsert.Add(item);
                }
            }
            int resultTechnologyInsert = 0;
            int resultTechnologyUpdate = 0;
            if (personTechnologiesUpdate.Count > 0)
            {
                resultTechnologyUpdate = await _skillRepository.UpdatePersonTechnologyInsertAsync(personTechnologiesUpdate);
            }
            resultTechnologyInsert = await _skillRepository.InsertListPersonTechnologyAsync(personTechnologiesInsert);
            AppResult appResult = new AppResult();
            if (resultTechnologyInsert > 0 || resultTechnologyUpdate > 0)
            {
                appResult = new AppResult { Result = true, StatusCd = "200", Message = "Success" };
            }
            else
            {
                appResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
            }
            return appResult;
        }

        /// <summary>
        /// Update Skill
        /// </summary>
        /// <param name="skillRequestModel"></param>
        /// <returns></returns>
        public async Task<AppResult> UpdateSkill(SkillRequestModel skillRequestModel)
        {
            List<PersonTechnology> personTechnologies = new List<PersonTechnology>();
            PersonCategory personCategory = new PersonCategory
            {
                PersonId = skillRequestModel.PersonId,
                CategoryId = skillRequestModel.CategoryId,
                OrderIndex = skillRequestModel.OrderIndex,
                CreatedBy = skillRequestModel.UserName,
                UpdatedBy = skillRequestModel.UserName
            };
            foreach (var item in skillRequestModel.TechnologyId)
            {
                PersonTechnology personTechnology = new PersonTechnology
                {
                    PersonId = skillRequestModel.PersonId,
                    TechnologyId = item,
                    CreatedBy = skillRequestModel.UserName,
                    UpdatedBy = skillRequestModel.UserName
                };
                personTechnologies.Add(personTechnology);
            }
            await _skillRepository.DeletePersonTechnologyToUpdateAsync(skillRequestModel.PersonId);
            int result = await _skillRepository.InsertListPersonTechnologyAsync(personTechnologies);
            AppResult appResult = new AppResult();
            if (result > 0)
            {
                appResult = new AppResult { Result = true, StatusCd = "200", Message = "Success" };
            }
            else
            {
                appResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
            }
            return appResult;
        }

        /// <summary>
        /// </summary>
        /// <param name="skillRequestModel"></param>
        /// <returns></returns>
        public async Task<AppResult> DeleteSkill(SkillRequestModel skillRequestModel)
        {
            PersonCategory personCategory = new PersonCategory
            {
                PersonId = skillRequestModel.PersonId,
                CategoryId = skillRequestModel.CategoryId,
                UpdatedAt = DateTime.Now,
                UpdatedBy = skillRequestModel.UserName
            };
            var resultCategory = await _skillRepository.DeletePersonCategoryAsync(personCategory);
            PersonTechnology personTechnology = new PersonTechnology
            {
                PersonId = skillRequestModel.PersonId,
                UpdatedAt = DateTime.Now,
                UpdatedBy = skillRequestModel.UserName
            };
            var resultTechnology = await _skillRepository.DeletePersonTechnologyAsync(personTechnology);
            AppResult appResult = new AppResult();
            if (resultCategory > 0 && resultTechnology >0)
            {
                appResult = new AppResult { Result = true, StatusCd = "200", Message = "Success" };
            }
            else
            {
                appResult = new AppResult { Result = false, StatusCd = "500", Message = "Fail" };
            }
            return appResult;
        }


        /// <summary>
        /// Get Skill By Category
        /// </summary>
        /// <param name="personCategory"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Technology>> GetSkilByCategoryy(SkillRequestModel skillRequestModel)
        {
            PersonCategory personCategory = new PersonCategory
            {
                PersonId = skillRequestModel.PersonId,
                CategoryId = skillRequestModel.CategoryId
            };
            return await _skillRepository.GetSkilByCategoryyAsync(personCategory);
        }
    }
}
