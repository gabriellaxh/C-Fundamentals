using BashSoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleJudge
{
    public class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter, int studentsToTake)
        {
            if(wantedFilter == "excellent")
            {
                FilterAndTake(wantedData, x => x >= 5, studentsToTake);
            }
            else if(wantedFilter == "average")
            {
                FilterAndTake(wantedData, x => x < 5 && x >= 3.5, studentsToTake);
            }
            else if(wantedFilter == "poor")
            {
                FilterAndTake(wantedData, x => x < 3.5, studentsToTake);
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidStudentFilter);
            }
        }

        private static void FilterAndTake(Dictionary<string, List<int>> wantedData, Predicate<double> givenFilter, int studentsToTake)
        {
            int counterForPrinted = 0;
            foreach (var username in wantedData)
            {
                if(counterForPrinted == studentsToTake)
                {
                    break;
                }
                double averageScore = username.Value.Average();
                double percentageOfFullfilment = averageScore / 100;
                double mark = percentageOfFullfilment * 4 + 2;

                if (givenFilter(mark))
                {
                    OutputWriter.PrintStudent(username);
                    counterForPrinted++;
                }
            }
        }

        private static double Average(List<int> scoresOnTask)
        {
            int totalScore = 0;
            foreach (var score in scoresOnTask)
            {
                totalScore += score;
            }
            var percentageOfAll = totalScore / (scoresOnTask.Count * 100);
            var mark = percentageOfAll * 4 + 2;

            return mark;
        }
    }
}
