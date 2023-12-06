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
    [Migration("20231205212538_ada")]
    partial class ada
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EstimateTax.Models.FlatRateTax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FlatRate_Per_Income")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FlatRates");
                });

            modelBuilder.Entity("EstimateTax.Models.FlatValueTax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Fix_Flatate_per_Income")
                        .HasColumnType("float");

                    b.Property<double>("FlatValue_Per_Income")
                        .HasColumnType("float");

                    b.Property<double>("rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("FlatValues");
                });

            modelBuilder.Entity("EstimateTax.Models.TaxBakets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("From")
                        .HasColumnType("float");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<double>("To")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Progressives");
                });

            modelBuilder.Entity("EstimateTax.Models.TaxInfo", b =>
                {
                    b.Property<int>("TaxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("income")
                        .HasColumnType("float");

                    b.HasKey("TaxId");

                    b.ToTable("TaxInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
