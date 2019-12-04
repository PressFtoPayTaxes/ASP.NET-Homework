using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Configurations
{
    public class PayPalService : IPaymentService
    {
        private readonly IConfiguration configuration;

        public PayPalService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<string> MakePayment(Basket basket)
        {
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.sandbox.paypal.com/v1/payments/payment"))
            {
                request.Headers.Add("Content-Type", "application/json");
                request.Headers.Add("Authorization", configuration.GetSection("PayPalCredentials").GetValue(typeof(string), "AccessToken") as string);
                string jsonContent = "{ \"intent\": \"sale\", " +
                                        "\"payer\":{" +
                                            "\"payment_method\": \"paypal\"}," +
                                        "\"transactions\": [{" +
                                            "\"amount\":{" +
                                                "\"total\"" + basket.Bill +
                                                "\"currency\": \"USD\"" +
                                            "}" +
                                         "}]" +
                                     "}";

                request.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await client.SendAsync(request);

                var content = await response.Content.ReadAsStringAsync();

                var id = content.Split(',')[0];
                var symbolsToId = 10;
                id = id.Substring(symbolsToId);
                id = id.TrimEnd('\"');
                return id;
            }
        }
    }
}
