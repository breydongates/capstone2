﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Namespaces");

            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.
            
            // Creating lists of integers
            List<int> yearsLived = new List<int>(); //list of integers. can only store integers. this is how you create a new list

            // Creating lists of strings
            List<string> movies = new List<string>(); // can take only strings, such as movies
            List<string> favoriteMovies = new List<string>();
            List<string> otherMovies = movies;
            /////////////////

            // Discuss namespaces & using statements

            //////////////////
            // OBJECT EQUALITY
            //////////////////

            movies.Add("Hook");
            favoriteMovies.Add("Hook");
            // Check reference equality
            bool areMoviesEqual = movies == favoriteMovies;
            Console.WriteLine("Movies are equal == " + areMoviesEqual);
            // Compare two variables pointed at the same list
            
            if (otherMovies == movies)
            {
                Console.WriteLine("They be the same movies");
            }
            /////////////////
            // ADDING ITEMS
            /////////////////

            // Adding items one at a time to each list
            yearsLived.Add(2019);
            yearsLived.Add(2020);
            yearsLived.Add(2004);
            yearsLived.Insert(0, 1980); // will add 1980 at the beginning 

            // Console.WriteLine(yearsLived.Count); // .Count is the same thing as .Length


            movies.Add("Sneakers");
            movies.Add("War Games");
            //movies.Add("1984"); //this has to be in quotes, (1984) would come out as an integer. movies only takes strings

            // ADDING MULTIPLE ITEMS
            int[] years = { 1990, 1991, 1992, 1993, 1994 };
            yearsLived.AddRange(years);
            Console.WriteLine(yearsLived.Count);
            // LIST INITIALIZER
            List<string> colors = new List<string>()
            {
                "Steel Blue",
                "Beige",
                "Transparent",
                "Dark Clear"
            };


            Console.WriteLine(yearsLived.Count);

            //////////////////
            // ACCESSING BY INDEX
            //////////////////

            string someMovie = movies[1];

            movies[0] = "The Sound of Music";

            Console.WriteLine(someMovie);

            Console.WriteLine(movies);
            for (int i =0; i <movies.Count; i++)
            {
                string m = movies[i];
                Console.WriteLine(m);
            }
            ///////////////////
            // ACCESSING WITH FOREACH
            ///////////////////
            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
                // movie.Add("Good Morning Vietnam"); cant add a string while for each is looping
            }

            List<int> evenYears = new List<int>();
            foreach (int year in yearsLived)
            {
                if (year %2 ==0)
                {
                    evenYears.Add(year);
                }
            }

            foreach (int year in evenYears )
            {
                Console.WriteLine(year);
            }
            ////////////////////
            // ADDITIONAL LIST<T> METHODS
            ////////////////////

            // Contains
            Console.WriteLine("Is Sneakers present? " + movies.Contains("Sneakers"));
            // IndexOf
            int index = movies.IndexOf("Sneakers");
            Console.WriteLine("Index of movie = " + movies.IndexOf("Sneakers"));
            Console.WriteLine("Index of movie = " + movies.IndexOf("Hot Shots"));
            // Insert
            movies.Insert(index, "Serenity");
            // Remove
            movies.Remove("The Sound of Music");
            // List to Array
            string[] moviesArray = movies.ToArray();
            movies.Add("Cats"); //any additions after above will not show in array
            // Array to List
            int[] favoriteNumbers = { 7, 13, 11, 42 };
            List<int> numbersList = favoriteNumbers.ToList();
            ////////////////////////
            // SORT / REVERSE
            ////////////////////////
            ///
            yearsLived.Sort(); 

            foreach(int year in yearsLived)
            {
                Console.WriteLine(year);
            }

            movies.Sort(); // ALPHABETICAL ORDER
            movies.Reverse(); // reverse alphabetical. takes code in order & reverses. would have to sort first in order to reverse

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }


            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.

            Queue<string> episodesToWatch = new Queue<string>();

            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////

            // Enqueue
            episodesToWatch.Enqueue("The one where he gets a compiler error");
            episodesToWatch.Enqueue("The one where they ship the fix");
            episodesToWatch.Enqueue("The one where they delete all the user's data");
            Console.WriteLine(episodesToWatch.Count);
            // Loop through and Dequeue
            while (episodesToWatch.Count > 0)
            {
                string nextEpisode = episodesToWatch.Dequeue();
                Console.WriteLine("Up next is " + nextEpisode);
            }
            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 
            Stack<string> books = new Stack<string>();

            ////////////////////
            // PUSHING ITEMS TO THE STACK
            //////////////////// 

            books.Push("Eloquent JavaScript");
            books.Push("Cracking the Coding Interview");
            books.Push("Intro to Phaser.js");

            Console.WriteLine(books.Count);

            ////////////////////
            // POPPING THE STACK
            ////////////////////

            ////////////////////
            // SWITCH STATEMENTS
            ////////////////////
            ///
            bool timeForSwitchStatements = false;

            if (timeForSwitchStatements)
            {
                Console.WriteLine();

                string favoriteLanguage = "C#";

                switch (favoriteLanguage)
                {
                    case "C#":
                        Console.WriteLine("I love C#!");
                        break;

                    case "Java":
                        Console.WriteLine("Java is definitely a programming language");
                        break;

                    case "JavaScript":
                        Console.WriteLine("JavaScript is to Java as Carpet is to Car");
                        break;

                    default:
                        Console.WriteLine($"I don't have much to say about {favoriteLanguage}");
                        break;
                }

                // This is equivalent to the code below:
                if (favoriteLanguage == "C#")
                {
                    Console.WriteLine("I love C#!");
                }
                else if (favoriteLanguage == "Java")
                {
                    Console.WriteLine("Java is definitely a programming language");
                }
                else if (favoriteLanguage == "JavaScript")
                {
                    Console.WriteLine("JavaScript is to Java as Carpet is to Car");
                }
                else
                {
                    Console.WriteLine($"I don't have much to say about {favoriteLanguage}");
                }
            }

            Console.ReadLine();
        }
    }
}
