using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Contact
    {
       
        public int Id { get; set; }
        //Ties into parent doc
        public int CategoryId { get; set; }
        //identify unique id
        public int NameId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int HomePhone { get; set; }
        public int CellPhone { get; set; }
        public int FaxNumber { get; set; }
        public string Email { get; set; }

        [Display(Name ="Contact Pic")]
        public byte[] Picture { get; set; }
        public string ContentType { get; set; }
        
        public Category Category { get; set; }
    }
}
