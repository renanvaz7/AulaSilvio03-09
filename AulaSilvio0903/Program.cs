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
        struct Pessoa
        {
            
        }
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
                        InserirValores(myAll);
                        break;
                    case 2:
                        ListarValores(myAll);
                        break;
                    case 3:
                        RemoverValor(myAll, myAll);
                        break;
                    case 4:
                        BuscarValor(myAll);
                        break;
                }
                Console.ReadLine();
            }
        }
        public static int menu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-                                           -");
            Console.WriteLine("-    Inserir                             <1>-");
            Console.WriteLine("-    Listar                              <2>-");
            Console.WriteLine("-    Excluir                             <3>-");
            Console.WriteLine("-    Buscar                              <4>-");
            Console.WriteLine("-    Sair                                <0>-");
            Console.WriteLine("-                                           -");
            Console.WriteLine("---------------------------------------------");            
            return (int.Parse(Console.ReadLine()));
        }
        public static void InserirValores(ArrayList myList)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-                                           -");
            Console.WriteLine("-             ENTRADA DE DADOS              -");
            Console.WriteLine("-                                           -");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Digite um nome:");
            myList.Add(Console.ReadLine());
        }
        public static void ListarValores(ArrayList myAll)
        {
            foreach (object obj in myAll)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine();
        }
        public static void RemoverValor(IEnumerable myList, ArrayList Lista)
        {
            Console.Clear();
            int flag = 0;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-                                           -");
            Console.WriteLine("-             REMOVENDO DADOS               -");
            Console.WriteLine("-                                           -");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Informe o nome a ser removido");
            string nomeBusca = Console.ReadLine();

            foreach (object obj in myList)
            {
                if ((string)obj == nomeBusca)
                    flag = 1;
            }
            if (flag == 1) 
            { 
                Lista.Remove(nomeBusca);
                Console.WriteLine("********** Nome excluído da lista **********");              
            }
            else
            {
                Console.WriteLine("********** Nome não localizado na lista **********");
            }
        }
        public static void BuscarValor( IEnumerable myList)
        {
            Console.Clear();
            int flag = 0;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("-                                           -");
            Console.WriteLine("-           LOCALIZANDO DADOS               -");
            Console.WriteLine("-                                           -");
            Console.WriteLine("---------------------------------------------");

            if (flag == 1)
            {
                Console.WriteLine("********** Nome localizado na lista **********");
            }
            else
            {
                Console.WriteLine("********** Nome não localizado na lista **********");
            }

        }        
    }
}
