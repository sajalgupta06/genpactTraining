using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ourApp9.Models
{
    public class ProductInfo
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public int PPrice { get; set; }
        public DateFormat PMDate { get; set; }

        
        public int CId { get; set; }
        [ForeignKey("CId")]
        public CompanyInfo CompanyInfo { get; set; }

    }
}
