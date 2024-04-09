using System.ComponentModel.DataAnnotations;

namespace VotingSystem.Models
{
    public class Voter
    {
        public int Id { get; set; }
        [Required, StringLength(50, ErrorMessage = "Can be up to 50 characters.")]
        public string Name { get; set; }
        public int TC { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        [Required, StringLength(100, ErrorMessage = "Can be up to 100 characters.")]
        public string Password { get; set; }
        [Required, StringLength(50, ErrorMessage = "Can be up to 50 characters.")]
        public string City { get; set; }
        public ICollection<VoteCastingInfo> VoteCastingInfos { get; set; }
        public string Authority { get; set; }
    }
}
