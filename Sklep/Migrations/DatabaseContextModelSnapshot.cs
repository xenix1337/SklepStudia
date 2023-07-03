﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Sklep.Database;

#nullable disable

namespace Sklep.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Sklep.Database.Models.InventoryChange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric")
                        .HasColumnName("amount");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<int?>("PositionId")
                        .HasColumnType("integer")
                        .HasColumnName("position_id");

                    b.Property<string>("Type")
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("pk_inventory_change");

                    b.HasIndex("PositionId")
                        .HasDatabaseName("ix_inventory_change_position_id");

                    b.ToTable("inventory_change", (string)null);
                });

            modelBuilder.Entity("Sklep.Database.Models.InventoryPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric")
                        .HasColumnName("amount");

                    b.Property<int>("Rack")
                        .HasColumnType("integer")
                        .HasColumnName("rack");

                    b.Property<int>("Shelf")
                        .HasColumnType("integer")
                        .HasColumnName("shelf");

                    b.HasKey("Id")
                        .HasName("pk_inventory_position");

                    b.ToTable("inventory_position", (string)null);
                });

            modelBuilder.Entity("Sklep.Database.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .HasColumnType("text")
                        .HasColumnName("barcode");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    b.Property<string>("LongName")
                        .HasColumnType("text")
                        .HasColumnName("long_name");

                    b.Property<int?>("PositionId")
                        .HasColumnType("integer")
                        .HasColumnName("position_id");

                    b.Property<double>("Price")
                        .HasColumnType("double precision")
                        .HasColumnName("price");

                    b.Property<string>("ShortName")
                        .HasColumnType("text")
                        .HasColumnName("short_name");

                    b.HasKey("Id")
                        .HasName("pk_product");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_product_category_id");

                    b.HasIndex("PositionId")
                        .HasDatabaseName("ix_product_position_id");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("Sklep.Database.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AdultOnly")
                        .HasColumnType("boolean")
                        .HasColumnName("adult_only");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<double>("VAT")
                        .HasColumnType("double precision")
                        .HasColumnName("vat");

                    b.HasKey("Id")
                        .HasName("pk_product_category");

                    b.ToTable("product_category", (string)null);
                });

            modelBuilder.Entity("Sklep.Database.Models.ProductGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer")
                        .HasColumnName("amount");

                    b.Property<string>("GroupBarcode")
                        .HasColumnType("text")
                        .HasColumnName("group_barcode");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.HasKey("Id")
                        .HasName("pk_product_group");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_product_group_product_id");

                    b.ToTable("product_group", (string)null);
                });

            modelBuilder.Entity("Sklep.Database.Models.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.HasKey("Id")
                        .HasName("pk_receipt");

                    b.ToTable("receipt", (string)null);
                });

            modelBuilder.Entity("Sklep.Database.Models.ReceiptPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric")
                        .HasColumnName("amount");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<int>("ReceiptId")
                        .HasColumnType("integer")
                        .HasColumnName("receipt_id");

                    b.HasKey("Id")
                        .HasName("pk_receipt_position");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_receipt_position_product_id");

                    b.HasIndex("ReceiptId")
                        .HasDatabaseName("ix_receipt_position_receipt_id");

                    b.ToTable("receipt_position", (string)null);
                });

            modelBuilder.Entity("Sklep.Database.Models.InventoryChange", b =>
                {
                    b.HasOne("Sklep.Database.Models.InventoryPosition", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .HasConstraintName("fk_inventory_change_inventory_position_position_id");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Sklep.Database.Models.Product", b =>
                {
                    b.HasOne("Sklep.Database.Models.ProductCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("fk_product_categories_category_id");

                    b.HasOne("Sklep.Database.Models.InventoryPosition", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .HasConstraintName("fk_product_inventory_positions_position_id");

                    b.Navigation("Category");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Sklep.Database.Models.ProductGroup", b =>
                {
                    b.HasOne("Sklep.Database.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_product_group_product_product_id");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Sklep.Database.Models.ReceiptPosition", b =>
                {
                    b.HasOne("Sklep.Database.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_receipt_position_product_product_id");

                    b.HasOne("Sklep.Database.Models.Receipt", "Receipt")
                        .WithMany("ReceiptPositions")
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_receipt_position_receipts_receipt_id");

                    b.Navigation("Product");

                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("Sklep.Database.Models.Receipt", b =>
                {
                    b.Navigation("ReceiptPositions");
                });
#pragma warning restore 612, 618
        }
    }
}
