using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Product
    {
        // Id is a special keyword given to automatically assign the primay key to this value
        // if we wanted the attribute to be named something else, we would put [Key] above the public declaration 
        public int Id { get; set; }
        //[Required] // required can be used to explicitly set the parameter as a required attribute for all data being entered
        public string Name { get; set; }
        public String Description{ get; set; }
        // Use a long since Stripe API utilizes longs for payments
        public long Price { get; set; }
        public string PictureUrl { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int QuantityInStock { get; set; }
    }
}
