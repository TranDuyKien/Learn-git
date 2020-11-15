﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories.Interfaces;
using WebAPI.ViewModels;

namespace WebAPI.Repositories.Skills
{
    public interface ISkillRepository/*:IRepositoryBase<SkillViewModel>*/
    {
        /// <summary>
        /// Get Skill By PersonId
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        Task<IEnumerable<Category>> GetSkillByPersonAsync(int personId);

        /// <summary>
        /// Check PersonCategory
        /// </summary>
        /// <param name="personCategory"></param>
        /// <returns></returns>
        Task<bool> CheckPersonCategoryAsync(PersonCategory personCategory);

        /// <summary>
        /// Check PersonCategory On Delete
        /// </summary>
        /// <param name="personCategory"></param>
        /// <returns></returns>
        Task<bool> CheckPersonCategoryOnDeleteAsync(PersonCategory personCategory);

        /// <summary>
        /// Update PersonCategory to Insert
        /// </summary>
        /// <param name="personCategory"></param>
        /// <returns></returns>
        Task<int> UpdatePersonCategoryInsertAsync(PersonCategory personCategory);

        /// <summary>
        /// Insert PersonCategory
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> InsertPersonCategoryAsync(PersonCategory entity);

        /// <summary>
        /// Check PersonTechnology
        /// </summary>
        /// <param name="personTechnology"></param>
        /// <returns></returns>
        Task<bool> CheckPersonTechnologyOnDeleteAsync(PersonTechnology personTechnology);

        /// <summary>
        /// Update PersonTechnology to Insert
        /// </summary>
        /// <param name="personTechnologies"></param>
        /// <returns></returns>
        Task<int> UpdatePersonTechnologyInsertAsync(List<PersonTechnology> personTechnologies);

        /// <summary>
        /// Create List PersonTechnology
        /// </summary>
        /// <param name="personTechnologies"></param>
        /// <returns></returns>
        Task<int> InsertListPersonTechnologyAsync(List<PersonTechnology> personTechnologies);

        /// <summary>
        /// Delete PersonTechnology
        /// </summary>
        /// <param name="personTechnology"></param>
        /// <returns></returns>
        Task<int> DeletePersonTechnologyAsync(PersonTechnology personTechnology);

        /// <summary>
        /// Delete PersonCategory
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        Task<int> DeletePersonCategoryAsync(PersonCategory category);

        /// <summary>
        /// Check number of PersonTechnology
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        Task<int> CheckNumberOfPersonTechnology(int personId);

        /// <summary>
        /// Delete PersonTechnology to Update
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        Task<int> DeletePersonTechnologyToUpdateAsync(int personId);

        /// <summary>
        /// Get Skill By Category
        /// </summary>
        /// <param name="personCategory"></param>
        /// <returns></returns>
        Task<IEnumerable<Technology>> GetSkilByCategoryyAsync(PersonCategory personCategory);


    }
}
