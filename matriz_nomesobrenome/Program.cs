using System;

namespace matriz_nomesobrenome
{
    class Program
    {
        static void Main(string[] args)
        {
            //minha matriz aqui possui 3 linhas e 2 colunas
            int[,] matriz = new int[3, 2];
            int qtdLinhas = 2, qtdColunas = 2;
            string[,] m = new string[2, 2];

            m[0, 0] = "Mizael";
            m[0, 1] = "Sousa";

            m[1, 0] = "Luis";
            m[1, 1] = "Inacio";

            string conteudo = "";

            for (int i = 0; i < qtdLinhas; i++)
            {
                for (int j = 0; j < qtdColunas; j++)
                {
                    if (j == 0) Console.WriteLine("Informe o nome: ");
                    if (j == 1) Console.WriteLine("Informe o sobrenome: ");

                    m[i, j] = Console.ReadLine();
                    conteudo += m[i, j] + " ";
                }
                conteudo += "\n";
            }
            Console.WriteLine(conteudo);
            Console.ReadKey();
        }
    }
}