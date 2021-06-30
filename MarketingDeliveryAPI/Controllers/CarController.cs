using MarketingDeliveryModels.APIModels;
using MarketingDeliveryModels.DataModels;
using MarketingDeliveryService.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDeliveryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService CarService;

        public CarController(ICarService carService)
        {
            this.CarService = carService;
        }

        // GET: api/<Car>
        [HttpGet]
        public Task<List<Car>> Get()
        {
            return CarService.GetAllCars();
        }

        // GET api/<Car>/8e3e9c08-88ac-425c-82c1-a12c306b9026
        [HttpGet("{id}")]
        public Task<Car> Get(Guid id)
        {
            return CarService.GetCarById(id);
        }

        // POST api/<Car>
        [HttpPost]
        public Task<Car> Post([FromBody] AddCar addCar)
        {
            return CarService.AddCar(addCar);
        }

        // PUT api/<Car>
        [HttpPut]
        public async Task<Car> Put([FromBody] EditCar editCar)
        {
            return await CarService.EditCar(editCar);
        }

        // DELETE api/Car/8e3e9c08-88ac-425c-82c1-a12c306b9026
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await CarService.DeleteCar(id);
            return Ok();
        }
    }
}
