using AddressBookBusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookBusinessLayer
{
    public interface IAddressBook
    {
        Task<AddressBookModel> CreateAsync(AddressBookModel item);
        Task<bool> DeleteAsync(AddressBookModel item);
        Task<List<AddressBookModel>> GetAllAsync();
        Task<AddressBookModel> UpdateAsync(AddressBookModel item);
    }
}
