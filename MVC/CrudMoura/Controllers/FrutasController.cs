using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;


        public static List<Fruta> listaDeFrutas = new List<Fruta>
        {
            new Fruta{ Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
            new Fruta{ Id = 2, Nome = "Abacate", Preco = 5.90f, Quantidade = 12, Categoria = "Tropical"},
            new Fruta{ Id = 3, Nome = "Limão", Preco = 2.95f, Quantidade = 100, Categoria = "Cítrica"},
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult ListarFrutas()
        {
             ViewBag.Frutas = listaDeFrutas;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        //salvar a fruta na lista de frutas
        //Em seguida, redireciona para a lista/tela de ListarFrutas
        [HttpPost]
        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {
            //criar um id novo
            frutaCadastrada.Id= listaDeFrutas.Max(f => f.Id) + 1;
            //salvar os dados da frutas na lista de frutas
            listaDeFrutas.Add(frutaCadastrada);
            //voltar para a tela de listagem de fruta
            return RedirectToAction(nameof (ListarFrutas));
        }
        
        
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}