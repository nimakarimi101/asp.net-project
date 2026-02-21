using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication5.Models;

namespace WebApplication5.mapping
{
    public class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            
            builder.HasKey(p => p.Id);
            builder.Property(x=> x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Email).IsRequired();
        }
    }
}