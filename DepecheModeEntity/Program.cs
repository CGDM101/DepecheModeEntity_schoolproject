using DepecheModeEntity.Database; // För att kunna använda SongContext
using System;
using DepecheModeEntity.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DepecheModeEntity.Database;

namespace DepecheModeEntity
{
    /*
     Du ska skriva ett projekt där du använder C# och SQL, EF, eller MongoDB.
    Den ska ha minst två modeller som samarbetar.
    Oavsett typ av databas ska du använda en CRUD-klass.
    Datan ska presenteras på skärmen på något sätt.

    G:
    Programmet ska vara körbart.
    Datanbasens namngivning ska vara dina initialer och projektnamn,
    Programmet ska skapa databasen och tabellerna.
    Programmet ska lägga in standarddata i databasen vid första körningen.
     */

    /*
     Anteckningsbok i Winforms som sparar dina anteckningar och sorterar dem i kategorier
Lista på vilka som fortfarande skickar julkort så du vet vilka som ska ha nästa år
Julklappslista, vem gav vad till vem och vad ska denne ha? Godis, kläder, prylar, kol?
Kodanteckningsbok som sparar dina bästa metoder och funktioner och sorterar dem i kategorier
Spel som håller reda på frågor och
svar, spelarna identifierar sig med namn och får tio frågor. Poäng räknas på
antal rätt svar. En admin ska kunna lägga till, ändra eller ta bort frågor.
Dagbok 
Inköpslista som sorterar enligt butik (på H&M köp strumpor, på Lindex köp julklapp, på Hemsk-köp handla mjölk)
Pokedex
CV Generator, du matar in alla jobb/utbildningar och  den genererar olika dokument (txt går bra) beroende på vilket jobb du söker
Veckoplanering (lektioner, tv-serier, träning mm)
     */

    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (var context = new SongContext())
            {
                context.Database.EnsureDeleted();
            }
            Console.WriteLine("raderad"); // För att ta bort databasen om det behövs.
            */

            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("MENY! Välj vad du vill göra!");
            Console.WriteLine("(Välj 1, 2, 3, 4 eller q! Inget annat eftersom programmeraren inte löst felhanteringen!)");
            Console.WriteLine("1. Lägg till låt!");
            Console.WriteLine("2. Hitta sång!");
            Console.WriteLine("3. Ändra sång!");
            Console.WriteLine("4. Ta bort sång!");
            Console.WriteLine("5. Se alla album!");
            Console.WriteLine("6. Se alla låtar som finns inlagda i databasen just nu!");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("7. Spela ett spel!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("q. Avsluta!");
            string input = Console.ReadLine().Trim().ToLower();
            switch (input)
            {
                case "1":
                    CreateSong();
                    break;
                case "2":
                    ReadSong();
                    break;
                case "3":
                    UpdateSong();
                    break;
                case "4":
                    DeleteSong();
                    break;
                case "5":
                    ReadAllAlbums();
                    break;
                case "6":
                    ReadAll();
                    break;
                case "7":
                    Play();
                    break;
                case "q":
                    break;
                default:
                    Console.WriteLine("Fel input.");
                    Menu();
                    break;
            }
        }

