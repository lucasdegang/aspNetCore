using System;

namespace ProjetoCalc
{
    internal class Mensagens
    {
        char OpValidada;
        public void OpcoesUser()
        {
            Console.WriteLine("Digite a operacao:");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtracao");
            Console.WriteLine("3-Divisao");
            Console.WriteLine("4-Multiplicacao");
            Console.WriteLine("5-Quadrado de um numero");
        }

        internal string GetOperacaoSelecionada(char opValidada)
        {
            OpValidada = opValidada;

            switch (OpValidada)
            {
                case '+':
                    return "soma";
                case '-':
                    return "subtracao";
                case '/':
                    return "divisao";
                case '*':
                    return "multiplicacao";
                case '^':
                    return "quadrado de um numero";
                default:
                    return "nenhuma operacao selecionada";
            }
        }
    }
}