using System.ComponentModel.DataAnnotations;

namespace Parcial02.Entities.Specialties
{
    public class Speciality
    {
        [Key]
        public string idSpe { get; set; }
        
        public string specialityClinic { get; set; }
    }
}