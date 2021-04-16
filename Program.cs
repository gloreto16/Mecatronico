using System;

namespace Mecatronico
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = menuPrincipal();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        mostrarPecas();
                        break;
                    case "2":
                        //fazerPedido();
                        break;
                    case "3":
                        //verificarPedido();
                        break;
                    case "4":
                        //pagarCompra();
                        break;
                    case "5":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = menuPrincipal();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.ReadLine();
        }
        private static string menuPrincipal()
        {
            Console.WriteLine("================");
            Console.WriteLine("EMPRESAS ACNE LTDA.");
            Console.WriteLine("1 - Visualizar opções de peças");
            Console.WriteLine("2 - Fazer um pedido");
            Console.WriteLine("3 - Verificar um pedido");
            Console.WriteLine("4 - Pagar uma compra");
            Console.WriteLine("5 - Limpar a tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("================");
            Console.WriteLine();
            string retorno = Console.ReadLine().ToUpper();
            return retorno;
        }
        private static void mostrarPecas()
        {
            Console.WriteLine("---------------//--------------");
            Console.WriteLine("Todas peças vem em materiais como aço, ferro ou inox!");
            Console.WriteLine("Discos: R$15,00 - com serra, sem serra, com serra/furo central e sem serra/furo central");
            Console.WriteLine("Porca: R$0,50 - sextavado, sextavado tipo calota, borboleta ou quadrada");
            Console.WriteLine("Prego: R$3,50 - sextavado, quadrado ou redondo");
            Console.WriteLine("Soquete: R$2,50 - sextavado, quadrado ou redondo");
            Console.WriteLine("Parafuso: R$4,00 - sextavado, quadrado ou redondo");
            Console.WriteLine("Ponta de Chaves: R$1,00 - sextavado, quadrado ou redondo");
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.WriteLine("---------------//--------------");
            Console.ReadLine();
        }
    }
}