        private static void Play()
        {
            Console.Clear();
            Console.WriteLine("Välkommen! Du ska få se ett låtnamn, och gissa vilket album låten tillhör!");
            string str = " (Om du vill sluta spelet och återgå till menyn - tryck 101!)";
            int counter = 0;
            bool done = false;
            while (!done)
            {
                using (var context = new SongContext())
                {
                    Random random = new Random();
                    var all = context.Songs.ToList();
                    int randomisedNumber = random.Next(1, all.Count);

                    switch (randomisedNumber)
                    {
                        case 1: // ets - 7
                            var find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            int input = int.Parse(Console.ReadLine()); // TODO: felhantering input
                            if (input == 7)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 7)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 2: // boag - 9
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 9)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 9)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 3: // ltm - 4
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 4)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 4)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 4: // angel - 13
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 13)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 13)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 5: // bc - 5
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 5)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 5)
                            {
                                ChangeColourWhenWrong();

                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 6: // idm - 4
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 4)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 4)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 7: // son - 9
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 9)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 9)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 8: // sc - 10
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 10)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 10)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 9: // bnt - 5
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 5)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 5)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 10: // nothing - 6
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 6)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 6)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 11: // ec - 3
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 3)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 3)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 12: // sy - 2
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 2)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 2)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 13: // photographic - 1
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 1)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 1)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 14: // ni - 11
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 11)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 11)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        case 15: // rush - 8
                            find = context.Songs.FirstOrDefault(x => x.Id == randomisedNumber);
                            Console.WriteLine("Vilket album tillhör " + find.Name + "?" + str);
                            ReadAllAlbums();
                            input = int.Parse(Console.ReadLine());
                            if (input == 8)
                            {
                                counter++; Console.WriteLine("Grattis!" + " Du har " + counter + " poäng.");
                            }
                            else if (input == 101)
                            {
                                done = true;
                                Menu();
                            }
                            else if (input != 8)
                            {
                                ChangeColourWhenWrong();
                                Console.WriteLine(". Fortfarande " + counter + " poäng.");
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        private static void ChangeColourWhenWrong()
        {
            Console.Write("Fasen också, det var ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("fel");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ReadAll()
        {
            using (var db = new SongContext())
            {
                var allSongsOrderedById = db.Songs.ToList();
                Console.WriteLine();
                Console.WriteLine("Här är alla sånger i databasen:");
                foreach (var item in allSongsOrderedById)
                {
                    Console.WriteLine(item.Id + ". " + item.Name);
                }
            }
            Menu();
        }

        private static void ReadSong()
        {
            MenuWhatToSortOn();
        }

        private static void MenuWhatToSortOn()
        {
            Console.WriteLine("Vill du sortera efter? \n1) Alla som börjar på viss bokstav? \n2) Alla från ett visst album? \n3) Se alla som har musikvideo? \nq) Avsluta och återgå till huvudmenyn? ");
            string input = Console.ReadLine().Trim().ToLower();
            switch (input)
            {
                case "1":
                    SortOnBeginningLetter();
                    break;
                case "2":
                    SortOnAlbum();
                    break;
                case "3":
                    ShowAllWithMusicVideo();
                    break;
                case "q":
                    Menu();
                    break;
                default:
                    Console.WriteLine("Något gick fel.");
                    break;
            }
            Menu(); // Återgå till meny efter varje metod.
        }

        private static void ShowAllWithMusicVideo()
        {
            using (var context = new SongContext())
            {
                var result = context.Songs.Where(q => q.MusicVideo == true);
                if (result.Count() != 0)
                {
                    Console.WriteLine("Låtar med musikvideo:");
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
                else Console.WriteLine("Fanns inga med musikvideo.");
            }
        }

        private static void SortOnAlbum()
        {
            Console.WriteLine("Vilket album vill du sortera på? Välj ID i listan nedan!");
            ReadAllAlbums();
            int input = int.Parse(Console.ReadLine().Trim());

            switch (input)
            {
                case 1:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 1);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 2:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 2);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 3:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 3);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;

                case 4:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 4);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                default:
                    break;
                case 5:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 5);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 6:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 6);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 7:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 7);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 8:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 8);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 9:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 9);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 10:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 10);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 11:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 11);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 12:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 12);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 13:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 13);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
                case 14:
                    using (var context = new SongContext())
                    {
                        var res = context.Songs.Where(a => a.AlbumId == 14);
                        Console.WriteLine("Alla låtar från detta album:");
                        foreach (var item in res)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                    break;
            }
        }

        private static void SortOnBeginningLetter()
        {
            Console.Write("Vilken begynnelsebokstav är du intresserad av? ");
            string input = Console.ReadLine().Trim().ToLower();
            string firstLetter = input.Substring(0, 1); // Ifall de råkar skriva t ex 'aa' i st f 'a'
            string alphabet = "abcdefghijklmnopqrstuvxyz";
            if (alphabet.Contains(firstLetter))
            {
                using (var context = new SongContext())
                {
                    var result = context.Songs.Where(z => z.Name.StartsWith(firstLetter)); // substring?
                    Console.WriteLine();
                    Console.WriteLine("Låt/-ar med denna begynnelsebokstav:");
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Finns ingen låt med den begynnelsebokstaven!");
            }
        }

        private static void DeleteSong()
        {
            Console.Write("Id på den sång du vill radera: ");
            int input = int.Parse(Console.ReadLine());
            using (var db = new SongContext())
            {
                try
                {
                    var songToBeDeleted = db.Songs.FirstOrDefault(s => s.Id == input);
                    db.Remove(songToBeDeleted);
                    db.SaveChanges();

                    Console.WriteLine("Sång raderad.");
                    Menu(); // För att programmet inte ska stoppa.
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Välj ett id som faktiskt finns i listan! Se listan:");
                    ReadAll();
                    Console.WriteLine();
                    Console.WriteLine("Välj vad du vill göra!");
                    Menu();
                }
            }
        }

        private static void UpdateSong()
        {
            Console.Write("Id på den sång du vill ändra på: ");
            int input = int.Parse(Console.ReadLine());
            using (var dbContext = new SongContext())
            {
                var all = dbContext.Songs.ToList();
                var songToUpdate = dbContext.Songs.FirstOrDefault(q => q.Id == input);
                if (input > all.Count || input <= 0)
                {
                    Console.WriteLine("Skriv ett ID som faktiskt finns!");
                    UpdateSong();
                }
                else
                {
                    Console.Write("Vad vill du ändra på? 1. Namn på sången 2. Album sången tillhör 3. Musikvideoförekomst q. Avsluta och återgå till menyn. ");
                    string input2 = Console.ReadLine().Trim().ToLower();
                    switch (input2)
                    {
                        case "1":
                            //Console.Write("Nytt namn: ");
                            //string newName = Console.ReadLine().Trim();
                            //songToUpdate.Name = newName;
                            songToUpdate = ChangeSongName(songToUpdate); // ooa
                            break;
                        case "2":
                            songToUpdate = ChangeAlbumSongBelongsTo(songToUpdate);
                            break;
                        case "3":
                            songToUpdate = ChangeMusicVideoExistence(songToUpdate);
                            break;
                        case "q":
                            break;
                        default:
                            Console.WriteLine("Något gick fel. Skriv ett giltigt val!");
                            break;
                    }
                    dbContext.SaveChanges();
                }
            }
            Menu();
        }

        private static DepecheModeSong ChangeMusicVideoExistence(DepecheModeSong song)
        {
            Console.Write("Musikvideo - y / n: ");
            string musicVideoQuestion = Console.ReadLine().Trim().ToLower();
            if (musicVideoQuestion == "y") song.MusicVideo = true;
            if (musicVideoQuestion == "n") song.MusicVideo = false;
            Console.WriteLine("Informationen är uppdaterad.");
            return song;
        }

        private static DepecheModeSong ChangeAlbumSongBelongsTo(DepecheModeSong song)
        {
            Console.WriteLine("Välj album - se ID på listan nedan!");
            ReadAllAlbums();
            int newAlbumSongBelongsTo = int.Parse(Console.ReadLine().Trim());
            song.AlbumId = newAlbumSongBelongsTo;
            Console.WriteLine("Informationen är uppdaterad.");
            return song;
        }

        public static void ReadAllAlbums()
        {
            using (var db = new SongContext())
            {
                var albums = db.Albums.ToList();
                Console.WriteLine();
                Console.WriteLine("Här är alla album: ");
                foreach (var item in albums)
                {
                    Console.WriteLine(item.Id + ". " + item.Name);
                }
            }
            //Menu(); 
            // TODO: deNna är borttagen för att CreateSong() ska funka...
        }

        private static DepecheModeSong ChangeSongName(DepecheModeSong song)
        {
            Console.Write("Nytt namn: ");
            string newName = Console.ReadLine().Trim();
            song.Name = newName;
            Console.WriteLine("Informationen är uppdaterad.");
            return song;
        }

        public static void CreateSong()
        {
            Console.Write("Skriv låtnamn: ");
            string userInputName = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("Skriv album den tillhör - se ID på listan nedan!");
            ReadAllAlbums();
            int userInputAlbum = int.Parse(Console.ReadLine().Trim().ToLower()); // TODO: Här hoppar det till MENU() och "något gick fel" pga att Menu() står sist i ReadAll()!!!
            Console.Write("Har den musikvideo? y/n: ");
            string userInputVideo = Console.ReadLine().Trim().ToLower();
            bool answerVideo = false;
            switch (userInputVideo)
            {
                case "y":
                    answerVideo = true;
                    break;
                case "n":
                    answerVideo = false;
                    break;
                default:
                    Console.WriteLine("Ogiltig input. Input blir null."); // Skriv \"y\" eller \"n\"!");
                    break;
            }

            using (var db = new SongContext())
            {
                db.Songs.Add(new DepecheModeSong
                {
                    Name = userInputName,
                    AlbumId = userInputAlbum,
                    MusicVideo = answerVideo,
                });

                db.SaveChanges(); // DbUpdateException: SqlException: Cannot insert explicit value for identity column in table 'Songs' when IDENTITY_INSERT is set to OFF. 
                // Felet försvann när jag tog bort Key på album i song

                //try
                //{
                //    db.SaveChanges(); // DbUpdateException: SqlException: Cannot insert explicit value for identity column in table 'Songs' when IDENTITY_INSERT is set to OFF. 
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e.Message);
                //}

                Console.WriteLine("Låt tillagd.");
                Menu();
            }
        }
    }
}
