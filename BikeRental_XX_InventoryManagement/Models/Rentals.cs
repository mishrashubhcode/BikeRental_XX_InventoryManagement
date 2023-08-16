using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRental_XX_InventoryManagement.Models
{
    public class Rentals
    {
        [Key]
        public int RentalID { get; set; }


        public int CustomerID { get; set; }
        public virtual Customers Customer { get; set; }


        public int BikeID { get; set; }
        public virtual Bikes Bike { get; set; }

        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalCost { get; set; }

        [ForeignKey("CustomerID")]
        public Customers Customers { get; set; }
        public Bikes Bikes { get; set; }
    }
}