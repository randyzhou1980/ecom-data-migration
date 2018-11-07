using DMService.Neto.Service;

namespace DMService.Neto.Repo
{
    public interface INetoServiceRepo
    {
        INetoCustomerConverter CustomerConverter { get; }
        INetoCustomerService CustomerService { get; }
    }
}
