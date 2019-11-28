using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchDomain.Entities;

namespace SwitchInfra.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.id);
            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(25);
            builder.Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(25);
            builder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(25);
            builder.Property(u => u.Sexo).IsRequired();
            builder.Property(u => u.DataNascimento).IsRequired();
            builder.Property(u => u.UrlFoto).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.HasOne(u => u.Identificacao).WithOne(i => i.Usuario)
                .HasForeignKey<Identificacao>(i => i.UsuarioId);
            builder.HasMany(u => u.postagens).WithOne(p => p.Usuario);

        }
    }
}