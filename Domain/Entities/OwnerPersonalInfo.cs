using System.ComponentModel.DataAnnotations;

namespace FlatMeat_Backend.Domain.Entities
{
    public class OwnerPersonalInfo
    {

        [Key]
        public int OwnerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public string AadharNumber { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<RoomData> Rooms { get; set; }



    }
}
