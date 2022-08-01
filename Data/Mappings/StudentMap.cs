using EscolaOnline.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EscolaOnline.Api.Data.Mappings
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //Name of the table
            builder.ToTable("Student");

            //[Key]
            builder.HasKey(x => x.Id);

            //properties
            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(45);

            builder.Property(x => x.PasswordHash)
                .HasColumnName("PasswordHash")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.ClassNumber)
                .HasColumnName("ClassNumber")
                .HasColumnType("INT");
        }
    }
}
