namespace CompanyWithStoredArticles
{
    using System;    

    public class Article : IComparable<Article>
    {
        public Article(int barcode, string vendor, string title, decimal price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public int Barcode { get; set; }

        public string Vendor { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
       
        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return this.Title + " " + this.Barcode + " " + this.Vendor + " " + this.Price;
        }
    }
}
