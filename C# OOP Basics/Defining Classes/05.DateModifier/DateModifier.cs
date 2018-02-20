using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;


public class DateModifier
{
    public double GetTheDifference(string date1, string date2)
    {
        var firstDate = DateTime.Parse(date1);
        var secondDate = DateTime.Parse(date2);
        return Math.Abs((firstDate - secondDate).TotalDays);
    }
}

