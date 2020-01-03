using System;
using System.Linq;

class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    public Student(string firstName, string lastName, int identification, int[]scores) : base(firstName, lastName, identification)
    {
        testScores = scores;
    }

    public char Calculate()
    {
        int sum = 0;
        int count = 0;
        foreach (var item in testScores)
        {
            sum += item;
            count++;
        }
        double average = sum / count;
        return GetLetterGrade(average);
    }
    public char GetLetterGrade(double grade)
    {
        if (grade >= 90.0)
            return 'O';
        else if (grade >= 80.0)
            return 'E';
        else if (grade >= 70.0)
            return 'A';
        else if (grade >= 55.0)
            return 'P';
        else if (grade >= 40.0)
            return 'D';
        else
            return 'T';
        //switch (grade)
        //{
        //    case var d when d >= 90.0:
        //        return 'O';
        //    case var d when d >= 80.0:
        //        return 'E';
        //    case var d when d >= 70.0:
        //        return 'A';
        //    case var d when d >= 55.0:
        //        return 'P';
        //    case var d when d >= 40.0:
        //        return 'D';
        //    default:
        //        return 'T';
        //}
    }
}

class Solution
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}
