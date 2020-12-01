using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Options.Models
{
    public class Option
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Symbol { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Type { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Details { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string StrikePrice { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string StartDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ExpiryDate { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public double StockPriceAtSale { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public double AveragePrice { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public double Commission { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public double Profit { get; set; }



    }
}
