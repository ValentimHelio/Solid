using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ocp
{
    class Vehicle
    {
        private string color;
        private int yaer;
        private double engine;
        private int seats;
        private int doors;

        public Vehicle(string color, int yaer, double engine, int seats, int doors)
        { 
            this.color = color;
            this.yaer = yaer;   
            this.engine = engine;   
            this.seats = seats;
            this.doors = doors;
        }

        public void Car()
        {
            Console.WriteLine($"Criando um Carro {color}, {yaer}, {engine}, {doors} portas e {seats} assentos.");
        }

        public void Motorcycle()
        {
            Console.WriteLine($"Criando uma moto {color}, {yaer}, {engine} cilindradas.");
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando o motor");
        }
    }
}
