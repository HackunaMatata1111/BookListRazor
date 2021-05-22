using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        public string LName { get; set; }
        public string Emailid { get; set; }
        public string product { get; set; }
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string line3 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int Pincode { get; set; }
    }
}
