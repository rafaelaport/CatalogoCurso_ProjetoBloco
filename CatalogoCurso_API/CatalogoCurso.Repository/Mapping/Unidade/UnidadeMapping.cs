using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Mapping.Unidade
{
    public class UnidadeMapping : IEntityTypeConfiguration<Domain.Unidade.Unidade>
    {
        public void Configure(EntityTypeBuilder<Domain.Unidade.Unidade> builder)
        {
            builder.ToTable("Unidade");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Endereco).IsRequired();

            builder.Property(x => x.DataCadastro).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
