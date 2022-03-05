using EJOGOS.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOS.Models
{
    // Equipe herda de EquipeBase através de :
    public class Equipe : EquipeBase , IEquipe
    {
        public int IdEquipe { get; set; }
        public string nome { get; set; }
        public string Imagem { get; set; }


        //Variavel de dados.
        private const string caminho = "Database/equipe.csv";

        public Equipe() 
        {
            CriarPastaOuArquivo(caminho);
        }

        private string Preparar(Equipe e)
        {
            return $"{e.IdEquipe};{e.nome};{e.Imagem}";
        }

        public void Criar(Equipe novaequipe)
        {
            //Preparar a classe para retornar um texto

            string[] equipe_texto = { Preparar(novaequipe) };

            //Em um arquivo, adicionar novas linhas
            File.AppendAllLines(caminho, equipe_texto);

        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listadeEquipes = new List<Equipe>();

            //Pegar o texto e adicionar na classe

            string[] linhas = File.ReadAllLines(caminho);


            foreach (string item in linhas)
            {
                // 1;nome_do_time; caminho da imagem
                string[] linhaEquipe = item.Split(";");
                
                Equipe equipeAtual = new Equipe();  
                equipeAtual.IdEquipe = int.Parse(linhaEquipe[0]);   
                equipeAtual.nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listadeEquipes.Add(equipeAtual);    
            }



            return listadeEquipes;
        }
    }
}
