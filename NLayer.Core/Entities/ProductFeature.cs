using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entities
{
    public class ProductFeature
    {
        public int Id { get; set; }
        public string? Color { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }


        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
