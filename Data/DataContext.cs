using System;
using Calculadora.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Calculadora.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Operaciones> Operaciones { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //METODOS
        public decimal Sumar(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public decimal Restar(decimal n1, decimal n2)
        {
            return n1 - n2;
        }

        public decimal Multiplicar(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

        public decimal Dividir(decimal n1, decimal n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir ningun numero entre 0.");
            }

            return n1 / n2;
        }

        public double RaizCuadrada(double n1)
        {
            return Math.Sqrt(n1);
        }

        public double Exponencial(double n1)
        {
            return Math.Pow(n1, 2);
        }
        
    }
}