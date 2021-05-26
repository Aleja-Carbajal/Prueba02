using System.ComponentModel.DataAnnotations;

namespace Parcial02.Entities.Questions
{
    public class Question
    {
        [Key]
        public string Id { get; set; }
        
        public string SecurityQuestion { get; set; }
    }
}