using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.ViewModels;

namespace WebAPI.Services.Accounts
{
    public interface IAccountService
    {
        /// <summary>
        /// Get all Account
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<AccountInfo>> GetAllAccount();

        /// <summary>
        /// Get Account by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<AccountInfo> GetAccountById(int id);

        /// <summary>
        /// Create Account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public Task<AccountViewModel> InsertAccount(AccountInfo account);

        /// <summary>
        /// Update Account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public Task<AccountViewModel> UpdateAccount(AccountInfo account);

        /// <summary>
        /// Delete Account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<AccountViewModel> DeleteAccount(int id);
    }
}
