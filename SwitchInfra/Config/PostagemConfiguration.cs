using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchDomain.Entities;

namespace SwitchInfra.Config
{
    public class PostagemConfiguration : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.DataPub).IsRequired();
            builder.Property(p => p.Descricao).IsRequired()
                .HasMaxLength(500);
            builder.HasOne(p => p.Usuario).WithMany(u => u.postagens);

        }
    }
}