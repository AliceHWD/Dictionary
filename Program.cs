using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Tupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dicionário dados = new Dicionário();

            Console.WriteLine("1. Biologia.\n2. História.");
            string materia = Console.ReadLine();

            switch (materia)
            {
                case "1":
                    dados.biologia();
                    Console.WriteLine("1. Adicionar\n2.Excluir");
                    dados.acoes(Console.ReadLine());
                    break;
            }

            

            //string opcao = Console.ReadLine();

            //switch (opcao)
            //{
            //    //case "1":

            //}


            Console.ReadKey();
        }

        public class Dicionário
        {
            public Dictionary<string, string> valores()
            {
                Dictionary<string, string> dicBiologia = new Dictionary<string, string>();
                dicBiologia.Add("Comida", "Comer é bom");
                dicBiologia.Add("Corpo", "Correr é bom");
                dicBiologia.Add("Célula", "Meiose é bom");
                return dicBiologia;
            }

            public void biologia()
            {
                foreach (var item in valores())
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

            public void acoes(string opcao)
            {
                switch (opcao)
                {

                    case "1":
                        Console.WriteLine("Adicione chave e a explicação");
                        valores().Add(Console.ReadLine(), Console.ReadLine());
                        break;

                    case "2":
                        Console.WriteLine("Escolha a chave do valor que vai remover");
                        valores().Remove(Console.ReadLine());
                        break;
                }


            }
        }
    }
}
