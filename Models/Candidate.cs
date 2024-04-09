using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VotingSystem.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [Required, StringLength(50, ErrorMessage = "Can be up to 50 characters.")]
        public string Name { get; set; }

        public string TC { get; set; }

        [Required, StringLength(50, ErrorMessage = "Can be up to 50 characters.")]
        public string City { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        [Required, StringLength(250, ErrorMessage = "Can be up to 250 characters.")]
        [DisplayName("Photo")]
        public string PhotoPath { get; set; }

        public ICollection<VoteCastingInfo> VoteCastingInfos { get; set; }
    }
}
