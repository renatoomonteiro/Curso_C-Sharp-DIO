using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_C_SHARP_DIO.Models  
{
    //Criando a nossa classe Calculadora
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"A soma de {x} + {y} é igual a: {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"A subtração de {x} - {y} é igual a: {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"A multiplicação de {x} * {y} é igual a: {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"A divisão de {x} / {y} é igual a: {x / y}");
        }

        public void Potencia(int x, int y)
        {   
            double pot = Math.Pow(x, y);
            Console.WriteLine($"A potência de {x} elevado a {y} é igual a: {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;    
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno do ângulo {angulo}° é igual a: {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;    
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O Coseno do ângulo {angulo}° é igual a: {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;    
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"O Tangente do ângulo {angulo}° é igual a: {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é igual a: {Math.Round(raiz, 4)}");
        }
    }
}