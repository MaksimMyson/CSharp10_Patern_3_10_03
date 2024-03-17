using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10_Patern_3_10_03
{
    interface ICar
    {
        string GetDescription();
        double GetCost();
    }

    class EconomyCar : ICar
    {
        public string GetDescription()
        {
            return "Економічний автомобіль";
        }

        public double GetCost()
        {
            return 20000;
        }
    }

    
    abstract class CarDecorator : ICar
    {
        protected ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual string GetDescription()
        {
            return car.GetDescription();
        }

        public virtual double GetCost()
        {
            return car.GetCost();
        }
    }

    
    class LuxuryCarDecorator : CarDecorator
    {
        public LuxuryCarDecorator(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return $"{car.GetDescription()}, Преміум пакет";
        }

        public override double GetCost()
        {
            return car.GetCost() + 10000;
        }
    }
}
