﻿// <auto-generated />
using System;
using Cookbook.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cookbook.DAL.Migrations
{
    [DbContext(typeof(CookbookDbContext))]
    partial class CookbookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Cookbook.DAL.Entities.AuthorsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorName")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Cookbook.DAL.Entities.IngredientEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IngredientName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Cookbook.DAL.Entities.IngredientRecipeEntity", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("RecipeId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("IngredientRecipes");
                });

            modelBuilder.Entity("Cookbook.DAL.Entities.NutritionalValuesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Carbohydrates")
                        .HasColumnType("int");

                    b.Property<float>("EnergyValue")
                        .HasColumnType("float");

                    b.Property<int>("Fat")
                        .HasColumnType("int");

                    b.Property<string>("PortionSize")
                        .HasColumnType("text");

                    b.Property<int>("Proteins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NutritionalValues");
                });

            modelBuilder.Entity("Cookbook.DAL.Entities.RecipeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CookingDifficultiesId")
                        .HasColumnType("int");

                    b.Property<int>("CookingDifficulty")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int>("DifficultyCategory")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfServings")
                        .HasColumnType("int");

                    b.Property<string>("PreparationProcess")
                        .HasColumnType("text");

                    b.Property<string>("RecipeName")
                        .HasColumnType("text");

                    b.Property<int>("TimeToBakeAndCookInMinits")
                        .HasColumnType("int");

                    b.Property<int>("TimeToPrepareInMinits")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("Cookbook.DAL.Entities.ReviewEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("TextOfReview")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("Cookbook.DAL.Entities.UnitEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("Cookbook.DAL.Entities.IngredientRecipeEntity", b =>
                {
                    b.HasOne("Cookbook.DAL.Entities.IngredientEntity", "Ingredient")
                        .WithMany("IngredientRecipes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cookbook.DAL.Entities.RecipeEntity", "Recipe")
                        .WithMany("IngredientRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cookbook.DAL.Entities.RecipeEntity", b =>
                {
                    b.HasOne("Cookbook.DAL.Entities.AuthorsEntity", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");
                });

            modelBuilder.Entity("Cookbook.DAL.Entities.ReviewEntity", b =>
                {
                    b.HasOne("Cookbook.DAL.Entities.AuthorsEntity", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");
                });
#pragma warning restore 612, 618
        }
    }
}
