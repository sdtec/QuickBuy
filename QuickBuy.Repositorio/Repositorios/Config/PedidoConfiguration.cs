﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Repositorios.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DataPedido).IsRequired();
            builder.Property(p => p.DataPrevisaoEntreaga).IsRequired();
            builder.Property(p => p.Cep).IsRequired().HasMaxLength(10);
            builder.Property(p => p.Cidade).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Estado).IsRequired().HasMaxLength(100);
            builder.Property(p => p.EnderecoCompleto).IsRequired().HasMaxLength(100);
            builder.Property(p => p.NumeroEndereco).IsRequired();
            //builder.HasOne(p => p.Usuario); //1 pedido só pode ter um unico usuário
        }
    }
}