using BlazorAppWebAssembly.Shared;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbConnection _dbConnection;

        public ContactRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Task DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetDetails()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertContact(Contact contact)
        {
            try
            {
                var sql = @"INSERT INTO contacts (FirstName, LastName, Phone, Address) "+
                    "VALUES(@FirstName, @LastName, @Phone, @Address)";
                var result = await _dbConnection.ExecuteAsync(sql, new
                {
                    contact.FirstName,
                    contact.LastName,
                    contact.Phone,
                    contact.Address
                });
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public Task<bool> UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
