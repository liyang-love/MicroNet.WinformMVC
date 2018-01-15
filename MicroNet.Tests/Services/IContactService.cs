using System.Collections.Generic;
using  MicroNet.Domain;

namespace  MicroNet.Services
{
    public interface IContactService
    {
        void AddContact(Contact contactToCreate);
        void UpdateContact(Contact contactToUpdate);
        void DeleteContact(long id);
        List<Contact> GetContacts();
    }
}
