using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test28Maggio.Library;

namespace Test28Maggio.EntityFramework
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CodiceCliente)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(c => c.Nome)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(c => c.Cognome)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}