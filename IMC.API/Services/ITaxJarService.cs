using IMC.API.Models;
using IMC.API.Models.Response;
using System.Threading.Tasks;

namespace IMC.API.Services
{
    public interface ITaxJarService
    {
        Task<TaxRate> GetTaxRates(string location);
        Task<SalesTaxResponse> CalculateTax(SalesTax salesTax);
    }
}
