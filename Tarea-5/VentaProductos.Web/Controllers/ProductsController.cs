using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using VentaProductos.Web.Models;

namespace VentaProductos.Web.Controllers
{
    [Route("[controller]/[action]")]
    public class ProductsController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProductsController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://localhost:7298/GetAll");
            if (!response.IsSuccessStatusCode) return View(new List<ProductViewModel>());
            var json = await response.Content.ReadAsStringAsync();
            List<ProductViewModel> products = JsonConvert.DeserializeObject<List<ProductViewModel>>(json);
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewmodel = new ProductViewModel
            {
                Name = "",
                Price = 0
            };
            return View(viewmodel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel product)
        {
            var json = JsonConvert.SerializeObject(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7298/Create", content);
            if (!response.IsSuccessStatusCode) return View(product);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:7298/Get{id}");
            if (!response.IsSuccessStatusCode) return NotFound();

            var json = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<ProductViewModel>(json);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProductViewModel product)
        {
            var json = JsonConvert.SerializeObject(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"https://localhost:7298/Update{id}", content);
            if (!response.IsSuccessStatusCode) return View(product);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:7298/Get{id}");
            if (!response.IsSuccessStatusCode) return NotFound();

            var json = await response.Content.ReadAsStringAsync();
            var product = JsonConvert.DeserializeObject<ProductViewModel>(json);
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7298/Delete{id}");

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }
    }
}