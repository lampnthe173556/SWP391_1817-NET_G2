using Swp391.Dtos;
using BE.Models;
using Swp391.Repository;

namespace Swp391.Service
{
    public class StoreDtosService
    {
        /// <summary>
        /// hàm trả về tất cả store
        /// </summary>
        StoreDtosRepo storeRepo = new StoreDtosRepo();

        // list store
        public List<StoreDtos> getAllStore()
        {
            return storeRepo.getAllStore();
        }

        // // create store service
        // public Store createStoreService(Store store)
        // {
        //     return storeRepo.createStore(store);
        // }
    }
}