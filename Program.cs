using System;

namespace Empresa
{
    
    public interface Empleado
    {
        double calcularBonificacion();
        void mostrarDetalles();
    }

        public abstract class EmpleadoBase : Empleado
    {
        protected string nombre;
        protected double salarioBase;

         public EmpleadoBase(string nombre, double salarioBase)
        {
            this.nombre = nombre;
            this.salarioBase = salarioBase;
        }

        public abstract double calcularBonificacion();

        public abstract void mostrarDetalles();
    }

    public class Ingeniero : EmpleadoBase
    {
        private string especialidad;

        public Ingeniero(string nombre, double salarioBase, string especialidad)
            : base(nombre, salarioBase)
        {
            this.especialidad = especialidad;
        }

        public override double calcularBonificacion()
        {
            // Ejemplo de bonificación basado en el salario base
            return salarioBase * 0.1;
        }

        public override void mostrarDetalles()
        {
            Console.WriteLine($"Ingeniero: {nombre}\nEspecialidad: {especialidad}\nSalario Base: {salarioBase}\nBonificación: {calcularBonificacion()}\n");
        }
    }

    public class Gerente : EmpleadoBase
    {
        private string departamento;
        public Gerente(string nombre, double salarioBase, string departamento)
            : base(nombre, salarioBase)
        {
            this.departamento = departamento;
        }

        public override double calcularBonificacion()
        {
            return salarioBase * 0.2;
        }
        public override void mostrarDetalles()
        {
            Console.WriteLine($"Gerente: {nombre}\nDepartamento: {departamento}\nSalario Base: {salarioBase}\nBonificación: {calcularBonificacion()}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Empleado ingeniero = new Ingeniero("Juan Pérez", 5000, "Software");
            Empleado gerente = new Gerente("Ana García", 7000, "Ventas");

           
            ingeniero.mostrarDetalles();
            gerente.mostrarDetalles();

            
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadLine();
        }
    }
}

