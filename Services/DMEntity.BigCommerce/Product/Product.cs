using System;
using System.Collections.Generic;
using System.Text;

namespace DMEntity.BigCommerce
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string ParentSKU { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public decimal Weight { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Height { get; set; }

        public decimal Price { get; set; }
        public decimal Cost_price { get; set; }
        public decimal Retail_price { get; set; }
        public decimal Sale_price { get; set; }

        public bool Is_free_shipping { get; set; }
        public decimal Fixed_cost_shipping_price { get; set; }

        public int Brand_id { get; set; }
        public ProductBrand Brand { get; set; }

        public bool Is_visible { get; set; }
        public bool Is_featured { get; set; }

        public string Warranty { get; set; }
        public string Bin_picking_number { get; set; }
        public string Upc { get; set; }
        public string Availability { get; set; }
        public string Availability_description { get; set; }
        public int Sort_order { get; set; }
        public string Condition { get; set; }
        public bool Is_condition_shown { get; set; }
        public int Order_quantity_minimum { get; set; }
        public int Order_quantity_maximum { get; set; }
        public bool Is_preorder_only { get; set; }
        public int Total_sold { get; set; }

        public string Search_keywords { get; set; }
        public string Page_title { get; set; }
        public string Meta_description { get; set; }

        public string Inventory_tracking { get; set; }
        public int Inventory_level { get; set; }
        public int Inventory_warning_level { get; set; }

        public IEnumerable<int> Categories { get; set; }

        public IEnumerable<ProductImage> Images { get; set; }

        public IEnumerable<Product> Variants { get; set; }
    }

    public class ProductImage
    {
        public int Id { get; set; }
        public int Product_id { get; set; }
        public string Description { get; set; }
        public string Image_file { get; set; }
        public string Url_standard { get; set; }
    }

    public class ProductBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
