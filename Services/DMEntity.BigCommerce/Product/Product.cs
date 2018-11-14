using System;
using System.Collections.Generic;
using System.Text;

namespace DMEntity.BigCommerce
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; }
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
        public decimal Calculated_price { get; set; }

        public bool Is_free_shipping { get; set; }
        public decimal Fixed_cost_shipping_price { get; set; }

        public int Brand_id { get; set; }
        public Brand ProductBrand { get; set; }

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

        public string Inventory_tracking { get; set; }
        public int Inventory_level { get; set; }
        public int Inventory_warning_level { get; set; }

        public IEnumerable<int> Categories { get; set; }
        public IEnumerable<Category> ProductCategories { get; set; }

        public IEnumerable<ProductImage> Images { get; set; }
    }

    public class ProductImage
    {
        public int Id { get; set; }
        public int Product_id { get; set; }
        public string Description { get; set; }
        public string Image_file { get; set; }
        public string Url_standard { get; set; }
    }

    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
