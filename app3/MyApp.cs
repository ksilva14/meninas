using System;
using System.Linq;

namespace app3
{
    public class MyApp
    {
        private Pessoa[] _pessoas;
        private PessoaRepository _repository;

        public MyApp(string directory){
            _repository = new PessoaRepository(directory);
        }
        public void CarregarLista(){
            //Console.WriteLine();
            Console.WriteLine("\n## Carregar Lista ##");
            _pessoas = _repository.Read();
        }
        public void SalvarLista(){
            //Console.WriteLine();
            Console.WriteLine("\n## Salvar Lista ##");
            _repository.Save(_pessoas);
        }
        public void ImprimirLista(){
            //Console.WriteLine();
            Console.WriteLine("\n## Lista de Pessoas ##");
            foreach (var pessoa in _pessoas){
                Console.WriteLine($"\n----------------\nNome:{pessoa.NomeCompleto};\nDataNascimento:{pessoa.DataNascimento};\nEmail:{pessoa.Email};\nTelefone:{pessoa.Telefone}");
            }
        }
        public Pessoa BuscarPessoa(string nome){
            //Console.WriteLine();
            Console.WriteLine("\n## Buscar Pessoa ##");
            foreach (var pessoa in _pessoas){
                if (pessoa.NomeCompleto.StartsWith(nome)){
                    return pessoa;
                }
            }
            return null;
        }
    }
}