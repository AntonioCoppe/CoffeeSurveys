using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculated Values
            double  responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.PriceScore + Q1Results.FoodScore) / 4;

            Console.WriteLine($"Reseponse Percentage: {responseRate}");
            Console.WriteLine($"UnansweredCount Surveys: {unansweredCount}");
            Console.WriteLine($"Overall Score: {overallScore}");

            // Conditional Statements
            bool higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool customerRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappuccino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappuccino";

            // Display the results
            Console.WriteLine($"Higher Coffee Score: {higherCoffeeScore}");
            Console.WriteLine($"Customer Recommend: {customerRecommend}");
            Console.WriteLine($"Hate Granola Love Cappuccino: {noGranolaYesCappuccino}");            

        }
    }
}
