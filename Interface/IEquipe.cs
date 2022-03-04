using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Interface
{
    public interface IEquipe
    {
        // Funciona como um contrato

        // Representa os métodos que são obrigatórios em uma classe.

        void Criar(Equipe novaequipe);

        List<Equipe> LerEquipes();



    }
}
