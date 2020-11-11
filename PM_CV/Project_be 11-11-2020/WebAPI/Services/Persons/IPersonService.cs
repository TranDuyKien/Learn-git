using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.ViewModels;

namespace WebAPI.Services.Persons
{
    public interface IPersonService
    {
        /// <summary>
        /// Get all Person
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<PersonInfo>> GetAllPerson();

        /// <summary>
        /// Get Person by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<PersonInfo> GetPersonById(int id);

        /// <summary>
        /// Create Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Task<PersonViewModel> InsertPerson(PersonInfo person);

        /// <summary>
        /// Update Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Task<PersonViewModel> UpdatePerson(PersonInfo person);

        /// <summary>
        /// Delete Person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<PersonViewModel> DeletePerson(int id);
    }
}
