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

            Console.Write("\nDigite o primeiro nome da pessoa para busca: ");
            string primeiroNome = Console.ReadLine();

            Pessoa fulano = app.BuscarPessoa(primeiroNome);

            if (fulano is null){
                Console.WriteLine("\nPessoa não encontrada!\n");
            }
            else {
                string resposta1;
                do{
                    Console.Write("\nDeseja editar o nome? (S/N) ");
                    resposta1 = Console.ReadLine();
                    if (resposta1 == "S"){
                        do {
                            Console.Write("Digite o nome: ");
                            fulano.NomeCompleto = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(fulano.NomeCompleto));
                    }
                } while (resposta1 != "S" && resposta1 != "N");

                string resposta2;
                do{
                    Console.Write("\nDeseja editar a data de nascimento? (S/N) ");
                    resposta2 = Console.ReadLine();
                    if (resposta2 == "S"){
                        do {
                            Console.Write("Digite a data no formato dd/MM/yyyy: ");
                            fulano.DataNascimento = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(fulano.DataNascimento));
                    }
                } while (resposta2 != "S" && resposta2 != "N");

                string resposta3;
                do{
                    Console.Write("\nDeseja editar o email? (S/N) ");
                    resposta3 = Console.ReadLine();
                    if (resposta3 == "S"){
                        do {
                            Console.Write("Digite o email: ");
                            fulano.Email = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(fulano.Email));  
                    }
                } while (resposta3 != "S" && resposta3 != "N");

                string resposta4;
                do{
                    Console.Write("\nDeseja editar o telefone? (S/N) ");
                    resposta4 = Console.ReadLine();
                    if (resposta4 == "S"){
                        do {
                            Console.Write("Digite o telefone: ");
                            fulano.Telefone = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(fulano.Email));  
                    }
                } while (resposta4 != "S" && resposta4 != "N");

                app.SalvarLista();
                app.ImprimirLista();
            }
        }
    }
}
