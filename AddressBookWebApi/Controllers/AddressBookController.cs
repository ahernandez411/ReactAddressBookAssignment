using AddressBookBusinessLayer;
using AddressBookBusinessLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace AddressBookWebApi.Controllers
{
    [RoutePrefix("api/AddressBook")]
    public class AddressBookController : ApiController, IAddressBook
    {
        private readonly AddressBookBusiness _businessLayer;

        public AddressBookController()
        {
            _businessLayer = new AddressBookBusiness();
        }

        [HttpPost]
        [Route("create")]
        public async Task<AddressBookModel> CreateAsync(AddressBookModel item)
        {
            var result = await _businessLayer.CreateAsync(item);
            return result;
        }

        [HttpPost]
        [Route("delete")]
        public async Task<bool> DeleteAsync(AddressBookModel item)
        {
            var result = await _businessLayer.DeleteAsync(item);
            return result;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<AddressBookModel>> GetAllAsync()
        {
            var results = await _businessLayer.GetAllAsync();
            return results;
        }

        [HttpPost]
        [Route("update")]
        public async Task<AddressBookModel> UpdateAsync(AddressBookModel item)
        {
            var result = await _businessLayer.UpdateAsync(item);
            return result;
        }
    }
}
