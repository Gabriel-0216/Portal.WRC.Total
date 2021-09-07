﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portal.WRC.Total.com.Data;

namespace Portal.WRC.Total.com.Migrations.RallyContextoMigrations
{
    [DbContext(typeof(RallyContexto))]
    [Migration("20210907114141_ScriptRally")]
    partial class ScriptRally
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portal.WRC.Total.com.Models.Rally", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cld_cidade_rally")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("cld_data_atualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("cld_data_insercao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("cld_data_rally")
                        .HasColumnType("datetime2");

                    b.Property<string>("cld_nome_completo_rally")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cld_nome_curto_rally")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cld_pais_rally")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cld_quantidade_dias")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rally");
                });
#pragma warning restore 612, 618
        }
    }
}
