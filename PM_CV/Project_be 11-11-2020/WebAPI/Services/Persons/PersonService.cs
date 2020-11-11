using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories.Persons;
using WebAPI.Services.Persons;
using WebAPI.ViewModels;

namespace WebAPI.Services.Persons
{
    public class PersonService : BaseService<PersonViewModel>, IPersonService
    {
        IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            this._personRepository = personRepository;
        }

        /// <summary>
        /// Get all Person
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PersonInfo>> GetAllPerson()
        {
            return await _personRepository.GetAllAsync();
        }

        /// <summary>
        /// Get Person by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<PersonInfo> GetPersonById(int id)
        {
            return await _personRepository.FindAsync(id);
        }

        /// <summary>
        /// Create Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public async Task<PersonViewModel> InsertPerson (PersonInfo person)
        {
            model.PersonInfo = person;
            await _personRepository.InsertAsync(model.PersonInfo);
            return model;
        }

        /// <summary>
        /// Update Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public async Task<PersonViewModel> UpdatePerson(PersonInfo person)
        {
            model.PersonInfo = person;
            var gettime = DateTime.Now.ToString("yyyyMMdd");
            int newestIdPerson = await _personRepository.GetMaxIdPerson();
            person.StaffId = string.Format($"{gettime + newestIdPerson}");
            await _personRepository.UpdateAsync(model.PersonInfo);
            return model;
        }

        /// <summary>
        /// Delete Person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<PersonViewModel> DeletePerson(int id)
        {
            await _personRepository.DeleteAsync(id);
            return model;
        }
    }
}
