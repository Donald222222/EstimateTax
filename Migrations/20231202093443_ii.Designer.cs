﻿// <auto-generated />
using EstimateTax.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EstimateTax.Migrations
{
    [DbContext(typeof(DataContexts))]
    [Migration("20231202093443_ii")]
    partial class ii
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EstimateTax.Models.TaxInfo", b =>
                {
                    b.Property<int>("TaxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxTypes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaxId");

                    b.ToTable("TaxInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
