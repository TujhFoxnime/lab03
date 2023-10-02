using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class CarsCatalog
    {
        private List<Car> cars = new List<Car>();

        public string this[int index]
        {
            get
            {
                return cars[index].Name + "-" + cars[index].Engine;
            }
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
    }
}
