using CorsaroCristian.MVCTP7.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CorsaroCristian.MVCTP7.CRUD.Controllers
{
    public class APIPublicaController : Controller
    {
        // GET: APIPublica
        public ActionResult Index()
        {
            TipoNormalView tipoNormal = GetNormalType().GetAwaiter().GetResult();
            return View(tipoNormal);
        }

        public async Task<TipoNormalView> GetNormalType()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = null;
                client.BaseAddress = new Uri("https://pokeapi.co");
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Hace la llamada a http://url-base-del-api/api/products/<id>
                response = await client.GetAsync("api/v2/type/1").ConfigureAwait(false);

                // Si el servicio responde correctamente
                if (response != null && response.IsSuccessStatusCode)
                {
                    // Lee el response y lo deserializa como un Product
                    return await response.Content.ReadAsAsync<TipoNormalView>();
                }
                // Sino devuelve null
                return await Task.FromResult<TipoNormalView>(null);
            }
        }
    }
}