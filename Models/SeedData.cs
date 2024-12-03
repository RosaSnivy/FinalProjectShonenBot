using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace final.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if(context.Animes.Any())
        {
            return;
        }

        Anime animeOne = new()
        {
            AnimeName = "Black Clover"
        };
        Anime animeTwo = new()
        {
            AnimeName = "Jujutsu Kaisen"
        };
        Anime animeThree = new()
        {
            AnimeName = "Dragon Ball"
        };
        Anime animeFour = new()
        {
            AnimeName = "Demon Slayer"
        };
        Anime animeFive = new()
        {
            AnimeName = "One Piece"
        };
        Anime animeSix = new()
        {
            AnimeName = "Naruto"
        };
        Anime animeSeven = new()
        {
            AnimeName = "Seven Deadly Sins"
        };
        Anime animeEight = new()
        {
            AnimeName = "Hunter x Hunter"
        };
        Anime animeNine = new()
        {
            AnimeName = "Fairy Tail"
        };
        Anime animeTen = new()
        {
            AnimeName = "Bleach"
        };

        animeOne.Characters = new List<Character>() {
            new Character {
                CharacterName = "Sekke Bronzazza",
                HP = 1350,
                Strength = 23,
                Durability = 23,
                CharImageURL = "img/Sekke.jpg",
            },
            new Character {
                CharacterName = "Revchi Salik",
                HP = 1125,
                Strength = 90,
                Durability = 68,
                CharImageURL = "img/Revchi.jpg",
            },
            new Character {
                CharacterName = "Langris Vaude",
                HP = 1913,
                Strength = 45,
                Durability = 35,
                CharImageURL = "img/Langris.jpg",
            },
            new Character {
                CharacterName = "Alecdora Sandler",
                HP = 2475,
                Strength = 135,
                Durability = 90,
                CharImageURL = "img/Alecdora.jpg",
            },
            new Character {
                CharacterName = "Klaus Lunettes",
                HP = 3150,
                Strength = 125,
                Durability = 147,
                CharImageURL = "img/Klaus.jpg",
            },
            new Character {
                CharacterName = "Sol Marron",
                HP = 3713,
                Strength = 80,
                Durability = 225,
                CharImageURL = "img/Sol.jpg",
            },
            new Character {
                CharacterName = "Gordon Agrippa",
                HP = 4050,
                Strength = 180,
                Durability = 180,
                CharImageURL = "img/Gordon.jpg",
            },
            new Character {
                CharacterName = "Leopold Vermillion",
                HP = 4500,
                Strength = 495,
                Durability = 225,
                CharImageURL = "img/Leopold.jpg",
            },
            new Character {
                CharacterName = "Mars",
                HP = 9938,
                Strength = 433,
                Durability = 450,
                CharImageURL = "img/Mars.jpg",
            }
        };
        animeTwo.Characters = new List<Character>() {
            new Character {
                CharacterName = "Megumi Fushiguro",
                HP = 788,
                Strength = 57,
                Durability = 45,
                CharImageURL = "img/Megumi.jpg",
            },
            new Character {
                CharacterName = "Toji Fushiguro",
                HP = 10935,
                Strength = 608,
                Durability = 304,
                CharImageURL = "img/Toji.jpg",
            },
            new Character {
                CharacterName = "Toge Inumaki",
                HP = 6938,
                Strength = 560,
                Durability = 248,
                CharImageURL = "img/Toge.jpg",
            },
            new Character {
                CharacterName = "Panda",
                HP = 12000,
                Strength = 861,
                Durability = 696,
                CharImageURL = "img/Panda.jpg",
            },
            new Character {
                CharacterName = "Maki Zen'in",
                HP = 14550,
                Strength = 1200,
                Durability = 1021,
                CharImageURL = "img/Maki.jpg",
            }
        };
        animeThree.Characters = new List<Character>() {
            new Character {
                CharacterName = "Tien Shinhan",
                HP = 450,
                Strength = 35,
                Durability = 12,
                CharImageURL = "img/Tien.jpg",
            },
            new Character {
                CharacterName = "Captain Ginyu",
                HP = 675,
                Strength = 95,
                Durability = 63,
                CharImageURL = "img/Ginyu.jpg",
            },
            new Character {
                CharacterName = "Frieza",
                HP = 5655,
                Strength = 255,
                Durability = 351,
                CharImageURL = "img/Frieza.jpg",
            },
            new Character {
                CharacterName = "Gohan",
                HP = 5400,
                Strength = 272,
                Durability = 272,
                CharImageURL = "img/Gohan.jpg",
            },
            new Character {
                CharacterName = "Goku Black",
                HP = 25322,
                Strength = 1693,
                Durability = 979,
                CharImageURL = "img/GokuBlack.jpg",
            },
            new Character {
                CharacterName = "Cell",
                HP = 8363,
                Strength = 375,
                Durability = 328,
                CharImageURL = "img/Cell.jpg",
            },
            new Character {
                CharacterName = "Zamasu",
                HP = 7125,
                Strength = 375,
                Durability = 863,
                CharImageURL = "img/Zamasu.jpg",
            },
            new Character {
                CharacterName = "Majin Buu",
                HP = 30870,
                Strength = 805,
                Durability = 613,
                CharImageURL = "img/Buu.jpg",
            }
        };
        animeFour.Characters = new List<Character>() {
            new Character {
                CharacterName = "Inosuke Hashibira",
                HP = 990,
                Strength = 77,
                Durability = 5,
                CharImageURL = "img/Inosuke.jpg",
            },
            new Character {
                CharacterName = "Kyogai",
                HP = 945,
                Strength = 66,
                Durability = 66,
                CharImageURL = "img/Kyogai.jpg",
            },
            new Character {
                CharacterName = "Sabito",
                HP = 1350,
                Strength = 125,
                Durability = 57,
                CharImageURL = "img/Sabito.jpg",
            },
            new Character {
                CharacterName = "Kamanue",
                HP = 2025,
                Strength = 135,
                Durability = 68,
                CharImageURL = "img/Kamanue.jpg",
            },
            new Character {
                CharacterName = "Rui",
                HP = 2700,
                Strength = 135,
                Durability = 180,
                CharImageURL = "img/Rui.jpg",
            },
            new Character {
                CharacterName = "Kyojuro Rengoku",
                HP = 16089,
                Strength = 879,
                Durability = 442,
                CharImageURL = "img/Rengoku.jpg",
            },
            new Character {
                CharacterName = "Shinobu Kocho",
                HP = 21645,
                Strength = 1534,
                Durability = 1170,
                CharImageURL = "img/Shinobu.jpg",
            },
            new Character {
                CharacterName = "Giyu Tomioka",
                HP = 24570,
                Strength = 1599,
                Durability = 1594,
                CharImageURL = "img/Giyu.jpg",
            }
        };
        animeFive.Characters = new List<Character>() {
            new Character {
                CharacterName = "Koby",
                HP = 383,
                Strength = 23,
                Durability = 30,
                CharImageURL = "img/Koby.jpg",
            },
            new Character {
                CharacterName = "Portgas D. Ace",
                HP = 6901,
                Strength = 552,
                Durability = 80,
                CharImageURL = "img/Ace.jpg",
            },
            new Character {
                CharacterName = "Sabo",
                HP = 19200,
                Strength = 1357,
                Durability = 684,
                CharImageURL = "img/Sabo.jpg",
            }
        };
        animeSix.Characters = new List<Character>() {
            new Character {
                CharacterName = "Konohamaru Sarutobi",
                HP = 338,
                Strength = 30,
                Durability = 27,
                CharImageURL = "img/Konohamaru.jpg",
            },
            new Character {
                CharacterName = "Shukaku",
                HP = 2183,
                Strength = 50,
                Durability = 116,
                CharImageURL = "img/Shukaku.jpg",
            },
            new Character {
                CharacterName = "Kakashi Hatake",
                HP = 7509,
                Strength = 559,
                Durability = 450,
                CharImageURL = "img/Kakashi.jpg",
            },
            new Character {
                CharacterName = "Matatabi",
                HP = 2408,
                Strength = 179,
                Durability = 167,
                CharImageURL = "img/Matatabi.jpg",
            },
            new Character {
                CharacterName = "Obito Uchiha",
                HP = 14701,
                Strength = 901,
                Durability = 391,
                CharImageURL = "img/Obito.jpg",
            }
        };
        animeSeven.Characters = new List<Character>() {
            new Character {
                CharacterName = "Gilthunder",
                HP = 360,
                Strength = 27,
                Durability = 27,
                CharImageURL = "img/Gilthunder.jpg",
            },
            new Character {
                CharacterName = "Escanor",
                HP = 10707,
                Strength = 1453,
                Durability = 1092,
                CharImageURL = "img/Escanor.jpg",
            },
            new Character {
                CharacterName = "Zeldris",
                HP = 5813,
                Strength = 413,
                Durability = 207,
                CharImageURL = "img/Zeldris.jpg",
            }
        };
        animeEight.Characters = new List<Character>() {
            new Character {
                CharacterName = "Leorio Paradinight",
                HP = 428,
                Strength = 27,
                Durability = 21,
                CharImageURL = "img/Leorio.jpg",
            },
            new Character {
                CharacterName = "Biscuit Krueger",
                HP = 5288,
                Strength = 315,
                Durability = 338,
                CharImageURL = "img/Biscuit.jpg",
            }
        };
        animeNine.Characters = new List<Character>() {
            new Character {
                CharacterName = "Laxus Dreyar",
                HP = 3150,
                Strength = 248,
                Durability = 113,
                CharImageURL = "img/Laxus.jpg",
            },
            new Character {
                CharacterName = "Mirajane Strauss",
                HP = 30152,
                Strength = 1848,
                Durability = 1080,
                CharImageURL = "img/Mirajane.jpg",
            }
        };
        animeTen.Characters = new List<Character>() {
            new Character {
                CharacterName = "Momo Hinamori",
                HP = 675,
                Strength = 21,
                Durability = 3,
                CharImageURL = "img/Momo.jpg",
            },
            new Character {
                CharacterName = "Grimmjow Jaegerjaquez",
                HP = 5701,
                Strength = 1261,
                Durability = 840,
                CharImageURL = "img/Grimmjow.jpg",
            },
            new Character {
                CharacterName = "Ulquiorra Cifer",
                HP = 25350,
                Strength = 684,
                Durability = 1464,
                CharImageURL = "img/Ulquiorra.jpg",
            },
            new Character {
                CharacterName = "Coyote Starrk",
                HP = 16200,
                Strength = 1021,
                Durability = 600,
                CharImageURL = "img/Starrk.jpg",
            }
        };

        context.Add(animeOne);
        context.Add(animeTwo);
        context.Add(animeThree);
        context.Add(animeFour);
        context.Add(animeFive);
        context.Add(animeSix);
        context.Add(animeSeven);
        context.Add(animeEight);
        context.Add(animeNine);
        context.Add(animeTen);

        context.SaveChanges();
    }
}