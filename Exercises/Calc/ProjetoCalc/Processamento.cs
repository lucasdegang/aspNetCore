using System;

namespace ProjetoCalc
{
    internal class Processamento
    {
        internal void Calculadora()
        {
            Validacoes consiste = new Validacoes();
            Aritmetica mat = new Aritmetica();
            Mensagens msg = new Mensagens();


            double x, y, resultado;
            int operacao;
            bool calculoValido = true;
            int keepUser = 1;

            do
            {
                Console.Clear();
                msg.OpcoesUser();
                operacao = Convert.ToInt32(Console.ReadLine());
                var opValidada = consiste.operacaoAritmetica(operacao);

                if (opValidada != ' ')
                {
                    Console.WriteLine("Digite o numero x: ");
                    x = Convert.ToDouble(Console.ReadLine());

                    if (opValidada != '^')
                    {
                        // controle quando for quadrado de um numero
                        Console.WriteLine("Digite o numero y: ");
                        y = Convert.ToDouble(Console.ReadLine());

                        if (opValidada == '/')
                        {
                            calculoValido = mat.VerificaDivisorZero(y);
                        }
                    }
                    else
                    {
                        y = x;
                    }

                    if (calculoValido)
                    {
                        resultado = mat.CalculaResultado(opValidada, x, y);
                        Console.WriteLine("O resultado da operacao: " + msg.GetOperacaoSelecionada(opValidada) + " foi: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Calculo com informacoes invalidas.");
                    }
                }

                Console.WriteLine("Deseja continuar? 0-Nao. 1-Sim");
                keepUser = Convert.ToInt32(Console.ReadLine());

            } while (keepUser != 0);
        }
    }
}