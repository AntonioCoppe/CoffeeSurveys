using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {

            var task = new List<string>();

            // Calculated Values
            double  responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.PriceScore + Q1Results.FoodScore) / 4;

            if (Q1Results.CoffeeScore < Q1Results.FoodScore)
            {
                task.Add("Investigate why coffee score is lower than food score.");
            }
            if (overallScore > 8.0)
            {
                task.Add("Work with leadership to understand what is driving the high overall score.");
            }
            else
            {
                task.Add("Work with employees to improve overall score.");
            }

            if(responseRate < .33)
            {
                task.Add("Reserch options for improving response rate.");
            }
            else if (responseRate > .33 && responseRate < .66)
            {
                task.Add("Reward partecipant with a discount coupon.");
            }
            else
            {
                task.Add("Reward partecipant with a free coffee.");
            }

        }
    }
}
