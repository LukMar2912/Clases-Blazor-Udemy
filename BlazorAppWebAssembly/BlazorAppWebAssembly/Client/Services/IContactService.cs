using BlazorAppWebAssembly.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppWebAssembly.Client.Services
{
    public interface IContactService
    {
        Task SaveContact(Contact contact);
        Task DeleteContact(int id);
        Task<IEnumerable<Contact>> GetAll();
        Task<Contact> GetDetails(int id);
    }
}
