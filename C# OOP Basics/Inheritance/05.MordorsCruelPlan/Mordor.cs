using System;
using System.Collections.Generic;

public class Mordor
{
    private int HappinessPoints { get; set; }

    public Mood GetMordorsMood()
    {
        return MoodFactory.GetMood(this.HappinessPoints);
    }

    internal void Eat(List<Food> foods)
    {
        foreach (var food in foods)
        {
            this.HappinessPoints += food.PointsOfHappiness;
        }
    }

    public override string ToString()
    {
        var mondorsMood = this.GetMordorsMood();

        return $"{this.HappinessPoints}{Environment.NewLine}{mondorsMood.GetType().Name}";
    }
}