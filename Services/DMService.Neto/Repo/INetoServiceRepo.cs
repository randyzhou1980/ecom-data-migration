using DMService.Neto.Service;

namespace DMService.Neto.Repo
{
    public interface INetoServiceRepo
    {
        INetoCustomerConverter CustomerConverter { get; }
        INetoCustomerService CustomerService { get; }

        INetoCategoryConverter CategoryConverter { get; }
        INetoCategoryService CategoryService { get; }

        INetoProductConverter ProductConverter { get; }
    }
}
