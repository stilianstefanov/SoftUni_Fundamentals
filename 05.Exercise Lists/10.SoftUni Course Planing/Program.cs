using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();
            while (command != "course start")
            {
                string[] tokens = command.Split(":");
                switch (tokens[0])
                {
                    case "Add":
                        string lessonTitleToAdd = tokens[1];
                        AddLesson(schedule, lessonTitleToAdd);
                        break;
                    case "Insert":
                        string lessonTitleToInsert = tokens[1];
                        int atIndex = int.Parse(tokens[2]);
                        InsertLesson(schedule, lessonTitleToInsert, atIndex);
                        break;
                    case "Remove":
                        string lessonTitleToRemove = tokens[1];
                        RemoveLesson(schedule, lessonTitleToRemove);
                        break;
                    case "Swap":
                        string lessonTitleToSwap1 = tokens[1];
                        string lessonTitleToSwap2 = tokens[2];
                        SwapPositions(schedule, lessonTitleToSwap1, lessonTitleToSwap2);
                        break;
                    case "Exercise":
                        string exerciseToAdd = tokens[1];
                        AddExercise(schedule, exerciseToAdd);
                        break;
                }
                command = Console.ReadLine();
            }
            int counter = 1;
            foreach (var lesson in schedule)
            {
                Console.WriteLine($"{counter}.{lesson}");
                counter++;
            }
        }

        static void AddExercise(List<string> schedule, string exerciseToAdd)
        {
            if (schedule.Contains(exerciseToAdd) && !schedule.Contains($"{exerciseToAdd}-Exercise"))
            {
                int indexOfTheLesson = -1;
                for (int i = 0; i < schedule.Count; i++)
                {
                    if (schedule[i] == exerciseToAdd)
                    {
                        indexOfTheLesson = i;
                    }
                }
                int atIndexInsert = indexOfTheLesson + 1;
                schedule.Insert(atIndexInsert, $"{exerciseToAdd}-Exercise");
            }
            else if (!schedule.Contains(exerciseToAdd))
            {
                schedule.Add(exerciseToAdd);
                schedule.Add($"{exerciseToAdd}-Exercise");
            }
        }

        static void SwapPositions(List<string> schedule, string lessonTitleToSwap1, string lessonTitleToSwap2)
        {
            if (schedule.Contains(lessonTitleToSwap1) && schedule.Contains(lessonTitleToSwap2))
            {
                int firstLessonIndex = -1;
                int secondLessonIndex = -1;

                for (int i = 0; i < schedule.Count; i++)
                {
                    if (schedule[i] == lessonTitleToSwap1)
                    {
                        firstLessonIndex = i;
                    }
                    if (schedule[i] == lessonTitleToSwap2)
                    {
                        secondLessonIndex = i;
                    }
                }
                string temp = schedule[firstLessonIndex];
                schedule[firstLessonIndex] = schedule[secondLessonIndex];
                schedule[secondLessonIndex] = temp;

                if (schedule.Contains($"{lessonTitleToSwap1}-Exercise") && !schedule.Contains($"{lessonTitleToSwap2}-Exercise"))
                {
                    schedule.Insert(secondLessonIndex + 1, $"{lessonTitleToSwap1}-Exercise");
                    schedule.RemoveAt(firstLessonIndex + 2);
                }
                else if (!schedule.Contains($"{lessonTitleToSwap1}-Exercise") && schedule.Contains($"{lessonTitleToSwap2}-Exercise"))
                {
                    schedule.Insert(firstLessonIndex + 1, $"{lessonTitleToSwap2}-Exercise");
                    schedule.RemoveAt(secondLessonIndex + 2);
                }
                else if (schedule.Contains($"{lessonTitleToSwap1}-Exercise") && schedule.Contains($"{lessonTitleToSwap2}-Exercise"))
                {
                    string tempr = schedule[firstLessonIndex + 1];
                    schedule[firstLessonIndex + 1] = schedule[secondLessonIndex + 1];
                    schedule[secondLessonIndex + 1] = tempr;
                }
            }
        }

        static void RemoveLesson(List<string> schedule, string lessonTitleToRemove)
        {
            if (schedule.Contains(lessonTitleToRemove))
            {
                if (schedule.Contains($"{lessonTitleToRemove}-Exercise"))
                {
                    schedule.Remove($"{lessonTitleToRemove}-Exercise");
                }
                schedule.Remove(lessonTitleToRemove);
            }
        }

        static void InsertLesson(List<string> schedule, string lessonTitle, int atIndex)
        {
            if (!schedule.Contains(lessonTitle))
            {
                schedule.Insert(atIndex, lessonTitle);
            }
        }

        static void AddLesson(List<string> schedule, string lessonTitle)
        {
            if (!schedule.Contains(lessonTitle))
            {
                schedule.Add(lessonTitle);
            }
        }
    }
}
