using Person_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IPersonRepository 
    {
        public Task<List<Person>> GetAll();
        public Task<bool> CreatePerson(Person person);
        public Task<Person> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> UpdatePerson(Person person);
    }
}
