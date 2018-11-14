using DMService.BigCommerce.Service;

namespace DMService.BigCommerce.Repo
{
    public interface IBCommServiceRepo
    {
        IBCommCustomerService CustomerService { get; }
        IBCommCategoryService CategoryService { get; }
        IBCommProductService ProductService { get; }
    }
}
