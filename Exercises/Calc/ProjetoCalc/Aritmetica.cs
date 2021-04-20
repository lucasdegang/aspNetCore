using System;

namespace ProjetoCalc
{
    public class Aritmetica
    {
        public char OpValidada;
        public double resultado, X, Y;

        public double CalculaResultado(char opValidada, double x, double y)
        {
            OpValidada = opValidada;
            X = x;
            Y = y;

            switch (OpValidada)
            {
                case '+':
                    resultado = X + Y;
                    break;
                case '-':
                    resultado = X - Y;
                    break;
                case '/':
                    resultado = X / Y;
                    break;
                case '*':
                    resultado = X * Y;
                    break;
                case '^':
                    resultado = X * Y; 
                    break;
            }

            return resultado;
        }

        public bool VerificaDivisorZero(double y)
        {
            Y = y;

            if (Y == 0)
            {
                Console.WriteLine("Divisor nao pode ser zero.");
                return false; // calculo nao valido
            }
            else {
                return true; // calculo valido
            }
        }
    }
}