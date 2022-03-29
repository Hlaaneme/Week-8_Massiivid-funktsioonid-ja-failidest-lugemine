﻿using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DispalyRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DispalyRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");

        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Top Gun", "The Batman", "Breaking Bad", "Joker" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovie}");
        }

    }
}