using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Category
    {
        //Primary Key
        public int Id { get; set; }
        //Identify Person
        public int CategoryId { get; set; }
        public string Name { get; set; }

        [Display(Name ="Category Picture")]
        public byte[] CategoryPicture { get; set; }
        public string CategoryContentType { get; set; }

        //Defining a FOREIGN KEY
        public ICollection<Contact> Contact { get; set; } = new HashSet<Contact>();


    }
}
