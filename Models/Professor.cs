namespace EscolaOnline.Api.Models
{
    public class Professor
    {
        public Professor()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Ocupation { get; set; }
    }
}