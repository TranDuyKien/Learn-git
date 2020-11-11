using WebAPI.Services.Persons;
using WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI.ViewModels;
using System.Linq;
using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class PersonController: BaseApiController<PersonViewModel>
    {
        private IPersonService _personService;
        public PersonController(IPersonService personSevice)
        {
            this._personService = personSevice;
        }
        /// <summary>
        /// Get all Person
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllPerson()
        {
            var employees = await _personService.GetAllPerson();
            apiResult.AppResult.DataResult = employees.AsEnumerable<PersonInfo>();
            
            return Ok(apiResult.AppResult);
        }

        /// <summary>
        /// Get Person by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPersonById(int id)
        {
            var app = await _personService.GetPersonById(id);
            apiResult.AppResult.DataResult = app;
            return Ok(apiResult.AppResult);
        }

        /*[HttpGet]
        public async Task<IActionResult> SearchPerson()
        {
            var app = await _personService.
        }*/

        /// <summary>
        /// Create Person
        /// </summary>
        /// <param name="personInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> InsertPerson([FromBody] PersonInfo personInfo)
        {
            var app = await _personService.InsertPerson(personInfo);
            return Ok(app.AppResult);
        }

        /// <summary>
        /// Update Person
        /// </summary>
        /// <param name="personInfo"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdatePerson([FromBody] PersonInfo personInfo)
        {
            var app = await _personService.UpdatePerson(personInfo);
            return Ok(app.AppResult);
        }

        /// <summary>
        /// Delete Person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeletePerson(int id)
        {
            var app = await _personService.DeletePerson(id);
            return Ok(app.AppResult);
        }
    }
}

