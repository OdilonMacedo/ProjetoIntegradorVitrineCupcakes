using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc;
using VitrineCupcakesMVC.Models;

namespace VitrineCupcakesMVC.Controllers
{
    public class VitrineController : Controller
    {
        private readonly HttpClient _http;

        public VitrineController(IHttpClientFactory httpClientFactory)
        {
            _http = httpClientFactory.CreateClient();
            _http.BaseAddress = new Uri("https://localhost:7274/"); // URL da sua API
        }

        public IActionResult Home()
        {
            return View();
        }

        public async Task<IActionResult> Principal()
        {
            var cupcakes = await _http.GetFromJsonAsync<List<CupcakeViewModel>>("api/cupcakes");

            if (cupcakes == null)
                cupcakes = new List<CupcakeViewModel>();

            return View(cupcakes);
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(List<string> selecionados)
        {
            // Buscar cupcakes da API
            var cupcakes = await _http.GetFromJsonAsync<List<CupcakeViewModel>>("api/cupcakes");

            if (cupcakes == null)
                cupcakes = new List<CupcakeViewModel>();

            var itens = cupcakes.Where(c => selecionados.Contains(c.Nome)).ToList();

            var model = new CheckoutViewModel
            {
                Itens = itens,
                Total = itens.Sum(i => i.Preco)
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Finalizar(CheckoutViewModel model)
        {
            // Enviar pedido para a API
            var response = await _http.PostAsJsonAsync("api/vitrine", model);

            if (!response.IsSuccessStatusCode)
            {
                TempData["msg"] = "Erro ao finalizar pedido.";
                return RedirectToAction("Principal");
            }

            TempData["msg"] = "Pedido realizado com sucesso!";
            return RedirectToAction("Principal");
        }
    }
}
