using Heal_Pharmacy.Abstracts;
namespace Heal_Pharmacy.Models;


    public class Medicine: EntityBase
    {
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal Price { get; set; } 
    }
