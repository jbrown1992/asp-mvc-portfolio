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
    public class Share
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Symbol { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Quantity { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public double CurrentPrice { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public double AveragePrice { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Exchange { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Return { get; set; }


        public void CalcReturns()
        {
            var value = (CurrentPrice - AveragePrice) * Double.Parse(Quantity);
            Return = value.ToString();
        }

        public async Task GetCurrentSharePriceAsync()
        {
            if (Exchange.Equals("NYSE") || Exchange.Equals("NASDAQ"))
            {
                CurrentPrice = await GetSharePriceForSymbol(Symbol);
            }
        }

        public async Task<double> GetSharePriceForSymbol(string symbol)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://finnhub.io/api/v1/quote?symbol={symbol}&token=btoscin48v6pbh1emso0");
                var response = await client.GetAsync(client.BaseAddress);

                var currentQuote = JsonConvert.DeserializeObject<FinnQuote>(response.Content.ReadAsStringAsync().Result);
                return currentQuote.c;
            }

        }
    }
}
