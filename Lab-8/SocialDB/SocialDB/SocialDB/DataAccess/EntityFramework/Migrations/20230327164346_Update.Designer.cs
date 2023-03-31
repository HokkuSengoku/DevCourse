﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SocialDB.DataAccess.EntityFramework;

#nullable disable

namespace SocialDB.DataAccess.EntityFramework.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230327164346_Update")]
    partial class Update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SocialDB.Domain.Friend", b =>
                {
                    b.Property<int>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("friendId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FriendId"));

                    b.Property<int>("FromUserId")
                        .HasColumnType("int")
                        .HasColumnName("userFrom");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("sendDate");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<int>("ToUserId")
                        .HasColumnType("int")
                        .HasColumnName("userTo");

                    b.HasKey("FriendId");

                    b.HasIndex("ToUserId");

                    b.ToTable("friends", (string)null);
                });

            modelBuilder.Entity("SocialDB.Domain.Like", b =>
                {
                    b.Property<int>("MessageId")
                        .HasColumnType("int")
                        .HasColumnName("messageId");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.ToTable((string)null);

                    b.ToView("Likes", (string)null);
                });

            modelBuilder.Entity("SocialDB.Domain.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("messageId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("authorId");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("sendDate");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(MAX)")
                        .HasColumnName("text");

                    b.HasKey("MessageId");

                    b.HasIndex("AuthorId");

                    b.ToTable("messages", (string)null);
                });

            modelBuilder.Entity("SocialDB.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_of_birth");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("gender");

                    b.Property<DateTime>("LastVisit")
                        .HasColumnType("datetime2")
                        .HasColumnName("last_visit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<bool>("Online")
                        .HasColumnType("bit")
                        .HasColumnName("online");

                    b.HasKey("UserId");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("SocialDB.Domain.Friend", b =>
                {
                    b.HasOne("SocialDB.Domain.User", "User")
                        .WithMany("Friends")
                        .HasForeignKey("ToUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SocialDB.Domain.Message", b =>
                {
                    b.HasOne("SocialDB.Domain.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SocialDB.Domain.User", b =>
                {
                    b.Navigation("Friends");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
