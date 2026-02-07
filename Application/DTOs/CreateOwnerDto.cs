namespace FlatMeat_Backend.Application.DTOs
{
    public class CreateOwnerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public string AadharNumber { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
    }
}
