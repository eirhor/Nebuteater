namespace Nebuteater.Models.Entities
{
    public class User : EntityBase
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}