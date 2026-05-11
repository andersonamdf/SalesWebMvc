using System.Collections.Generic;
using System.Linq;
namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;

        public ICollection<Seller> sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddSeller(Seller seller)
        {
            sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
          return sellers.Sum(seller => seller.TotalSales(initial, final));

        }
    }
}
