using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;

namespace FlatMeat_Backend.Domain.Entities
{
    public class RoomData
    {
        [Key]
        public int RoomId { get; set; }

        public int OwnerId { get; set; }
        public OwnerPersonalInfo Owner { get; set; }

        public string HouseAddress { get; set; }
        public string HouseType { get; set; }       
        public string RoomSharingType { get; set; } 
        public string FurnishingType { get; set; }
        public string RoomType { get; set; }         

        public decimal Price { get; set; }
        public string PinCode { get; set; }

        public bool HouseProofVerified { get; set; }

        public string RulesAndBenefits { get; set; }
        public string NearbyPlaces { get; set; }
        public string Description { get; set; }

        public List<string>  ImageUrls { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
