using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Options.Models
{
    public class SharePrice
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Symbol { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public DateTime LastTimeCheck { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public double CurrentPrice { get; set; }

    }
}

