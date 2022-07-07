using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Peliculas.Controllers
{
    public class PeliculaController : Controller
    {

        //Podemos inf¿gresar manualmente a estos URLs
        // GET: /Pelicula/
        public String Index()
        {
            return "Esto es una prueba";
        }

        // GET: /Pelicula/Abreme/ 

        public string Abreme()
        {
            return "es una accion y metodo";
        }
        // GET: /Pelicula/Welcome?name=Crystian&numtimes=5715
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 100)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        public string NameId(string name, int ID = 4545)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
