using MarketingDeliveryModels.APIModels;
using MarketingDeliveryModels.DataModels;
using MarketingDeliveryService.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDeliveryService.Instance
{
    public class CarService : ICarService
    {
        private readonly CarsContext _carsContext;

        public CarService(CarsContext carsContext)
        {
            _carsContext = carsContext;
        }

        public async Task<Car> AddCar(AddCar addCar)
        {
            Car carToAdd = new Car
            {
                CarId = Guid.NewGuid(),
                Make = addCar.Make,
                Model = addCar.Model,
                Colour = addCar.Colour
            };

            await _carsContext.Cars.AddAsync(carToAdd);
            await _carsContext.SaveChangesAsync();

            return carToAdd;
        }

        public async Task DeleteCar(Guid id)
        {
            Car car = await _carsContext.Cars.FirstOrDefaultAsync(c => c.CarId == id);
            if (car is not null)
            {
                _carsContext.Remove(car);
                await _carsContext.SaveChangesAsync();
            }
        }

        public async Task<Car> EditCar(EditCar editCar)
        {
            Car car = await _carsContext.Cars.FirstOrDefaultAsync(c => c.CarId == editCar.CarId);

            if (car is null)
            {
                return null;
            }

            if (car.Make != editCar.Make)
            {
                car.Make = editCar.Make;
            }

            if (car.Model != editCar.Model)
            {
                car.Model = editCar.Model;
            }

            if (car.Colour != editCar.Colour)
            {
                car.Colour = editCar.Colour;
            }

            await _carsContext.SaveChangesAsync();
            return car;
        }

        public Task<List<Car>> GetAllCars()
        {
            return _carsContext.Cars.ToListAsync();
        }

        public Task<Car> GetCarById(Guid id)
        {
            return _carsContext.Cars.FirstOrDefaultAsync(c => c.CarId == id);
        }
    }
}
