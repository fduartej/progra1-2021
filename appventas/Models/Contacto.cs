using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appventas.Models
{
    [Table("t_contact")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Column("name")]
        public String Name {get; set;}
        
        [Column("email")]
        public String Email {get; set;}
        
        [Column("phone")]
        public String Phone {get; set;}

        [NotMapped]
        public String Status {get; set;}
    }
}