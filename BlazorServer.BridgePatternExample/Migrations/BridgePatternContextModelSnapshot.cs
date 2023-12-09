﻿// <auto-generated />
using System;
using BlazorServer.BridgePatternExample.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServer.BridgePatternExample.Migrations
{
    [DbContext(typeof(BridgePatternContext))]
    partial class BridgePatternContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BaseCost")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CardRarityId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CardTypeId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ColorIdentityId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ConvertedManaCost")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Set")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardRarityId");

                    b.HasIndex("CardTypeId");

                    b.HasIndex("ColorIdentityId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseCost = 1000,
                            CardRarityId = 3,
                            CardTypeId = 2,
                            ColorIdentityId = 4,
                            ConvertedManaCost = 0,
                            Description = "Gaea's Cradle",
                            Name = "Gaea's Cradle",
                            Set = "Urza's Saga"
                        },
                        new
                        {
                            Id = 2,
                            BaseCost = 500,
                            CardRarityId = 3,
                            CardTypeId = 1,
                            ColorIdentityId = 1,
                            ConvertedManaCost = 5,
                            Description = "Sliver Queen",
                            Name = "Sliver Queen",
                            Set = "Stronghold"
                        },
                        new
                        {
                            Id = 3,
                            BaseCost = 150000,
                            CardRarityId = 3,
                            CardTypeId = 5,
                            ColorIdentityId = 6,
                            ConvertedManaCost = 0,
                            Description = "Black Lotus",
                            Name = "Black Lotus",
                            Set = "Alpha"
                        });
                });

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.CardRarity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CardRarities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Common",
                            Name = "Common"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Uncommon",
                            Name = "Uncommon"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Rare",
                            Name = "Rare"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Legendary",
                            Name = "Legendary"
                        });
                });

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.CardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CardTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Creature",
                            Name = "Creature"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Land",
                            Name = "Land"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Scorcery",
                            Name = "Scorcery"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Instant",
                            Name = "Instant"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Artifact",
                            Name = "Artifact"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Enchantment",
                            Name = "Enchantment"
                        });
                });

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.ColorIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ColorIdentities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Blue",
                            Name = "U"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Red",
                            Name = "R"
                        },
                        new
                        {
                            Id = 3,
                            Description = "White",
                            Name = "W"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Green",
                            Name = "G"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Black",
                            Name = "B"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Colorless",
                            Name = "L"
                        });
                });

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.Condition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Conditions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Damaged",
                            Name = "Damaged"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Heavily Played",
                            Name = "Heavily Played"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Moderately Played",
                            Name = "Moderately Played"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Lightly Played",
                            Name = "Lightly Played"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Near Mint",
                            Name = "Near Mint"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Mint",
                            Name = "Mint"
                        });
                });

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CardId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ConditionId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TotalCost")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("ConditionId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardId = 1,
                            Comments = "None",
                            ConditionId = 6,
                            Description = "Gaea's Cradel - Mint",
                            Name = "Mint Gaea's Cradel",
                            TotalCost = 3000
                        });
                });

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.PremiumOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CardId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ConditionId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("PricePremium")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TotalCost")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("ConditionId");

                    b.ToTable("PremiumOrders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardId = 1,
                            Comments = "None",
                            ConditionId = 6,
                            Description = "Gaea's Cradel - Mint",
                            Name = "Mint Gaea's Cradel",
                            PricePremium = 300,
                            Reason = "Promo Card",
                            TotalCost = 3000
                        });
                });

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.Card", b =>
                {
                    b.HasOne("BlazorServer.BridgePatternExample.Domain.Models.CardRarity", "CardRarity")
                        .WithMany()
                        .HasForeignKey("CardRarityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorServer.BridgePatternExample.Domain.Models.CardType", "CardType")
                        .WithMany()
                        .HasForeignKey("CardTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorServer.BridgePatternExample.Domain.Models.ColorIdentity", "ColorIdentity")
                        .WithMany()
                        .HasForeignKey("ColorIdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardRarity");

                    b.Navigation("CardType");

                    b.Navigation("ColorIdentity");
                });

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.Order", b =>
                {
                    b.HasOne("BlazorServer.BridgePatternExample.Domain.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorServer.BridgePatternExample.Domain.Models.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Condition");
                });

            modelBuilder.Entity("BlazorServer.BridgePatternExample.Domain.Models.PremiumOrder", b =>
                {
                    b.HasOne("BlazorServer.BridgePatternExample.Domain.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorServer.BridgePatternExample.Domain.Models.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Condition");
                });
#pragma warning restore 612, 618
        }
    }
}
