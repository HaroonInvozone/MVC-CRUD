using Data;
using Person_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _iPersonRepository;

        public PersonManager(IPersonRepository personRepository) {
            _iPersonRepository = personRepository;
        }

        public async Task<List<Person>> GetAll() {
            return await _iPersonRepository.GetAll();
        }
        public async Task<bool> CreatePerson(Person person) { 
              return await _iPersonRepository.CreatePerson(person);
        } 
        public async Task<Person> GetById(int id) {
            return await _iPersonRepository.GetById(id);
        }

        public async Task<bool> UpdatePerson(Person person) {
            return await _iPersonRepository.UpdatePerson(person);
        }

        public async Task<bool> Delete(int id) {
            return await _iPersonRepository.Delete(id);
        }
    }
}
