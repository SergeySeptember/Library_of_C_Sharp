using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Library_Console
{
    public class Categories
    {
        [Key]
        public short category_id { get; set; }
        public string? category_name { get; set; }
        public string? description { get; set; }
        public byte[] picture { get; set; }
    }

    public class Customers
    {
        [Key]
        public string customer_id { get; set; }
        public string? company_name { get; set; }
        public string? contact_name { get; set; }
        public string? contact_title { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? region { get; set; }
        public string? postal_code { get; set; }
        public string? country { get; set; }
        public string? phone { get; set; }
        public string? fax { get; set; }
    }

    public class Employees
    {
        [Key]
        public short employee_id { get; set; }
        public string? last_name { get; set; }
        public string? first_name { get; set; }
        public string? title { get; set; }
        public string? title_of_courtesy { get; set; }
        public DateTime? birth_date { get; set; }
        public DateTime? hire_date { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? region { get; set; }
        public string? postal_code { get; set; }
        public string? country { get; set; }
        public string? home_phone { get; set; }
        public string? extension { get; set; }
        public byte[] photo { get; set; }
        public string? notes { get; set; }
        public short? reports_to { get; set; }
        public string? photo_path { get; set; }
    }

    public class EmployeeTerritories
    {
        [Key]
        public short employee_id { get; set; }
        public string? territory_id { get; set; }
    }

    public class OrderDetails
    {
        [Key]   
        public short order_id { get; set; }
        public short product_id { get; set; }
        public float unit_price { get; set; }
        public short quantity { get; set; }
        public float discount { get; set; }
    }

    public class Orders
    {
        [Key]
        public short order_id { get; set; }
        public string? customer_id { get; set; }
        public short? employee_id { get; set; }
        public DateTime? order_date { get; set; }
        public DateTime? required_date { get; set; }
        public DateTime? shipped_date { get; set; }
        public short? ship_via { get; set; }
        public float? freight { get; set; }
        public string? ship_name { get; set; }
        public string? ship_address { get; set; }
        public string? ship_city { get; set; }
        public string? ship_region { get; set; }
        public string? ship_postal_code { get; set; }
        public string? ship_country { get; set; }
    }

    public class Products
    {
        [Key]
        public short product_id { get; set; } 
        public string? product_name { get; set; }
        public short? supplier_id { get; set; }
        public short? category_id { get; set; }
        public string? quantity_per_unit { get; set; }
        public float? unit_price { get; set; }
        public short? units_in_stock { get; set; }
        public short? units_on_order { get; set; }
        public short? reorder_level { get; set; }
        public int discontinued { get; set; }
    }
    public class Region
    {
        [Key]
        public short region_id { get; set; }
        public string? region_description { get; set; }
    }

    public class Shippers
    {
        [Key]
        public short shipper_id { get; set; }
        public string? company_name { get; set; }
        public string? phone { get; set; }
    }

    public class Suppliers
    {
        [Key]
        public short supplier_id { get; set; }
        public string? company_name { get; set; }
        public string? contact_name { get; set; }
        public string? contact_title { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? region { get; set; }
        public string? postal_code { get; set; }
        public string? country { get; set; }
        public string? phone { get; set; }
        public string? fax { get; set; }
        public string? homepage { get; set; }
    }

    public class Territories
    {
        [Key]
        public string territory_id { get; set; }
        public string? territory_description { get; set; }
        public short region_id { get; set; }
    }

}
