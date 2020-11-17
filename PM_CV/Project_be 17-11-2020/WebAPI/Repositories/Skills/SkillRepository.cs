using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories.Skills
{
    public class SkillRepository : RepositoryBase, ISkillRepository
    {
        public SkillRepository(string connectionString) : base(connectionString) { }

        /// <summary>
        /// Get Skill By PersonId
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Category>> GetSkillByPersonAsync(int personId)
        {
            using (var conn = OpenDBConnection())
            {

                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.AppendLine("SELECT ca.Id, ca.Name, te.Id, te.Name, te.CategoryId, PC.ID, PC.OrderIndex   ");
                sql.AppendLine("FROM PersonTechnology AS PT                            ");
                sql.AppendLine("INNER JOIN Technology AS TE                            ");
                sql.AppendLine("ON PT.TechnologyId = TE.Id                             ");
                sql.AppendLine("INNER JOIN Category AS CA                              ");
                sql.AppendLine("ON CA.Id = TE.CategoryId                               ");
                sql.AppendLine("INNER JOIN PersonCategory AS PC                        ");
                sql.AppendLine("ON PC.CategoryId = TE.CategoryId                       ");
                sql.AppendLine("WHERE PT.PersonId = @PersonId                          ");
                sql.AppendLine("       AND PT.Status = 1 AND PT.Status = 1             ");
                sql.AppendLine("       AND TE.Status = 1 AND CA.Status =1              ");
                sql.AppendLine("AND PC.Status = 1 ORDER BY PC.OrderIndex               ");
                var lookup = new Dictionary<int, Category>();
                var param = new { personId = personId };
                await conn.QueryAsync<Category, Technology, PersonCategory, Category>(sql.ToString(), (m, n, g) =>
                {
                    Category movie = new Category();
                    if (!lookup.TryGetValue(m.Id, out movie))
                        lookup.Add(m.Id, movie = m);
                    if (movie.Technologies == null)
                        movie.Technologies = new List<Technology>();
                    movie.Technologies.Add(n);
                    if (movie.PersonCategories == null)
                        movie.PersonCategories = new List<PersonCategory>();
                    int x = 0;
                    foreach (var item in movie.PersonCategories)
                    {
                        if (g.Id == item.Id)
                            x++;
                    }
                    if (x <= 0)
                        movie.PersonCategories.Add(g);
                    return movie;
                }, param);
                var movies = lookup.Values.ToList();
                return movies;
            }
        }

        /// <summary>
        /// Create List PersonTechnology
        /// </summary>
        /// <param name="personTechnologies"></param>
        /// <returns></returns>
        public async Task<int> InsertListPersonTechnologyAsync(List<PersonTechnology> personTechnologies)
        {
            using (var conn = OpenDBConnection())
            {
                var trans = conn.BeginTransaction();
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("INSERT INTO ");
                sql.Append("        PersonTechnology (CreatedBy,            ");
                sql.Append("                          UpdatedBy,             ");
                sql.Append("                          PersonId,             ");
                sql.Append("                          TechnologyId)         ");
                sql.Append("VALUES (@CreatedBy,                             ");
                sql.Append("        @UpdatedBy,                             ");
                sql.Append("        @PersonId,                              ");
                sql.Append("        @TechnologyId)                          ");
                var result = await conn.ExecuteAsync(sql.ToString(), personTechnologies, transaction: trans);
                trans.Commit();
                return result;
            }
        }

        /// <summary>
        /// Insert PersonCategory
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> InsertPersonCategoryAsync(PersonCategory entity)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("INSERT INTO                                ");
                sql.Append("        PersonCategory (PersonId,          ");
                sql.Append("                        CategoryId,        ");
                sql.Append("                        OrderIndex,        ");
                sql.Append("                        CreatedBy,         ");
                sql.Append("                        UpdatedBy)         ");
                sql.Append("VALUES (@PersonId,                         ");
                sql.Append("        @CategoryId,                       ");
                sql.Append("        @OrderIndex,                       ");
                sql.Append("        @CreatedBy,                        ");
                sql.Append("        @UpdatedBy)                        ");
                var param = new
                {
                    PersonId = entity.PersonId,
                    CategoryId = entity.CategoryId,
                    OrderIndex = entity.OrderIndex,
                    CreatedBy = "anhnh",
                    UpdatedBy = "anhnh"
                };
                return await conn.ExecuteAsync(sql.ToString(), param);
            }
        }

        /// <summary>
        /// Check PersonCategory
        /// </summary>
        /// <param name="personCategory"></param>
        /// <returns></returns>
        public async Task<bool> CheckPersonCategoryAsync(PersonCategory personCategory)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("SELECT COUNT(*)                       ");
                sql.Append("FROM PersonCategory                   ");
                sql.Append("WHERE PersonId = @PersonId            ");
                sql.Append("      AND CategoryId = @CategoryId    ");
                sql.Append("      AND Status = 1                  ");
                var param = new
                {
                    PersonId = personCategory.PersonId,
                    CategoryId = personCategory.CategoryId
                };
                int count = await conn.ExecuteScalarAsync<int>(sql.ToString(), param);
                return count > 0;
            }
        }

        /// <summary>
        /// Delete PersonTechnology
        /// </summary>
        /// <param name="personTechnology"></param>
        /// <returns></returns>
        public async Task<int> DeletePersonTechnologyAsync(PersonTechnology personTechnology)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("UPDATE PersonTechnology                 ");
                sql.Append("SET Status        = 0,                 ");
                sql.Append("UpdatedBy         = @UpdatedBy,        ");
                sql.Append("UpdatedAt         = @UpdatedAt         ");
                sql.Append("WHERE PersonId    = @PersonId          ");
                var param = new
                {
                    UpdatedBy = personTechnology.UpdatedBy,
                    UpdatedAt = personTechnology.UpdatedAt,
                    PersonId = personTechnology.PersonId
                };
                var result = await conn.ExecuteAsync(sql.ToString(), param);
                return result;
            }
        }

        /// <summary>
        /// Check PersonTechnology
        /// </summary>
        /// <param name="personTechnology"></param>
        /// <returns></returns>
        public async Task<bool> CheckPersonTechnologyOnDeleteAsync(PersonTechnology personTechnology)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("SELECT COUNT(*)                                 ");
                sql.Append("FROM PersonTechnology                           ");
                sql.Append("WHERE Status = 0 AND PersonId = @PersonId       ");
                sql.Append("      AND TechnologyId = @TechnologyId          ");
                var param = new
                {
                    PersonId = personTechnology.PersonId,
                    TechnologyId = personTechnology.TechnologyId
                };
                var count = await conn.ExecuteScalarAsync<int>(sql.ToString(), param);
                return count > 0;
            }
        }

        /// <summary>
        /// Update PersonTechnology to Insert
        /// </summary>
        /// <param name="personTechnologies"></param>
        /// <returns></returns>
        public async Task<int> UpdatePersonTechnologyInsertAsync(List<PersonTechnology> personTechnologies)
        {
            using (var conn = OpenDBConnection())
            {
                var trans = conn.BeginTransaction();
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("UPDATE PersonTechnology                ");
                sql.Append("SET Status        = 1,                 ");
                sql.Append("UpdatedBy         = @UpdatedBy,        ");
                sql.Append("UpdatedAt         = @UpdatedAt         ");
                sql.Append("WHERE PersonId    = @PersonId          ");
                sql.Append("AND TechnologyId  = @TechnologyId      ");
                var result = await conn.ExecuteAsync(sql.ToString(), personTechnologies, transaction: trans);
                trans.Commit();
                return result;
            }
        }

        /// <summary>
        /// Check PersonCategory On Delete
        /// </summary>
        /// <param name="personCategory"></param>
        /// <returns></returns>
        public async Task<bool> CheckPersonCategoryOnDeleteAsync(PersonCategory personCategory)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("SELECT COUNT(*)                         ");
                sql.Append("FROM PersonCategory                     ");
                sql.Append("WHERE PersonId = @PersonId              ");
                sql.Append("      AND CategoryId = @CategoryId      ");
                sql.Append("      AND Status = 0                    ");
                var param = new
                {
                    PersonId = personCategory.PersonId,
                    CategoryId = personCategory.CategoryId
                };
                int count = await conn.ExecuteScalarAsync<int>(sql.ToString(), param);
                return count > 0;
            }
        }

        /// <summary>
        /// Update PersonCategory to Insert
        /// </summary>
        /// <param name="personCategory"></param>
        /// <returns></returns>
        public async Task<int> UpdatePersonCategoryInsertAsync(PersonCategory personCategory)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("UPDATE PersonCategory                ");
                sql.Append("SET Status      = 1,                 ");
                sql.Append("UpdatedBy       = @UpdatedBy,        ");
                sql.Append("UpdatedAt       = @UpdatedAt         ");
                sql.Append("WHERE PersonId  = @PersonId          ");
                sql.Append("AND CategoryId  = @CategoryId        ");
                var param = new
                {
                    UpdatedBy = personCategory.UpdatedBy,
                    UpdatedAt = personCategory.UpdatedAt,
                    PersonId = personCategory.PersonId,
                    CategoryId = personCategory.CategoryId,
                };
                return await conn.ExecuteAsync(sql.ToString(), param);
            }
        }

        public async Task<int> DeletePersonCategoryAsync(PersonCategory personCategory)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("UPDATE PersonCategory                ");
                sql.Append("SET Status      = 0,                 ");
                sql.Append("UpdatedBy       = @UpdatedBy,        ");
                sql.Append("UpdatedAt       = @UpdatedAt         ");
                sql.Append("WHERE PersonId  = @PersonId          ");
                sql.Append("AND CategoryId  = @CategoryId        ");
                var param = new
                {
                    UpdatedBy = personCategory.UpdatedBy,
                    UpdatedAt = personCategory.UpdatedAt,
                    PersonId = personCategory.PersonId,
                    CategoryId = personCategory.CategoryId,
                };
                return await conn.ExecuteAsync(sql.ToString(), param);
            }
        }

        /// <summary>
        /// Check number of PersonTechnology
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        public async Task<int> CheckNumberOfPersonTechnology(int personId)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("SELECT COUNT(*)");
                sql.Append("FROM PersonTechnology as PT");
                sql.Append("WHERE PT.PersonId = @PersonId");
                return await conn.ExecuteScalarAsync<int>(sql.ToString(), new { PersonId = personId });
            }
        }
        /// <summary>
        /// Delete PersonTechnology to Update
        /// </summary>
        /// <param name="personTechnologies"></param>
        /// <returns></returns>
        public async Task<int> DeletePersonTechnologyToUpdateAsync(int personId)
        {
            using (var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("DELETE FROM PersonTechnology          ");
                sql.Append("WHERE PersonId = @PersonId            ");
                return await conn.ExecuteAsync(sql.ToString(), new { PersonId = personId });
            }
        }

        /// <summary>
        /// Get Skill By Category
        /// </summary>
        /// <param name="personCategory"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Technology>> GetSkilByCategoryyAsync(PersonCategory personCategory)
        {
            using(var conn = OpenDBConnection())
            {
                StringBuilder sql = new StringBuilder();
                sql.Length = 0;
                sql.Append("SELECT TE.Id, TE.Name                                      ");
                sql.Append("FROM Technology AS TE                                      ");
                sql.Append("INNER JOIN PersonTechnology AS PT                          ");
                sql.Append("ON TE.Id = PT.TechnologyId                                 ");
                sql.Append("WHERE PT.PersonId = @PersonId                              ");
                sql.Append("AND TE.CategoryId = @CategoryId                            ");
                sql.Append("GROUP BY TE.Id, TE.Name                                    ");
                var param = new
                {
                    PersonId = personCategory.PersonId,
                    CategoryId = personCategory.CategoryId,
                };
                return await conn.QueryAsync<Technology>(sql.ToString(), param);
            }
        }
    }
}
