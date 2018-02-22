﻿// <auto-generated />
using Com.Bateeq.Service.Merchandiser.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.Bateeq.Service.Merchandiser.Lib.Migrations
{
    [DbContext(typeof(MerchandiserDbContext))]
    partial class MerchandiserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Address1")
                        .HasMaxLength(3000);

                    b.Property<string>("Address2")
                        .HasMaxLength(3000);

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("SubCategory")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.CostCalculationGarment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AccessoriesAllowance");

                    b.Property<bool>("Active");

                    b.Property<string>("Article")
                        .HasMaxLength(500);

                    b.Property<int>("BuyerId");

                    b.Property<string>("BuyerName")
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<double>("CommissionPortion");

                    b.Property<double>("CommissionRate");

                    b.Property<string>("Commodity")
                        .HasMaxLength(500);

                    b.Property<DateTime>("ConfirmDate");

                    b.Property<double>("ConfirmPrice");

                    b.Property<string>("ConvectionId")
                        .HasMaxLength(100);

                    b.Property<string>("ConvectionName")
                        .HasMaxLength(500);

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<int>("EfficiencyId");

                    b.Property<double>("EfficiencyValue");

                    b.Property<double>("FabricAllowance");

                    b.Property<double>("Freight");

                    b.Property<double>("FreightCost");

                    b.Property<double>("Index");

                    b.Property<double>("Insurance");

                    b.Property<int>("LeadTime");

                    b.Property<double>("NETFOB");

                    b.Property<double>("NETFOBP");

                    b.Property<double>("OTL1CalculatedRate");

                    b.Property<int>("OTL1Id");

                    b.Property<double>("OTL1Rate");

                    b.Property<double>("OTL2CalculatedRate");

                    b.Property<int>("OTL2Id");

                    b.Property<double>("OTL2Rate");

                    b.Property<double>("ProductionCost");

                    b.Property<int>("Quantity");

                    b.Property<string>("RO")
                        .HasMaxLength(100);

                    b.Property<int>("RateDollarId");

                    b.Property<double>("RateDollarRate");

                    b.Property<double>("Risk");

                    b.Property<double>("SMV_Cutting");

                    b.Property<double>("SMV_Finishing");

                    b.Property<double>("SMV_Sewing");

                    b.Property<double>("SMV_Total");

                    b.Property<string>("Section")
                        .HasMaxLength(500);

                    b.Property<int>("SerialNumber");

                    b.Property<int>("SizeRangeId");

                    b.Property<string>("SizeRangeName")
                        .HasMaxLength(500);

                    b.Property<int>("THRId");

                    b.Property<double>("THRRate");

                    b.Property<int>("WageId");

                    b.Property<double>("WageRate");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("CostCalculationGarments");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.CostCalculationGarment_Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<double>("BudgetQuantity");

                    b.Property<double?>("CMT_Price");

                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<double>("Conversion");

                    b.Property<int>("CostCalculationGarmentId");

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<int>("MaterialId");

                    b.Property<string>("MaterialName")
                        .HasMaxLength(500);

                    b.Property<double>("Price");

                    b.Property<double>("Quantity");

                    b.Property<double>("ShippingFeePortion");

                    b.Property<double>("Total");

                    b.Property<double>("TotalShippingFee");

                    b.Property<int>("UOMPriceId");

                    b.Property<string>("UOMPriceName")
                        .HasMaxLength(500);

                    b.Property<int>("UOMQuantityId");

                    b.Property<string>("UOMQuantityName")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.Property<bool>("isFabricCMT");

                    b.HasKey("Id");

                    b.HasIndex("CostCalculationGarmentId");

                    b.ToTable("CostCalculationGarment_Materials");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.CostCalculationRetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Article")
                        .HasMaxLength(500);

                    b.Property<int>("BuyerId");

                    b.Property<string>("BuyerName")
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("CounterId")
                        .HasMaxLength(100);

                    b.Property<string>("CounterName")
                        .HasMaxLength(500);

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<int>("EfficiencyId");

                    b.Property<double>("EfficiencyValue");

                    b.Property<double>("HPP");

                    b.Property<double>("OLCalculatedRate");

                    b.Property<int>("OLId");

                    b.Property<double>("OLRate");

                    b.Property<double>("OTL1CalculatedRate");

                    b.Property<int>("OTL1Id");

                    b.Property<double>("OTL1Rate");

                    b.Property<double>("OTL2CalculatedRate");

                    b.Property<int>("OTL2Id");

                    b.Property<double>("OTL2Rate");

                    b.Property<double>("OTL3CalculatedRate");

                    b.Property<int>("OTL3Id");

                    b.Property<double>("OTL3Rate");

                    b.Property<double>("Proposed20");

                    b.Property<double>("Proposed21");

                    b.Property<double>("Proposed22");

                    b.Property<double>("Proposed23");

                    b.Property<double>("Proposed24");

                    b.Property<double>("Proposed25");

                    b.Property<double>("Proposed26");

                    b.Property<double>("Proposed27");

                    b.Property<double>("Proposed28");

                    b.Property<double>("Proposed29");

                    b.Property<double>("Proposed30");

                    b.Property<int>("Quantity");

                    b.Property<string>("RO")
                        .HasMaxLength(100);

                    b.Property<double>("Risk");

                    b.Property<double>("Rounding20");

                    b.Property<double>("Rounding21");

                    b.Property<double>("Rounding22");

                    b.Property<double>("Rounding23");

                    b.Property<double>("Rounding24");

                    b.Property<double>("Rounding25");

                    b.Property<double>("Rounding26");

                    b.Property<double>("Rounding27");

                    b.Property<double>("Rounding28");

                    b.Property<double>("Rounding29");

                    b.Property<double>("Rounding30");

                    b.Property<double>("RoundingOthers");

                    b.Property<double>("SH_Cutting");

                    b.Property<double>("SH_Finishing");

                    b.Property<double>("SH_Sewing");

                    b.Property<string>("SeasonId")
                        .HasMaxLength(100);

                    b.Property<string>("SeasonName")
                        .HasMaxLength(500);

                    b.Property<string>("SelectedRounding")
                        .HasMaxLength(20);

                    b.Property<int>("SerialNumber");

                    b.Property<int>("SizeRangeId");

                    b.Property<string>("SizeRangeName")
                        .HasMaxLength(500);

                    b.Property<string>("StyleId")
                        .HasMaxLength(100);

                    b.Property<string>("StyleName")
                        .HasMaxLength(500);

                    b.Property<double>("WholesalePrice");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("CostCalculationRetails");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.CostCalculationRetail_Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("CategoryId");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<double>("Conversion");

                    b.Property<int>("CostCalculationRetailId");

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<int>("MaterialId");

                    b.Property<string>("MaterialName")
                        .HasMaxLength(500);

                    b.Property<double>("Price");

                    b.Property<double>("Quantity");

                    b.Property<double>("Total");

                    b.Property<int>("UOMPriceId");

                    b.Property<string>("UOMPriceName")
                        .HasMaxLength(500);

                    b.Property<int>("UOMQuantityId");

                    b.Property<string>("UOMQuantityName")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("CostCalculationRetailId");

                    b.ToTable("CostCalculationRetail_Materials");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.Efficiency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<int>("FinalRange");

                    b.Property<int>("InitialRange");

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<double>("Value");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Efficiencies");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Composition")
                        .HasMaxLength(500);

                    b.Property<string>("Construction")
                        .HasMaxLength(500);

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("Width")
                        .HasMaxLength(500);

                    b.Property<string>("Yarn")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.OTL", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<double>("Rate");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("OTLs");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.RelatedSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<int>("SizeId");

                    b.Property<int>("SizeRangeId");

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("SizeId");

                    b.HasIndex("SizeRangeId");

                    b.ToTable("RelatedSizes");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.SizeRange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("SizeRanges");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.UOM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("UOMs");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.CostCalculationGarment_Material", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Merchandiser.Lib.Models.CostCalculationGarment", "CostCalculationGarment")
                        .WithMany("CostCalculationGarment_Materials")
                        .HasForeignKey("CostCalculationGarmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.CostCalculationRetail_Material", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Merchandiser.Lib.Models.CostCalculationRetail", "CostCalculationRetail")
                        .WithMany("CostCalculationRetail_Materials")
                        .HasForeignKey("CostCalculationRetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.Material", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Merchandiser.Lib.Models.Category", "Category")
                        .WithMany("Materials")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Bateeq.Service.Merchandiser.Lib.Models.RelatedSize", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Merchandiser.Lib.Models.Size", "Size")
                        .WithMany("RelatedSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Com.Bateeq.Service.Merchandiser.Lib.Models.SizeRange", "SizeRange")
                        .WithMany("RelatedSizes")
                        .HasForeignKey("SizeRangeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
