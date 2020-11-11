using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;
using Dapper;
using System.Text;
using System.Data;

namespace WebAPI.Repositories.Accounts
{
    public class AccountRepository : RepositoryBase, IAccountRepository
    {
        public AccountRepository(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Get all Account
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AccountInfo>> GetAllAsync()
        {
            using (var conn = OpenDBConnection())
            {
                var sql = "SELECT * FROM dbo.AccountInfo";
                return await conn.QueryAsync<AccountInfo>(sql);
            }
        }

        /// <summary>
        /// Check Account
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="userNo"></param>
        /// <returns></returns>
        public bool CheckAccount(IDbConnection conn, int userNo)
        {
            StringBuilder sql = new StringBuilder();
            sql.Length = 0;
            sql.AppendLine("SELECT SUM(CNT)                           ");
            sql.AppendLine("FROM (                                    ");
            sql.AppendLine("        SELECT                            ");
            sql.AppendLine("           COUNT(*) AS CNT                ");
            sql.AppendLine("        FROM dbo.AccountInfo              ");
            sql.AppendLine("        WHERE USER_NO = @USER_NO          ");
            sql.AppendLine("     )                                    ");

            int count = conn.ExecuteScalar<int>(sql.ToString(), new { user_no = userNo });
            return count > 0;
        }

        /// <summary>
        /// Find Account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<AccountInfo> FindAsync(int id)
        {
            using (var conn = OpenDBConnection())
            {
                var sql = "SELECT * FROM dbo.AccountInfo WHERE USER_NO = @user_no";
                var param = new { user_no = id };
                return await conn.QueryFirstOrDefaultAsync<AccountInfo>(sql, param);
            }
        }

        /// <summary>
        /// Create Account
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> InsertAsync(AccountInfo entity)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;

                sql.AppendLine(" INSERT INTO                            ");
                sql.AppendLine("      dbo.AccountInfo (USER_CD,         ");
                sql.AppendLine("                    USER_NAME,          ");
                sql.AppendLine("                    PASSWORD,           ");
                sql.AppendLine("                    FULL_NAME,          ");
                sql.AppendLine("                    EMAIL,              ");
                sql.AppendLine("                    PHONE,              ");
                sql.AppendLine("                    ADDRESS)            ");
                sql.AppendLine(" VALUES (@USER_CD,                      ");
                sql.AppendLine("         @USER_NAME,                    ");
                sql.AppendLine("         @PASSWORD,                     ");
                sql.AppendLine("         @FULL_NAME,                    ");
                sql.AppendLine("         @EMAIL,                        ");
                sql.AppendLine("         @PHONE,                        ");
                sql.AppendLine("         @ADDRESS)                      ");

                entity.USER_CD = Guid.NewGuid().ToString().GetHashCode().ToString("x");
                entity.PASSWORD = Convert.ToBase64String(Encoding.UTF8.GetBytes(entity.PASSWORD));

                var param = new { user_cd = entity.USER_CD, user_name = entity.USER_NAME, password = entity.PASSWORD,
                    full_name =entity.FULL_NAME,email=entity.EMAIL,phone=entity.PHONE, address=entity.ADDRESS };
                return await conn.ExecuteAsync(sql.ToString(), param);
            }
        }

        /// <summary>
        /// Update Account
        /// </summary>
        /// <param name="entityToUpdate"></param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(AccountInfo entity)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;

                sql.AppendLine(" UPDATE dbo.AccountInfo                ");
                sql.AppendLine("    SET USER_CD  = @USER_CD,           ");
                sql.AppendLine("        USER_NAME  = @USER_NAME,       ");
                sql.AppendLine("        PASSWORD   = @PASSWORD,        ");
                sql.AppendLine("        FULL_NAME  = @FULL_NAME,       ");
                sql.AppendLine("        EMAIL      = @EMAIL,           ");
                sql.AppendLine("        PHONE      = @PHONE,           ");
                sql.AppendLine("        ADDRESS    = @ADDRESS          ");
                sql.AppendLine(" WHERE USER_NO = @USER_NO              ");

                var param = new { user_cd=entity.USER_CD,user_name =entity.USER_NAME, password = entity.PASSWORD, full_name = entity.FULL_NAME, email = entity.EMAIL,
                                  phone = entity.PHONE, address = entity.ADDRESS, user_no = entity.USER_NO };
                return await conn.ExecuteAsync(sql.ToString(), param);
            }
        }

        /// <summary>
        /// Delete Account
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = OpenDBConnection())
            {
                var sql = "DELETE FROM dbo.AccountInfo WHERE USER_NO = @USER_NO";
                return await conn.ExecuteAsync(sql.ToString(), new { user_no = id });
            }
        }
    }
}
