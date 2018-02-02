using SimpleJudge;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace BashSoft
{
    public static class StudentsRepository
    {
        public static bool isDataInitialized = false;

        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;


        
        public static void OrderAndTake(string course, string comparison, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(course))
            {
                if(studentsToTake == null)
                {
                    studentsToTake = studentsByCourse[course].Count;
                }
                RepositorySorters.OrderAndTake(studentsByCourse[course], comparison, studentsToTake.Value);
            }
        }

        public static void FilterAndTake(string course,string givenFilter, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(course))
            {
                if(studentsToTake == null)
                {
                    studentsToTake = studentsByCourse[course].Count;
                }
                RepositoryFilters.FilterAndTake(studentsByCourse[course], givenFilter, studentsToTake.Value);
            }
        }

        public static void InitializeData(string fileName)
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Reading data...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData(fileName);
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitializedExceptionMessage);
            }
        }

        private static void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\" + fileName;

            string pattern = @"([A-Z][A-Za-z#+]*_[A-Z][a-z]{2}_\d{4})\s+([A-Z][a-z]{0,3}\d{2}_\d{2,4})\s+(\d+)";
            Regex rgx = new Regex(pattern);
            string[] allInputLines = File.ReadAllLines(path);

            if (File.Exists(path))
            {
                for (int line = 0; line < allInputLines.Length; line++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[line]) && rgx.IsMatch(allInputLines[line]))
                    {
                        Match currentMatch = rgx.Match(allInputLines[line]);
                        string course = currentMatch.Groups[1].Value;
                        string username = currentMatch.Groups[2].Value;
                        int studentScoreOnTask;
                        bool parsedMark = int.TryParse(currentMatch.Groups[3].Value, out studentScoreOnTask);

                        if (parsedMark && studentScoreOnTask >= 0 && studentScoreOnTask <= 100)
                        {
                            if (!studentsByCourse.ContainsKey(course))
                            {
                                studentsByCourse.Add(course, new Dictionary<string, List<int>>());
                            }

                            if (!studentsByCourse[course].ContainsKey(username))
                            {
                                studentsByCourse[course].Add(username, new List<int>());
                            }
                            studentsByCourse[course][username].Add(studentScoreOnTask);
                        }
                    }
                    else
                    {
                        OutputWriter.DisplayException(ExceptionMessages.InvalidPathExceptionMessage);
                    }
                }

            }

            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private static bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInitialized)
            {
                if (studentsByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBaseExceptionMessage);
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }
            return false;
        }

        private static bool IsQueryForStudentPossiblе(string courseName, string studentUserName)
        {
            if (isDataInitialized)
            {
                if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBaseExceptionMessage);
                }
                return false;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }
            return false;
        }

        public static void GetStudentScoresFromCourse(string courseName, string username)
        {
            if (IsQueryForStudentPossiblе(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
            }
        }

        public static void GetAllStudetsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");
                foreach (var student in studentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(student);
                }
            }
        }
    }
}
