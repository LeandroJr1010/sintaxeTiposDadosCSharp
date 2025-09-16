using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeTiposDadosC.commom.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Soma
        /// </summary>
        /// <param name="x">Número 1</param>
        /// <param name="y">Número 2</param>
        /// <returns>Retorna soma de x + y</returns>
        public int Somar(int x, int y) // public int tem retorno
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
            return x + y;
        }
        public void Potencia(int x, int y) // void não tem return
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno(double angulo) // Seno, Coseno, Tangente
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}"); // Arredonda para 4 digitos
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}