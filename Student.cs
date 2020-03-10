using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab3
{
    public class Student
    { //opisac baze mozna oprzez adnotacje w klasie required
        [Key] //jak nazwe to Id to się domysli
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        //[Column("Name")]
        public string Imie { get; set; }
        [Required] //to co pod tym ten prop w bazie am byc obowiazkowy 
        [MaxLength(255)]
        public string Nazwisko { get; set; }
    }
}
