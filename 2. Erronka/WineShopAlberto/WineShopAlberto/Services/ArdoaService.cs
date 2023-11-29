using Newtonsoft.Json;
using WineShopAlberto.Models;

namespace WineShopAlberto.Services
{
    //Gehitu interfazea luzatzen duela : IArdoaService ipinita, bestela Progam.cs-k erroera ematen du.
    public class ArdoaService : IArdoaService
    {
        private Uri rutaTodos = new Uri("https://localhost:44371/Api/ardoa/");
        public async Task<IList<ArdoaUpeltegi>> GetMota(int id)
        {
            List<ArdoaUpeltegi> ardoaUpeltegiList = new List<ArdoaUpeltegi>();
            Uri rutaUpeltegiak = new Uri(rutaTodos, "Mota/" + id.ToString());
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(rutaUpeltegiak))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ardoaUpeltegiList = JsonConvert.DeserializeObject<List<ArdoaUpeltegi>>(apiResponse);
                }
            }
            return ardoaUpeltegiList;
        }
    }
}
