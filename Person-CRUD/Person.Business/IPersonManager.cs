using Person_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public interface IPersonManager
    {
        public Task<bool> CreatePerson(Person person);
        public Task<List<Person>> GetAll();
        public Task<Person> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> UpdatePerson(Person person);
    }
}
