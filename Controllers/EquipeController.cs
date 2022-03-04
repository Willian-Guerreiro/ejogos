using EJOGOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {

        //IActionResult é apropriado para quando temos diversos tipos possíveis

        //ActionResult representa varios codigos status de HTTP (200, 404, 505)

        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //ViewBag armazena informações do backend

            //Carrega as informações do controller para a view
            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();
        }


        public IActionResult Cadastrar(IFormCollection formulario)
        {

            // Criar um objeto equipe a partir do frontend
            Equipe nova_equipe = new Equipe();
            nova_equipe.IdEquipe = int.Parse(formulario["IdEquipe"]);
            nova_equipe.nome = formulario["Nome"];
            nova_equipe.Imagem = formulario["Imagem"];

            //chamar o método para cadastrar uma nova equipe
            equipeModel.Criar(nova_equipe);


            //Consultando as equipes cadastradas e atualizando a ViewBag
            ViewBag.Equipe = equipeModel.LerEquipes();

            //vamos redirecionar o navegador para página de equipe
            return LocalRedirect("~/Equipe");

        }



    }
}
