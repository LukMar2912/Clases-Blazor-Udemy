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

        public async Task DeleteContact(int id)
        {
            var sql = @"DELETE FROM contacts WHERE id=@id";

            var result = await _dbConnection.ExecuteAsync(sql, new { id = id });
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
            var sql = @"SELECT id, FirstName, LastName, Phone, Address FROM contacts";

            return await _dbConnection.QueryAsync<Contact>(sql, new{});
        }

        public async Task<Contact> GetDetails(int id)
        {
            var sql = @"SELECT id, FirstName, LastName, Phone, Address FROM contacts WHERE id = @id";


            return await _dbConnection.QueryFirstOrDefaultAsync<Contact>(sql, new
            {
                id = id
            });
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

                return result > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateContact(Contact contact)
        {
            try
            {
                var sql = @"UPDATE contacts SET " +
                    "FirstName = @FirstName, " +
                    "LastName = @LastName, " +
                    "Phone = @Phone, " +
                    "Address = @Address " +
                    "WHERE id = @id";
                var result = await _dbConnection.ExecuteAsync(sql, new
                {
                    contact.FirstName,
                    contact.LastName,
                    contact.Phone,
                    contact.Address,
                    contact.Id
                });

                return result > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
