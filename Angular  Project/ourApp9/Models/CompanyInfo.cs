using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ourApp9.Models
{
    public class CompanyInfo
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]

        [Key]
        public int CId { get; set; } 

        public string CName { get; set; }
    }
}
