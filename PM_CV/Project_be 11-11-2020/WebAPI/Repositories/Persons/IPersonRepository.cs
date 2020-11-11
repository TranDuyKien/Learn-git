using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Repositories.Interfaces;
using WebAPI.Models;

namespace WebAPI.Repositories.Persons
{
    public interface IPersonRepository: IRepositoryBase<PersonInfo>
    {
        public Task<int> GetMaxIdPerson();
    }
}
