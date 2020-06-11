namespace Invoices
{
    public class Invoice
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        private int Quantity;
        private decimal Price;

        //Constructor
        public Invoice (string partnumber, string partdescription, int quantity, decimal price){
            PartNumber = partnumber;
            PartDescription = partdescription;
            Quantity = quantity;
            Price = price;
        }

        public int Qty
        {
            get {return Quantity;}
            set {
                if (value > 0)
                {
                    Quantity = value;
                }
                
            } 

        }

           public decimal Priz
        {
            get {return Price;}
            set {
                if (value > 0.0m)
                {
                    Price = value;
                }
                
            }
        }

        public decimal GetInvoiceAmount ()
        {
            return Quantity * Price;
        }

    }
}