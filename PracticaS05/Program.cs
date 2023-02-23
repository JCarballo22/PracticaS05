using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ventana ventana = new Ventana();

            //ventana.mostrar();


            Vehiculo carro = new Vehiculo();

            Vehiculo coche = new Vehiculo();

            Console.WriteLine(carro.getInfoVehiculo());
            

            Console.WriteLine("Las ruedas son: " + carro.getRuedas());

            Vehiculo moto = new Vehiculo(1.5,0.6,false);
            Console.WriteLine("Las caracteriscas de la son: " + moto.getInfoVehiculo());
            
        }
    }

    class Ventana
    {
        private int ancho, altura;
        private string color;

        public Ventana()
        {
            ancho = 600;
            altura = 720;
            color = "Rojo";
        }

        public void mostrar()
        {
            Console.WriteLine("La dimenciones de la ventana es: " + ancho + " x " + altura + " y su color es: " + color);
        }

        ~Ventana() { }

    }

    class Vehiculo
    {
        public Vehiculo()
        {
            ruedas = 4;
            largo = 2.30;
            ancho = 1;
        }

        public int getRuedas()
        {
            return ruedas;
        }

        public string getInfoVehiculo()
        {
            return "La información del vehículo: \n Ruedas: " + ruedas + " largo: " + largo + " ancho: " + ancho;
        }

        public Vehiculo(double largo, double ancho, bool climatizador)
        {
            this.ruedas = 2;
            this.largo = largo;
            this.ancho = ancho;
            this.climatizador = climatizador;
          
        }

        private int ruedas;
        private double largo, ancho;
        private bool climatizador;
        private string tapiceria;
    }
}
