using DMEntity.Neto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMService.Neto.Service
{
    public interface INetoProductConverter
    {
        Product ConvertToProduct(DMEntity.BigCommerce.Product bcommProduct);
    }
}
