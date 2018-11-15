using System;
using System.Collections.Generic;
using System.Text;

namespace DMEntity.Neto
{
    public class Product
    {
        public string SKU { get; set; }
        public string ParentSKU { get; set; }
        public bool Virtual { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public int SortOrder1 { get; set; }
        public int SortOrder2 { get; set; }

        public decimal DefaultPrice { get; set; }
        public decimal CostPrice { get; set; }
        public decimal RRP { get; set; }

        public bool Active { get; set; }
        public bool Visible { get; set; }

        public string Description { get; set; }
        public string AvailabilityDescription { get; set; }
        public string SearchKeywords { get; set; }

        public string ImageURL { get; set; }
        public ProductImages Images { get; set; }

        public string UPC { get; set; }

        public decimal ShippingHeight { get; set; }
        public decimal ShippingLength { get; set; }
        public decimal ShippingWidth { get; set; }
        public decimal ShippingWeight { get; set; }

        public ProductCategories Categories { get; set; }

        public string SEOPageTitle { get; set; }
        public string SEOMetaDescription { get; set; }
    }

    public class ProductImages
    {
        public IEnumerable<ProductImage> Image { get; set; }
    }

    public class ProductImage
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Base64 { get; set; }
    }

    public class ProductCategories
    {
        public IEnumerable<ProductCategory> Category { get; set; }
    }
    public class ProductCategory
    {
        public int CategoryID { get; set; }
        public int Priority { get; set; }
    }
}
