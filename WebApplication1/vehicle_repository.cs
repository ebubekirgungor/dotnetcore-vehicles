namespace WebApplication1
{
    public interface I_vehicle_repository
    {
        IEnumerable<car> get_cars();
        IEnumerable<boat> get_boats();
        IEnumerable<bus> get_buses();
        IEnumerable<car> get_cars_by_color(string color);
        IEnumerable<boat> get_boats_by_color(string color);
        IEnumerable<bus> get_buses_by_color(string color);
        void toggle_car_headlights(int car_id);
        void delete_car(int car_id);
    }
    public class vehicle_repository : I_vehicle_repository
    {
        private readonly List<car> cars;
        private readonly List<boat> boats;
        private readonly List<bus> buses;

        public vehicle_repository()
        {
            cars = new List<car>
            {
                new car { id = 0, color = color.red, wheels = 4, headlights = true },
                new car { id = 1, color = color.blue, wheels = 4, headlights = false },
                new car { id = 2, color = color.black, wheels = 4, headlights = true },
                new car { id = 3, color = color.white, wheels = 4, headlights = false },
            };
            boats = new List<boat>
            {
                new boat { id = 0, color = color.red },
                new boat { id = 1, color = color.blue },
                new boat { id = 2, color = color.black },
                new boat { id = 3, color = color.white },
            };
            buses = new List<bus>
            {
                new bus { id = 0, color = color.red },
                new bus { id = 1, color = color.blue },
                new bus { id = 2, color = color.black },
                new bus { id = 3, color = color.white },
            };
        }
        public IEnumerable<car> get_cars()
        {
            return cars;
        }

        public IEnumerable<boat> get_boats()
        {
            return boats;
        }

        public IEnumerable<bus> get_buses()
        {
            return buses;
        }

        public IEnumerable<car> get_cars_by_color(string color)
        {
            return cars.Where(car => car.color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<boat> get_boats_by_color(string color)
        {
            return boats.Where(boat => boat.color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<bus> get_buses_by_color(string color)
        {
            return buses.Where(bus => bus.color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }

        public void toggle_car_headlights(int car_id)
        {
            var car = cars.FirstOrDefault(c => c.id == car_id);
            if (car != null)
            {
                car.headlights = !car.headlights;
            }
        }

        public void delete_car(int car_id)
        {
            var car = cars.FirstOrDefault(c => c.id == car_id);
            if (car != null)
            {
                cars.Remove(car);
            }
        }
    }
}
