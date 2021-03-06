﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassExercise8.Models;
using ClassExercise8.Enum;


namespace ClassExercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PhoneBook
            //Dictionary <string, int> PhoneBook = new Dictionary<string, int>
            //{ { "Florent", 6666 },
            //{"Vlatko", 1111 },
            //{"Goran", 2222 },
            //{"Dejan", 3333},
            //{"Igor", 4444} };

            //Console.WriteLine("Please enter a name: ");
            //string input = Console.ReadLine();

            //if (PhoneBook.ContainsKey(input))
            //{
            //    Console.WriteLine(PhoneBook[input]);
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, there is not a name");
            //}
            //Console.ReadLine();
            #endregion

            List<Person> FansArray = CreateFans();
            List<Song> Songs = CreateSongs();

            Person Jerry = FansArray.FirstOrDefault(fan => fan.FirstName == "Jerry");

            Jerry.FavoriteSongs = Songs.Where(song => song.Title.StartsWith("B")).ToList();

            Console.WriteLine("Jerry's favorite songs, that start with the letter \"B\" are:");

            Jerry.GetFavSongs();
            Console.WriteLine();

            Person Maria = FansArray.FirstOrDefault(fan => fan.FirstName == "Maria");

            Maria.FavoriteSongs = Songs.Where(song => song.Length > 360).ToList();

            Console.WriteLine("Maria's favorite songs, that are longer than 6 minutes are:");

            Maria.GetFavSongs();
            Console.WriteLine();

            Person Jane = FansArray.FirstOrDefault(fan => fan.FirstName == "Jane");

            Jane.FavoriteSongs = Songs.Where(song => song.Genre == Genre.Rock).ToList();

            Console.WriteLine("Jane's favorite Rock songs are:");

            Jane.GetFavSongs();
            Console.WriteLine();

            Person Stefan = FansArray.FirstOrDefault(fan => fan.FirstName == "Stefan");

            Stefan.FavoriteSongs = Songs.Where(song => song.Length < 180 && song.Genre == Genre.Hip_Hop).ToList();
            Console.WriteLine("Stefan's favorite Hip Hop songs that are shorter than 3 minutes are:");

            Stefan.GetFavSongs();
            Console.WriteLine();

            Console.WriteLine("Persons below have 4 or more favorite songs:");
            Console.WriteLine();

            foreach (var fan in FansArray)
            {
                if (fan.FavoriteSongs.Count >= 4)
                {
                    Console.WriteLine(fan.FirstName);
                }
            }

            Console.ReadLine();

        }

        public static List<Person> CreateFans()
        {
            return new List<Person>
            {
                new Person("Jerry", "Tompson", 78, Genre.Rock),
                new Person("Stefan", "Stefanoski", 28, Genre.Techno),
                new Person("Maria", "Campbel", 43, Genre.Classical),
                new Person("Jane", "Doe", 28, Genre.Techno),
            };
        }

        public static List<Song> CreateSongs()
        {
            return new List<Song>
            {
                    new Song("Bohemian Rhapsody", 367, Genre.Rock),
                    new Song("Stairway To Heaven", 480, Genre.Rock),
                    new Song("Riders On The Storm", 430, Genre.Rock),
                    new Song("Not Fade Away", 108, Genre.Rock),
                    new Song("Breaking Glass", 111, Genre.Rock),
                    new Song("Welcome To The Jungle", 275, Genre.Rock),
                    new Song("Walk Of Life", 266, Genre.Rock),
                    new Song("Smoke on the Water", 340, Genre.Rock),
                    new Song("93 'til Infinity", 209, Genre.Techno),
                    new Song("Fight the Power", 321, Genre.Techno),
                    new Song("The Message", 363, Genre.Techno),
                    new Song("Butterfly Effect", 213, Genre.Techno),
                    new Song("No Fear", 182, Genre.Techno),
                    new Song("Hereditary", 340, Genre.Techno),
                    new Song("Bounce Back", 226, Genre.Techno),
                    new Song("The Four Seasons", 2520, Genre.Classical),
                    new Song("Canon in D major", 376, Genre.Classical),
                    new Song("Swan Lake", 461, Genre.Classical),
                    new Song("Symphony No. 5", 425, Genre.Classical),
                    new Song("Ride of the Valkyries", 608, Genre.Classical),
                    new Song("The Magic Flute", 458, Genre.Classical),
                    new Song("Carmen Suite No.1", 721, Genre.Classical),
                    new Song("Planet E", 420, Genre.Techno),
                    new Song("Phasor", 368, Genre.Techno),
                    new Song("Counting Comets", 242, Genre.Techno),
                    new Song("Cold Summer", 358, Genre.Techno),
                    new Song("Destroyer", 359, Genre.Techno),
                    new Song("Phalanx", 307, Genre.Techno),
                    new Song("Vision", 693, Genre.Techno),
                    new Song("Chain Reaction", 181, Genre.Techno)
            };
        }
    }
}
