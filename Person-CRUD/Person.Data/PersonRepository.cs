using Microsoft.EntityFrameworkCore;
using Person_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PersonRepository : IPersonRepository
    {
        private readonly CompanyContext _db;

        public PersonRepository(CompanyContext db)
        {
            _db = db;
        }

        public async Task<List<Person>> GetAll()
        {
            return await _db.Persons.ToListAsync();
        }
        public async Task<bool> CreatePerson(Person person) {
            _db.Persons.Add(person);
            _db.SaveChangesAsync();
            return true;
        }
        public async Task<Person> GetById(int id)
        {
            return await _db.Persons.FindAsync(id);
        }

        public async Task<bool> Delete(int id)
        {
            var data = await _db.Persons.FindAsync(id);
            _db.Persons.Remove(data);
            _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePerson(Person person)
        {
            var data = await _db.Persons.FindAsync(person.Id);
            data.Age = person.Age;
            data.FirstName = person.FirstName;
            data.LastName = person.LastName;
            _db.SaveChangesAsync();
            return true;
        }
    }
}
