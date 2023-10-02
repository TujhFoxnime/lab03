using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab03
{
    public class Car : IEquatable<Car>
    {
        public string Name { get; set; }
        public string Engine { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string name, string engine, int max_speed)
        {
            Name = name;
            Engine = engine;
            MaxSpeed = max_speed;
        }
        public override string ToString()
        {
            return Name;
        }
        public bool Equals(Car other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name) && this.Engine.Equals(other.Engine));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Car carObj = obj as Car;
            if (carObj == null) return false;
            else return Equals(carObj);
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Engine.GetHashCode();
        }
    }
}
