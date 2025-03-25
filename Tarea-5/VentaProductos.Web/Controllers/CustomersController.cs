using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using VentaProductos.Web.Models;

namespace VentaProductos.Web.Controllers
{
    [Route("[controller]/[action]")]
    public class CustomersController : Controller
    {
        private readonly HttpClient _httpClient;

        public CustomersController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://localhost:7298/api/Customers/GetAll");
            if (!response.IsSuccessStatusCode) return View(new List<CustomerViewModel>());
            var json = await response.Content.ReadAsStringAsync();
            List<CustomerViewModel> customers = JsonConvert.DeserializeObject<List<CustomerViewModel>>(json);
            return View(customers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var viewmodel = new CustomerViewModel
            {
                Name = "",
                Email = "",
            };
            return View(viewmodel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerViewModel customer)
        {
            var json = JsonConvert.SerializeObject(customer);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7298/api/Customers/Create", content);
            if (!response.IsSuccessStatusCode) return View(customer);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:7298/api/Customers/Get/{id}");
            if (!response.IsSuccessStatusCode) return NotFound();

            var json = await response.Content.ReadAsStringAsync();
            var customer = JsonConvert.DeserializeObject<CustomerViewModel>(json);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CustomerViewModel customer)
        {
            var json = JsonConvert.SerializeObject(customer);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"https://localhost:7298/api/Customers/Update/{id}", content);
            if (!response.IsSuccessStatusCode) return View(customer);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:7298/api/Customers/Get/{id}");
            if (!response.IsSuccessStatusCode) return NotFound();

            var json = await response.Content.ReadAsStringAsync();
            var customer = JsonConvert.DeserializeObject<CustomerViewModel>(json);
            return View(customer);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var response = await _httpClient.DeleteAsync($"https://localhost:7298/api/Customers/Delete/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }
    }
}
