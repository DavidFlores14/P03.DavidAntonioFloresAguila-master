using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int SupplierCod { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}