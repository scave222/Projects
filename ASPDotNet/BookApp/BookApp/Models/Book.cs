using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class Book
    {
        public long BookId { get; set; }
        public string BookName { get; set; }
        public string Category { get; set; }
        public string PurchasePrice { get; set; }
        public string DatePublish { get; set; }
    }
}
