using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CatalogoCurso.Repository.Mapping.Turma
{
    public class TurmaMapping : IEntityTypeConfiguration<Domain.Turma.Turma>
    {
        public void Configure(EntityTypeBuilder<Domain.Turma.Turma> builder)
        {
            builder.ToTable("Turma");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Horario).IsRequired();
            builder.Property(x => x.Sala).IsRequired();

            builder.Property(x => x.DataCadastro).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
