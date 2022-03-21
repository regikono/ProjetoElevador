using System;

namespace ProjetoElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto Elevador, do andar 1 ao 5

            bool abrir = true;

            Console.WriteLine("");

           

            //Andares de paradas
            do
            {
                Console.Write(@"
                Digite o andar desejado:
                1 - 1o. andar
                2 - 1o. andar
                3 - 1o. andar
                4 - 1o. andar
                5 - 1o. andar"
            );
                string andar_atual1 = Console.ReadLine();


                switch (andar_atual1)
                {
                    case "1": Console.WriteLine("Próxima parada, 1o. andar"); andar1(); break;
                    case "2": Console.WriteLine("Próxima parada, 2o. andar"); andar2(); break;
                    case "3": Console.WriteLine("Próxima parada, 3o. andar"); andar3(); break;
                    case "4": Console.WriteLine("Próxima parada, 4o. andar"); andar4(); break;
                    case "5": Console.WriteLine("Próxima parada, 5o. andar"); andar5(); break;
                    default: Console.WriteLine("Selecione um andar diferente do atual"); break;
                    case "X": abrir = false; break;
                }
               
            }
            // abre a porta se o usuário desistir de ir para outro andar ou para manter aberto aguardando outra pessoa
            while (abrir); 

        }

        public static void andar1() { Console.WriteLine("Você chegou ao 1o. andar"); }
        public static void andar2() { Console.WriteLine("Você chegou ao 2o. andar"); }
        public static void andar3() { Console.WriteLine("Você chegou ao 3o. andar"); }
        public static void andar4() { Console.WriteLine("Você chegou ao 4o. andar"); }
        public static void andar5() { Console.WriteLine("Você chegou ao 5o. andar"); }
    }
}
