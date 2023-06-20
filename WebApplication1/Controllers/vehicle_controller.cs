using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class vehicle_controller : ControllerBase
    {
        private readonly I_vehicle_repository vehicle_repository;

        public vehicle_controller(I_vehicle_repository vehicle_repository)
        {
            this.vehicle_repository = vehicle_repository;
        }

        [HttpGet("/")]
        public IActionResult get_vehicles()
        {
            var cars = vehicle_repository.get_cars();
            var boats = vehicle_repository.get_boats();
            var buses = vehicle_repository.get_buses();

            var vehicles = new
            {
                cars = cars,
                boats = boats,
                buses = buses
            };
            return Ok(vehicles);
        }
        
        [HttpGet("/cars")]
        public IActionResult get_cars()
        {
            var cars = vehicle_repository.get_cars();
            return Ok(cars);
        }

        [HttpGet("/boats")]
        public IActionResult get_boats()
        {
            var boats = vehicle_repository.get_boats();
            return Ok(boats);
        }

        [HttpGet("/buses")]
        public IActionResult get_buses()
        {
            var buses = vehicle_repository.get_buses();
            return Ok(buses);
        }

        [HttpGet("/cars/{color}")]
        public IActionResult get_cars_by_color(string color)
        {
            var cars = vehicle_repository.get_cars_by_color(color);
            return Ok(cars);
        }

        [HttpGet("/boats/{color}")]
        public IActionResult get_boats_by_color(string color)
        {
            var boats = vehicle_repository.get_boats_by_color(color);
            return Ok(boats);
        }

        [HttpGet("/buses/{color}")]
        public IActionResult get_buses_by_color(string color)
        {
            var buses = vehicle_repository.get_buses_by_color(color);
            return Ok(buses);
        }

        [HttpPost("/cars/{id}/headlights")]
        public IActionResult toggle_car_headlights(int id)
        {
            vehicle_repository.toggle_car_headlights(id);
            return Ok();
        }

        [HttpDelete("/cars/{id}")]
        public IActionResult delete_car(int id)
        {
            vehicle_repository.delete_car(id);
            return Ok();
        }
    }
}