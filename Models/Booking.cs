using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loundry.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("laundry_id")]
        public int LaundryId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("data")]
        public DateTime Date { get; set; }

        [Column("time")]
        public TimeSpan Time { get; set; }

        [Column("number")]
        public int MachinesCount { get; set; }

    }
}
