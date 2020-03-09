using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AulaSilvio0903
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcoes;
            ArrayList myAll = new ArrayList();

            while (true)
            {
                opcoes = menu();
                switch (opcoes)
                {
                    case 1:
                        Console.WriteLine("Menu Cadastro");
                        break;
                    case 2:
                        Console.WriteLine("Menu Listar");
                        break;
                    case 3:
                        Console.WriteLine("Menu Excluir");
                        break;
                }
                Console.ReadLine();
            }
        }
        public static int menu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("----------------<1>Cadastro------------------");
            Console.WriteLine("----------------<2>Listar--------------------");
            Console.WriteLine("----------------<3>Excluir-------------------");
            Console.WriteLine("----------------<0>Sair----------------------");
            Console.WriteLine("---------------------------------------------");
            return (int.Parse(Console.ReadLine()));
        }
        public static void ListaValores(myAll)
        {
            foreach (object obj in myAll)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine();
        }
        public static void ReceberValor ()
        {
            Console.WriteLine("Digite um nome");

        }
    }
}
