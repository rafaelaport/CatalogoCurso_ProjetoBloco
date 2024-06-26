﻿using CatalogoCurso.Domain.Disciplina;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Mapping.Curso
{
    public class DisciplinaMapping : IEntityTypeConfiguration<Domain.Disciplina.Disciplina>
    {
        public void Configure(EntityTypeBuilder<Domain.Disciplina.Disciplina> builder)
        {
            builder.ToTable("Disciplina");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Objetivo).HasMaxLength(500);
            builder.Property(x => x.Bibliografia).HasMaxLength(500);
            builder.Property(x => x.Avaliacao).HasMaxLength(500);
            builder.Property(x => x.Certificacao).HasMaxLength(500);

            builder.HasOne(x => x.ModalidadeEnsino).WithMany().HasForeignKey(y => y.ModalidadeEnsinoId);
            builder.HasOne(x => x.Segmento).WithMany().HasForeignKey(y => y.SegmentoId);

            builder.Property(x => x.DataCadastro).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();


        }
    }
}
