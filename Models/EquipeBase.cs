using System.IO;

namespace EJOGOS.Models
{
    public class EquipeBase
    {

        public void CriarPastaOuArquivo(string caminho)
        {
            //nomedapasta/nomedoarquivo.csv


            //analisar se a pasta existe, se não existir, cria.

            string pasta = caminho.Split('/')[0];

            //string arquivo = caminho.Split('/')[1];   

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                File.Create(caminho).Close();
            }

            //analisar se o arquivo existe, se não existir, cria.
        }

    }
}
