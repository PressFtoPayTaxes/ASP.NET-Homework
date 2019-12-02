using System.Threading.Tasks;

namespace Configurations
{
    public interface IPaymentService
    {
        public Task<string> MakePayment(Basket basket);
    }
}
