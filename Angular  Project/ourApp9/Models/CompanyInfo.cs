using System.ComponentModel.DataAnnotations;

namespace ourApp9.Models
{
    public class CompanyInfo
    {
        [Key]
        public int CId { get; set; } 

        public string CName { get; set; }
    }
}
