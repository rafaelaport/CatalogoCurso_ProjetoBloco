﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CatalogoCurso.Domain.Conta;

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

            builder.HasOne(x => x.Professor).WithMany();
            builder.HasMany(x => x.Alunos).WithMany(x => x.Turmas)
                .UsingEntity<Dictionary<string, object>>(
                    x => x.HasOne<Aluno>().WithMany().OnDelete(DeleteBehavior.Restrict),
                    x => x.HasOne<Domain.Turma.Turma>().WithMany().OnDelete(DeleteBehavior.Restrict)); 
            builder.HasOne(x => x.Disciplina).WithMany();
            builder.HasOne(x => x.Unidade).WithMany();
        }
    }
}
