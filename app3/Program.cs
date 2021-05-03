using System;
using System.IO;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string currentDirectory = Directory.GetCurrentDirectory();

            var app = new MyApp(currentDirectory);

            app.CarregarLista();
            app.ImprimirLista();

            Pessoa ricardo = app.BuscarPessoa("Ricardo");
            DateTime dataNascimento = DateTime.Parse(ricardo.DataNascimento);
            dataNascimento = dataNascimento.AddYears(-1);
            ricardo.DataNascimento = dataNascimento.ToString("dd/MM/yyyy");

            app.SalvarLista();
            app.ImprimirLista();

            Console.WriteLine("\n\n###############################################\n\n");

            Console.WriteLine("Digite o primeiro nome da pessoa para busca: ");
            string primeiroNome = Console.ReadLine();

            Pessoa pessoinha = app.BuscarPessoa(primeiroNome);
            if (pessoinha != null){
                Console.WriteLine("Pessoa encontrada!");
            }

            //Mudar o nome

            string resposta1;
            do {
                Console.Write("Deseja mudar o nome? (S/N) ");
                resposta1 = Console.ReadLine();
                if (resposta1 == "S"){
                    do {
                        //Console.WriteLine();
                        Console.Write("\nDigite o nome: ");
                        pessoinha.NomeCompleto = Console.ReadLine();
                    } while (String.IsNullOrWhiteSpace(pessoinha.NomeCompleto));
                }
            } while (resposta1 != "S" && resposta1 != "N");

            //Envelhecer
            Console.Write("Deseja envelhecer esta pessoa em um ano? (S/N) ");
            string resposta2 = Console.ReadLine();
            if (resposta2 == "S"){
                var data = DateTime.Parse(pessoinha.DataNascimento);
                data = data.AddYears(-1);
                pessoinha.DataNascimento = data.ToString("dd/MM/yyyy");
            }
            
            app.SalvarLista();
            app.ImprimirLista();

        }
    }
}
