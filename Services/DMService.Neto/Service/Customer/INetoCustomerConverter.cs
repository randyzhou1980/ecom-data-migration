using DMEntity.Neto;

namespace DMService.Neto.Service
{
    public interface INetoCustomerConverter
    {
        Customer ConvertToCustomer(DMEntity.BigCommerce.Customer bcommCustomer);
    }
}
