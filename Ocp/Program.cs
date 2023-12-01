using Ocp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR)
            {
                Car vehicle = new Car("Azul", 2022, 2.0, 5, 4);

            }
            else
            {

                Motorcycle vehicle = new Motorcycle("Branco", 2023, 250);

            }

            Console.ReadLine();


        }
    }
}
