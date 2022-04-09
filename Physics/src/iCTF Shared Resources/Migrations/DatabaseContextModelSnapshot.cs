﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iCTF_Shared_Resources;

namespace iCTF_Shared_Resources.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(95)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(95)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ApiKey")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Attachments")
                        .HasColumnType("longtext");

                    b.Property<string>("Author")
                        .HasColumnType("longtext");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Flag")
                        .HasColumnType("longtext");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("Writeup")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.Config", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("BoardChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("BoardRoleId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("BoardWriteupsChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("ChallengePingRoleId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("ChallengeReleaseChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("ChallengeSolvesChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("FirstPlaceRoleId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("GuildId")
                        .HasColumnType("bigint unsigned");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("tinyint(1)");

                    b.Property<ulong>("LeaderboardChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("LogsChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("ReleaseTime")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.Property<ulong>("SecondPlaceRoleId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("ThirdPlaceRoleId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("TodaysChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("TodaysRoleId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("Id");

                    b.ToTable("Configuration");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.Redirect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RandomId")
                        .HasColumnType("longtext");

                    b.Property<string>("RedirectUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Redirects");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.Solve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Announced")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ChallengeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SolvedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("Solves");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("DiscordId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("DiscordUsername")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("iCTF_Shared_Resources.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("iCTF_Shared_Resources.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iCTF_Shared_Resources.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("iCTF_Shared_Resources.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.ApplicationUser", b =>
                {
                    b.HasOne("iCTF_Shared_Resources.Models.User", "User")
                        .WithOne("WebsiteUser")
                        .HasForeignKey("iCTF_Shared_Resources.Models.ApplicationUser", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.Solve", b =>
                {
                    b.HasOne("iCTF_Shared_Resources.Models.Challenge", "Challenge")
                        .WithMany("Solves")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iCTF_Shared_Resources.Models.Team", "Team")
                        .WithMany("Solves")
                        .HasForeignKey("TeamId");

                    b.HasOne("iCTF_Shared_Resources.Models.User", "User")
                        .WithMany("Solves")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Challenge");

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.User", b =>
                {
                    b.HasOne("iCTF_Shared_Resources.Models.Team", "Team")
                        .WithMany("Members")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.Challenge", b =>
                {
                    b.Navigation("Solves");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.Team", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Solves");
                });

            modelBuilder.Entity("iCTF_Shared_Resources.Models.User", b =>
                {
                    b.Navigation("Solves");

                    b.Navigation("WebsiteUser");
                });
#pragma warning restore 612, 618
        }
    }
}
