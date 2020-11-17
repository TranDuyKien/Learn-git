using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories.Persons;
using WebAPI.Services.Persons;
using WebAPI.ViewModels;
using WebAPI.Common;

namespace WebAPI.Services.Persons
{
    public class PersonService : BaseService<PersonViewModel>, IPersonService
    {
        IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            this._personRepository = personRepository;
        }

        public async Task<IEnumerable<Person>> PaginationListHome(int pageIndex, int pageSize = 10)
        {
            int CheckOffset()
            {

                int Offset = (pageIndex - 1) * pageSize;
                return Offset;
            }
            var tempList = await _personRepository.PaginationListHome(pageIndex, pageSize, CheckOffset());

            return tempList;
        }

        public async Task<IEnumerable<Person>> GetAllPersonAndSkill()
        {
            return await _personRepository.GetAllPersonAndSkillAsync();
        }
        /// <summary>
        /// Get all Person
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Person>> GetAllPerson()
        {
            var countListPerson = await _personRepository.GetAllAsync();
            if (countListPerson.Count() > 0)
            {
                model.AppResult = new AppResult { Result = true, StatusCd = "200", Message = "List Person!", DataResult = model.PersonInfo };
            }
            return await _personRepository.GetAllAsync();
        }

        /// <summary>
        /// Get Person by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Person> GetPersonById(int id)
        {
            return await _personRepository.FindAsync(id);
        }

        /// <summary>
        /// Create Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public async Task<PersonViewModel> InsertPerson(Person person)
        {
            model.PersonInfo = person;
            model.PersonInfo.CreatedBy = WebAPI.Helpers.HttpContext.CurrentUser;
            var getdate = DateTime.Now.ToString("yyyyMMdd");
            int newestIdPerson = 1;
            DateTime.Now.ToString();
            if (Functions.HandlingEmail(person.Email) == true )
            {
                if (await _personRepository.AmountOfPerson() > 0)
                {
                    newestIdPerson = await _personRepository.GetMaxIdPerson() + 1;
                    person.StaffId = string.Format($"{getdate + newestIdPerson}");
                }
                else
                {
                    person.StaffId = string.Format($"{getdate + newestIdPerson}");
                }
                model.PersonInfo.Status = true;
                await _personRepository.InsertAsync(model.PersonInfo);
                model.PersonInfo.Id = newestIdPerson;
                model.AppResult= new AppResult { Result = true, StatusCd = "201", Message = "Successfully created! The request has succeeded and a new resource has been created as a result.!" , DataResult= model.PersonInfo};
                return model;
            }
            return model;
        }

        /// <summary>
        /// Update Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public async Task<PersonViewModel> UpdatePerson(Person person)
        {
            model.PersonInfo = person;
            model.PersonInfo.UpdatedBy = WebAPI.Helpers.HttpContext.CurrentUser;
            if (Functions.HandlingEmail(person.Email) == true)
            {
                await _personRepository.UpdateAsync(model.PersonInfo);
                int newestIdPerson = await _personRepository.GetMaxIdPerson() + 1;
                model.AppResult = new AppResult { Result = true, StatusCd = "200", Message = "Successfully updated! The request was fulfilled", DataResult= model.PersonInfo };
                return model;
            }
            return model;
        }

        /// <summary>
        /// Delete Person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<PersonViewModel> DeletePerson(int id)
        {
            int resultDelete = await _personRepository.DeleteAsync(id);
            if (resultDelete >0)
            {
                model.AppResult = new AppResult { Result = true, StatusCd = "200", Message = "Successfully deleted!" };
                return model;
            }
            model.AppResult = new AppResult { Result = false, StatusCd = "400", Message = "Bad request" };
            return model;
        }


        public async Task<IEnumerable<Person>> SearchPersonAndSkillAsync(string FullName, int Location, List<int> TechnologyId)
        {
            return await _personRepository.SearchPersonAndSkillAsync(FullName, Location, TechnologyId);
        }
    }
}
