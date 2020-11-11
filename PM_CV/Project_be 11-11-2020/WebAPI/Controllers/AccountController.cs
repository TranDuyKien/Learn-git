using WebAPI.Services.Accounts;
using WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI.ViewModels;
using System.Linq;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class AccountController : BaseApiController<AccountViewModel>
    {
        private IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        /// <summary>
        /// Get all Account
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllAccount()
        {
            var employees = await _accountService.GetAllAccount();
            apiResult.AppResult.DataResult = employees.AsEnumerable<AccountInfo>();
            return Ok(apiResult.AppResult);
        }

        /// <summary>
        /// Get Account by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAccountById(int id)
        {
            var app = await _accountService.GetAccountById(id);
            apiResult.AppResult.DataResult = app;
            return Ok(apiResult.AppResult);
        }

        /// <summary>
        /// Create Account
        /// </summary>
        /// <param name="accountInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> InsertAccount([FromBody] AccountInfo accountInfo)
        {
            var app = await _accountService.InsertAccount(accountInfo);
            return Ok(app.AppResult);
        }

        /// <summary>
        /// Update Account
        /// </summary>
        /// <param name="accountInfo"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateAccount([FromBody] AccountInfo accountInfo)
        {
            var app = await _accountService.UpdateAccount(accountInfo);
            return Ok(app.AppResult);
        }

        /// <summary>
        /// Delete Account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            var app = await _accountService.DeleteAccount(id);
            return Ok(app.AppResult);
        }
    }
}
