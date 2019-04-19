﻿// <auto-generated />
using System;
using Domain.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    [Migration("20190419010036_removedNullableProperty")]
    partial class removedNullableProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Choice", b =>
                {
                    b.Property<int>("ChoiceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionID");

                    b.Property<string>("Text");

                    b.HasKey("ChoiceID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer");

                    b.Property<string>("Body");

                    b.Property<string>("Creator");

                    b.Property<int>("TopicID");

                    b.HasKey("QuestionID");

                    b.HasIndex("TopicID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Domain.Entities.Quiz", b =>
                {
                    b.Property<int>("QuizID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfQuestions");

                    b.Property<string>("Owner");

                    b.Property<decimal>("Score");

                    b.Property<int>("TopicID");

                    b.HasKey("QuizID");

                    b.HasIndex("TopicID");

                    b.ToTable("Quizs");
                });

            modelBuilder.Entity("Domain.Entities.QuizQuestionRelation", b =>
                {
                    b.Property<int?>("QuizID");

                    b.Property<int?>("QuestionID");

                    b.HasKey("QuizID", "QuestionID");

                    b.HasIndex("QuestionID");

                    b.ToTable("QuizQuestionRelation");
                });

            modelBuilder.Entity("Domain.Entities.Topic", b =>
                {
                    b.Property<int>("TopicID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("TopicID");

                    b.HasIndex("Description")
                        .IsUnique()
                        .HasFilter("[Description] IS NOT NULL");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("Domain.Entities.Choice", b =>
                {
                    b.HasOne("Domain.Entities.Question", "Question")
                        .WithMany("Choices")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.HasOne("Domain.Entities.Topic", "Topic")
                        .WithMany("Questions")
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.Quiz", b =>
                {
                    b.HasOne("Domain.Entities.Topic", "Topic")
                        .WithMany("Quizzes")
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.QuizQuestionRelation", b =>
                {
                    b.HasOne("Domain.Entities.Question", "Question")
                        .WithMany("QuizQuestionRelation")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Quiz", "Quiz")
                        .WithMany("QuizQuestionRelation")
                        .HasForeignKey("QuizID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
