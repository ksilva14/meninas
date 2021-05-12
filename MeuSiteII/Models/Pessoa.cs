using System;

namespace MeuSiteII.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public int Cpf { get; set; }
        public Sexo Sexo { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
    }
}