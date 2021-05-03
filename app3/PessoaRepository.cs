using System;
using System.IO;

namespace app3
{
    public class PessoaRepository
    {
        private string _path;

        public PessoaRepository(string directory){
            _path = Path.Combine(directory, $"pessoas.json");
        }
        private string ReadText(){
            return File.ReadAllText(_path);
        }
        private void SaveText(string arrayJson){
            File.WriteAllText(_path, arrayJson);
        }

        //Retorna tudo
        public Pessoa[] Read(){
            string arrayJson = ReadText();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Pessoa[]>(arrayJson);
        }
        public void Save(Pessoa[] pessoas){
            string arrayJson = Newtonsoft.Json.JsonConvert.SerializeObject(pessoas);
            SaveText(arrayJson);
        }

    }
}