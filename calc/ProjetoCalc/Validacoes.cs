using System;

namespace ProjetoCalc
{
    internal class Validacoes
    {
        public char operacaoAritmetica(int operacao)
        {
            switch (operacao)
            {
                case 1:
                    Console.WriteLine("Selecionado Soma");
                    return '+';
                    ;
                case 2:
                    Console.WriteLine("Selecionado subtracao");
                    return '-';
                case 3:
                    Console.WriteLine("Selecionado divisão");
                    return '/';
                case 4:
                    Console.WriteLine("Selecionado Multiplicacao");
                    return '*';
                case 5:
                    Console.WriteLine("Selecionado Quadrado de um numero");
                    return '^';
                default:
                    Console.WriteLine("Operacao invalida!");
                    Console.WriteLine("Selecione operacoes entre 1 a 5.");
                    return ' ';
            }
        }
    }
}