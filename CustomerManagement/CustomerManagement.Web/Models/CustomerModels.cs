using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerManagement.Web.Models
{
    public class Customer
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Mobile No")]
        public string MobileNo { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }

    public class CustomerCollection : List<Customer>
    {
        internal void Update(Customer customer)
        {
            this.RemoveAll(x => x.Id == customer.Id);
            this.Add(customer);
        }

        internal int CreateId()
        {
            int id = 1;
            foreach (Customer customer in this)
            {
                if (customer.Id > id)
                {
                    id = customer.Id;
                }
            }
            return id + 1;
        }
    }
}