using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Console.WriteLine();
            Console.WriteLine("\n## app 02 ##");

            //Pasta local do projeto
            string caminhoDaPastaLocal = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine();
            Console.WriteLine($"\nCaminhoDaPastaLocal: {caminhoDaPastaLocal}");

            //Combinar o caminho da pasta local com o nome do arquivo
            string caminhoDoArquivo = System.IO.Path.Combine(caminhoDaPastaLocal, $"pessoas.txt");
            //Console.WriteLine();
            Console.WriteLine($"\nCaminho do arquivo: {caminhoDoArquivo}");

            //Ler o conteudo do arquivo
            string conteudoDoArquivo = System.IO.File.ReadAllText(caminhoDoArquivo);
            //Console.WriteLine();
            Console.WriteLine($"\nconteudoDoArquivo: {conteudoDoArquivo}");

            string[] nomes = conteudoDoArquivo.Split(';');
            //Console.WriteLine();
            Console.WriteLine("\nforeach");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            //Console.WriteLine();
            Console.WriteLine("\nfor");
            for (int i = 0; i < nomes.Length; i++)
            {
                string nome = nomes[i];
                Console.WriteLine(nome);
            }

            //Console.WriteLine();
            Console.WriteLine("\nwhile");
            int index = 0;
            while (index < nomes.Length)
            {
                string nome = nomes[index];
                Console.WriteLine(nome);
                index++;
            }


        }
    }
}
