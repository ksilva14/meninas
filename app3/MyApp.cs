using System;
using System.Linq;

namespace app3
{
    public class MyApp
    {
        private Pessoa[] pessoas;
        private PessoaRepository _repository;

        public MyApp(string directory){
            _repository = new PessoaRepository(directory);
        }
        public void CarregarLista(){
            //Console.WriteLine();
            
        }
    }
}