namespace EscolaOnline.Api.Models
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int ClassNumber { get; set; }
    }
}
