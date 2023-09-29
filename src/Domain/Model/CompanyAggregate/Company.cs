using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet.src.Domain.Model.CompanyAggregate
{
    [Table("company")]
    public class Company
    {
        [Key]
        public Guid id { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string name { get; set; } 

        public Company(string name) 
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}