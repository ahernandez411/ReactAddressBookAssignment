using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBookBusinessLayer.Models;

namespace AddressBookBusinessLayer
{
    public class AddressBookBusiness : IAddressBook
    {
        public Task<AddressBookModel> CreateAsync(AddressBookModel item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(AddressBookModel item)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddressBookModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AddressBookModel> UpdateAsync(AddressBookModel item)
        {
            throw new NotImplementedException();
        }
    }
}
