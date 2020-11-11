using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repositories.Accounts;
using WebAPI.ViewModels;

namespace WebAPI.Services.Accounts
{
    public class AccountService : BaseService<AccountViewModel>, IAccountService
    {
        IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            this._accountRepository = accountRepository;
        }

        /// <summary>
        /// Get all Account
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AccountInfo>> GetAllAccount()
        {
            return await _accountRepository.GetAllAsync();
        }

        /// <summary>
        /// Get Account by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<AccountInfo> GetAccountById(int id)
        {
            return await _accountRepository.FindAsync(id);
        }

        /// <summary>
        /// Create Account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task<AccountViewModel> InsertAccount(AccountInfo account) {
            model.AccountInfo = account;
            await _accountRepository.InsertAsync(model.AccountInfo);
            return model;
        }

        /// <summary>
        /// Update Account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task<AccountViewModel> UpdateAccount(AccountInfo account)
        {
            model.AccountInfo = account;
            await _accountRepository.UpdateAsync(model.AccountInfo);
            return model;
        }

        /// <summary>
        /// Delete Account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<AccountViewModel> DeleteAccount(int id)
        {
            await _accountRepository.DeleteAsync(id);
            return model;
        }
    }
}
