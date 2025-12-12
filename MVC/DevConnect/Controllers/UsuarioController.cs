using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevConnect.Models;
using DevConnect.Contexts;
using System.Threading.Tasks;

// CADASTRO DE ÚSUARIO
namespace DevConnect.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }

        //Cadastro.html
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.UsuarioNovoCadastrado = "";
            TempData["UsuarioNovoCadastrado"] = "";
            return View();
        }
       
       [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbUsuario novoUsuario = new TbUsuario()
            {
                NomeCompleto = form["NomeCompleto"].ToString(),
                NomeUsuario = form["NomeUsuario"].ToString(),
                Email = form["Email"].ToString(),
                Senha = form["Senha"].ToString()
            };

            if (form.Files.Count > 0)
            {
                //Se selecionou a imagem entra dentro do if
                IFormFile file = form.Files[0];
                string folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Imagens");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                //caminha da imagem que será salvo
                string path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                    
                }   

                //Passa o nome da imagem
                 novoUsuario.FotoPerfilUrl = file.FileName;
                   
            }
            else
            {
                //ponhe uma foto padrão
                novoUsuario.FotoPerfilUrl = "";
            }

            try
            {
                _context.TbUsuario.Add(novoUsuario);
               
                await _context.SaveChangesAsync();

                TempData["UsuarioNovoCadastrado"] = "Cadastrado";
                ViewBag.UsuarioNovoCadastrado = "";

                return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Nao Cadastrado";
                TempData["UsuarioNovoCadastrado"] = "";
                return View();
            }
            
                    
        }
        
        //Perfil do Usuario
        public IActionResult Perfil()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}