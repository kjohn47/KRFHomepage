﻿// <auto-generated />
using KRFHomepage.Infrastructure.Database.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KRFHomepage.Infrastructure.Database.Migrations
{
    [DbContext(typeof(HomepageDBContext))]
    partial class HomepageDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KRFHomepage.Domain.Database.Common.Language", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Code");

                    b.ToTable("languages");

                    b.HasData(
                        new
                        {
                            Code = "PT",
                            Name = "Portuguese"
                        },
                        new
                        {
                            Code = "EN",
                            Name = "English"
                        });
                });

            modelBuilder.Entity("KRFHomepage.Domain.Database.Homepage.HomePageData", b =>
                {
                    b.Property<string>("LanguageCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("LanguageCode");

                    b.ToTable("homepages");

                    b.HasData(
                        new
                        {
                            LanguageCode = "PT",
                            Description = "Bem Vindo ao KRF, isto é uma framework react para fazer desenvolvimento divertido :)",
                            SubTitle = "A página principal do KRF com microserviços",
                            Title = "KJohn React Framework"
                        },
                        new
                        {
                            LanguageCode = "EN",
                            Description = "Welcome to KRF, this is a react framework to make some fun dev :)",
                            SubTitle = "The KRF homepage with microservices",
                            Title = "KJohn React Framework"
                        });
                });

            modelBuilder.Entity("KRFHomepage.Domain.Database.Translations.Token", b =>
                {
                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Value");

                    b.ToTable("tokens");

                    b.HasData(
                        new
                        {
                            Value = "#(loadingText)"
                        },
                        new
                        {
                            Value = "#(goBackToHome)"
                        },
                        new
                        {
                            Value = "#(goBackToHomeToolTip)"
                        },
                        new
                        {
                            Value = "#(cardDetails)"
                        },
                        new
                        {
                            Value = "#(edit)"
                        },
                        new
                        {
                            Value = "#(remove)"
                        },
                        new
                        {
                            Value = "#(TestPage Title)"
                        },
                        new
                        {
                            Value = "#(January)"
                        },
                        new
                        {
                            Value = "#(February)"
                        },
                        new
                        {
                            Value = "#(March)"
                        },
                        new
                        {
                            Value = "#(April)"
                        },
                        new
                        {
                            Value = "#(May)"
                        },
                        new
                        {
                            Value = "#(June)"
                        },
                        new
                        {
                            Value = "#(July)"
                        },
                        new
                        {
                            Value = "#(August)"
                        },
                        new
                        {
                            Value = "#(September)"
                        },
                        new
                        {
                            Value = "#(October)"
                        },
                        new
                        {
                            Value = "#(November)"
                        },
                        new
                        {
                            Value = "#(December)"
                        },
                        new
                        {
                            Value = "#(Mon)"
                        },
                        new
                        {
                            Value = "#(Tue)"
                        },
                        new
                        {
                            Value = "#(Wed)"
                        },
                        new
                        {
                            Value = "#(Thu)"
                        },
                        new
                        {
                            Value = "#(Fri)"
                        },
                        new
                        {
                            Value = "#(Sat)"
                        },
                        new
                        {
                            Value = "#(Sun)"
                        });
                });

            modelBuilder.Entity("KRFHomepage.Domain.Database.Translations.Translation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TokenValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TranslationCategoryValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("LanguageCode");

                    b.HasIndex("TokenValue");

                    b.HasIndex("TranslationCategoryValue");

                    b.ToTable("translations");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            LanguageCode = "PT",
                            Text = "A Carregar!",
                            TokenValue = "#(loadingText)",
                            TranslationCategoryValue = "_generic"
                        },
                        new
                        {
                            ID = 2,
                            LanguageCode = "PT",
                            Text = "Voltar para Homepage",
                            TokenValue = "#(goBackToHome)",
                            TranslationCategoryValue = "_generic"
                        },
                        new
                        {
                            ID = 3,
                            LanguageCode = "PT",
                            Text = "Carregue no botão para retomar para a homepage.",
                            TokenValue = "#(goBackToHomeToolTip)",
                            TranslationCategoryValue = "_generic"
                        },
                        new
                        {
                            ID = 4,
                            LanguageCode = "PT",
                            Text = "Ver detalhes",
                            TokenValue = "#(cardDetails)",
                            TranslationCategoryValue = "_generic"
                        },
                        new
                        {
                            ID = 5,
                            LanguageCode = "PT",
                            Text = "Editar",
                            TokenValue = "#(edit)",
                            TranslationCategoryValue = "_tableText"
                        },
                        new
                        {
                            ID = 6,
                            LanguageCode = "PT",
                            Text = "Remover",
                            TokenValue = "#(remove)",
                            TranslationCategoryValue = "_tableText"
                        },
                        new
                        {
                            ID = 7,
                            LanguageCode = "PT",
                            Text = "Página de Teste de Componentes",
                            TokenValue = "#(TestPage Title)",
                            TranslationCategoryValue = "_TestPage"
                        },
                        new
                        {
                            ID = 8,
                            LanguageCode = "PT",
                            Text = "Janeiro",
                            TokenValue = "#(January)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 9,
                            LanguageCode = "PT",
                            Text = "Fevereiro",
                            TokenValue = "#(February)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 10,
                            LanguageCode = "PT",
                            Text = "Março",
                            TokenValue = "#(March)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 11,
                            LanguageCode = "PT",
                            Text = "Abril",
                            TokenValue = "#(April)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 12,
                            LanguageCode = "PT",
                            Text = "Maio",
                            TokenValue = "#(May)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 13,
                            LanguageCode = "PT",
                            Text = "Junho",
                            TokenValue = "#(June)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 14,
                            LanguageCode = "PT",
                            Text = "Julho",
                            TokenValue = "#(July)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 15,
                            LanguageCode = "PT",
                            Text = "Agosto",
                            TokenValue = "#(August)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 16,
                            LanguageCode = "PT",
                            Text = "Setembro",
                            TokenValue = "#(September)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 17,
                            LanguageCode = "PT",
                            Text = "Outubro",
                            TokenValue = "#(October)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 18,
                            LanguageCode = "PT",
                            Text = "Novembro",
                            TokenValue = "#(November)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 19,
                            LanguageCode = "PT",
                            Text = "Dezembro",
                            TokenValue = "#(December)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 20,
                            LanguageCode = "PT",
                            Text = "Seg",
                            TokenValue = "#(Mon)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 21,
                            LanguageCode = "PT",
                            Text = "Ter",
                            TokenValue = "#(Tue)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 22,
                            LanguageCode = "PT",
                            Text = "Qua",
                            TokenValue = "#(Wed)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 23,
                            LanguageCode = "PT",
                            Text = "Qui",
                            TokenValue = "#(Thu)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 24,
                            LanguageCode = "PT",
                            Text = "Sex",
                            TokenValue = "#(Fri)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 25,
                            LanguageCode = "PT",
                            Text = "Sab",
                            TokenValue = "#(Sat)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 26,
                            LanguageCode = "PT",
                            Text = "Dom",
                            TokenValue = "#(Sun)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 27,
                            LanguageCode = "EN",
                            Text = "Loading!",
                            TokenValue = "#(loadingText)",
                            TranslationCategoryValue = "_generic"
                        },
                        new
                        {
                            ID = 28,
                            LanguageCode = "EN",
                            Text = "Go back to Homepage",
                            TokenValue = "#(goBackToHome)",
                            TranslationCategoryValue = "_generic"
                        },
                        new
                        {
                            ID = 29,
                            LanguageCode = "EN",
                            Text = "Click at the button to return to homepage.",
                            TokenValue = "#(goBackToHomeToolTip)",
                            TranslationCategoryValue = "_generic"
                        },
                        new
                        {
                            ID = 30,
                            LanguageCode = "EN",
                            Text = "View details",
                            TokenValue = "#(cardDetails)",
                            TranslationCategoryValue = "_generic"
                        },
                        new
                        {
                            ID = 31,
                            LanguageCode = "EN",
                            Text = "Edit",
                            TokenValue = "#(edit)",
                            TranslationCategoryValue = "_tableText"
                        },
                        new
                        {
                            ID = 32,
                            LanguageCode = "EN",
                            Text = "Remove",
                            TokenValue = "#(remove)",
                            TranslationCategoryValue = "_tableText"
                        },
                        new
                        {
                            ID = 33,
                            LanguageCode = "EN",
                            Text = "Component Test Page",
                            TokenValue = "#(TestPage Title)",
                            TranslationCategoryValue = "_TestPage"
                        },
                        new
                        {
                            ID = 34,
                            LanguageCode = "EN",
                            Text = "January",
                            TokenValue = "#(January)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 35,
                            LanguageCode = "EN",
                            Text = "February",
                            TokenValue = "#(February)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 36,
                            LanguageCode = "EN",
                            Text = "March",
                            TokenValue = "#(March)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 37,
                            LanguageCode = "EN",
                            Text = "April",
                            TokenValue = "#(April)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 38,
                            LanguageCode = "EN",
                            Text = "May",
                            TokenValue = "#(May)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 39,
                            LanguageCode = "EN",
                            Text = "June",
                            TokenValue = "#(June)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 40,
                            LanguageCode = "EN",
                            Text = "July",
                            TokenValue = "#(July)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 41,
                            LanguageCode = "EN",
                            Text = "August",
                            TokenValue = "#(August)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 42,
                            LanguageCode = "EN",
                            Text = "September",
                            TokenValue = "#(September)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 43,
                            LanguageCode = "EN",
                            Text = "October",
                            TokenValue = "#(October)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 44,
                            LanguageCode = "EN",
                            Text = "November",
                            TokenValue = "#(November)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 45,
                            LanguageCode = "EN",
                            Text = "December",
                            TokenValue = "#(December)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 46,
                            LanguageCode = "EN",
                            Text = "Mon",
                            TokenValue = "#(Mon)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 47,
                            LanguageCode = "EN",
                            Text = "Tue",
                            TokenValue = "#(Tue)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 48,
                            LanguageCode = "EN",
                            Text = "Wed",
                            TokenValue = "#(Wed)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 49,
                            LanguageCode = "EN",
                            Text = "Thu",
                            TokenValue = "#(Thu)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 50,
                            LanguageCode = "EN",
                            Text = "Fri",
                            TokenValue = "#(Fri)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 51,
                            LanguageCode = "EN",
                            Text = "Sat",
                            TokenValue = "#(Sat)",
                            TranslationCategoryValue = "_datePicker"
                        },
                        new
                        {
                            ID = 52,
                            LanguageCode = "EN",
                            Text = "Sun",
                            TokenValue = "#(Sun)",
                            TranslationCategoryValue = "_datePicker"
                        });
                });

            modelBuilder.Entity("KRFHomepage.Domain.Database.Translations.TranslationCategory", b =>
                {
                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Value");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Value = "_generic"
                        },
                        new
                        {
                            Value = "_tableText"
                        },
                        new
                        {
                            Value = "_TestPage"
                        },
                        new
                        {
                            Value = "_datePicker"
                        });
                });

            modelBuilder.Entity("KRFHomepage.Domain.Database.Homepage.HomePageData", b =>
                {
                    b.HasOne("KRFHomepage.Domain.Database.Common.Language", "Language")
                        .WithOne("HomePageData")
                        .HasForeignKey("KRFHomepage.Domain.Database.Homepage.HomePageData", "LanguageCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KRFHomepage.Domain.Database.Translations.Translation", b =>
                {
                    b.HasOne("KRFHomepage.Domain.Database.Common.Language", "Language")
                        .WithMany("Translations")
                        .HasForeignKey("LanguageCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KRFHomepage.Domain.Database.Translations.Token", "Token")
                        .WithMany("Translations")
                        .HasForeignKey("TokenValue")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KRFHomepage.Domain.Database.Translations.TranslationCategory", "TranslationCategory")
                        .WithMany("Translations")
                        .HasForeignKey("TranslationCategoryValue")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
