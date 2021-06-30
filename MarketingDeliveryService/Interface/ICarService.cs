using MarketingDeliveryModels.APIModels;
using MarketingDeliveryModels.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDeliveryService.Interface
{
    public interface ICarService
    {
        Task<List<Car>> GetAllCars();

        Task<Car> GetCarById(Guid id);

        Task<Car> AddCar(AddCar addCar);

        Task<Car> EditCar(EditCar editCar);

        Task DeleteCar(Guid id);
    }
}
