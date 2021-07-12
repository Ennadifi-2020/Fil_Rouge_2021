using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace R_Piscine1.Models
{
    public class Reservation_Pescine
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RequestingClientId")]
        public Client RequestingClient { get; set; }
        public string RequestingStudentId { get; set; }
        [ForeignKey("ReservationTypeId")]
        public ReservationType ReservationType { get; set; }
        public int ReservationTypeId { get; set; }
        public float Price { get; set; }
        public DateTime Date { get; set; }
        public bool? isAccepted { get; set; }
    }
}
