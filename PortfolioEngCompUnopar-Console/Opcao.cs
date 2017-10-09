using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortfolioEngCompUnopar_Console
{
    class Opcao
    {
        string opcao;

        public void MostrarOpcao()
        {
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("\n\n  1  - PARA CALCULAR A POTÊNCIA ELÉTRICA");
            Console.WriteLine("\n  2  - PARA CALCULAR A CORRENTE ELÉTRICA");
            Console.WriteLine("\n  3  - PARA CALCULAR A TENSÃO ELÉTRICA");
            Console.WriteLine("\n  4  - PARA CALCULAR A RESISTÊNCIA ELÉTRICA");
            Console.WriteLine("\n  0  - ENTRAR COM OUTRO USUÁRIO");
            Console.WriteLine("\n  S  - PARA SAIR");
            Console.Write("\nOpção selecionada: ");
            opcao = Console.ReadLine();
            switch (opcao)
            {
                case ("1"):
                    Console.Clear();
                    Potencia pot = new Potencia();
                    pot.CalcularPotencia();
                    break;

                case ("2"):
                    Console.Clear();
                    Corrente cor = new Corrente();
                    cor.CalcularCorrente();
                    break;

                case ("3"):
                    Console.Clear();
                    Tensao ten = new Tensao();
                    ten.CalcularTensao();
                    break;

                case ("4"):
                    Console.Clear();
                    Resistencia res = new Resistencia();
                    res.CalcularResistencia();
                    break;

                case ("0"):
                    Login lgn = new Login();
                    lgn.EfetuarLogin();
                    break;

                case ("S"):
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\n\nOpção Inválida.");
                    Console.WriteLine("\n\nPressione qualquer tecla para tentar novamente.");
                    Console.ReadLine();
                    Console.Clear();
                    MostrarOpcao();
                    break;
            }
        }
    }
}