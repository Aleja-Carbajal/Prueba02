using System;
using Parcial02.Entities.Specialties;
using Parcial02.Entities.Users;

namespace Parcial02.Entities.Reservations
{
    public class Reservation
    {
        public int Id { get; set; }
        
        public virtual User userReserved { get; set; }
        
        public virtual  Speciality specialityReserved { get; set; }
        
        public DateTime dateReserved { get; set; }
    }
}