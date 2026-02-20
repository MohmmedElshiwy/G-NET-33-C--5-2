using System;

#region Enum
public enum Grade
{
    A,
    B,
    C,
    D,
    F
}
#endregion

class Program
{
    #region Methods

    static Grade GetGrade(int score)
    {
        if (score >= 90) return Grade.A;
        else if (score >= 80) return Grade.B;
        else if (score >= 70) return Grade.C;
        else if (score >= 60) return Grade.D;
        else return Grade.F;
    }

    static double CalculateAverage(int[] scores)
    {
        int sum = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }

        return (double)sum / scores.Length;
    }

    static void GetMinMax(int[] scores, out int min, out int max)
    {
        min = scores[0];
        max = scores[0];

        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] < min)
                min = scores[i];

            if (scores[i] > max)
                max = scores[i];
        }
    }

    #endregion

    static void Main()
    {
        int[] scores = new int[5];

        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Enter score for Student {i + 1}: ");
            scores[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Report ---");

        for (int i = 0; i < scores.Length; i++)
        {
            Grade grade = GetGrade(scores[i]);
            Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {grade}");
        }

        double average = CalculateAverage(scores);

   
        GetMinMax(scores, out int min, out int max);

        Console.WriteLine($"Average: {average:F1}");
        Console.WriteLine($"Lowest Score: {min}");
        Console.WriteLine($"Highest Score: {max}");
    }
}