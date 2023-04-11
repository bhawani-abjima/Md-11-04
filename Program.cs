using System;
using System.Xml.Linq;
using System.Collections;
using ExtensionMethods;
using System.Collections.Specialized;

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)       //using extension methods
        {
            return i > value;
        }
        public static string GetUpperCase(this string name)
        {
            return name.ToUpper();
        }
    }
}

public class Information
{
    private string AgentID;
    private int AgentCode;

    public Information(string a, int t)
    {
        this.AgentID = a;
        this.AgentCode = t;
    }

    public void Display()
    {
        Console.WriteLine("Agent Unique Code is : " + AgentID);
        Console.WriteLine("No of assigned tasks : " + AgentCode);
    }
}


public partial class Employee
{
  
    public int EmpId { get; set; }
    public string? Name { get; set; }

    partial void GenerateEmployeeId();

}

class Program
{
    static void Main(string[] args)
    {
        int i = 10;
        string name = "Sgt.Ghost";


        bool result = i.IsGreaterThan(100);
        Console.WriteLine(result);

        string str = name.GetUpperCase();  // calling extension method using string instance   
        Console.WriteLine(str);

        var emp = new Employee();
        Console.WriteLine(emp.EmpId);

        Information AMP = new Information("sgt", 45001);
        AMP.Display();


        Stack NMJ = new Stack();
        NMJ.Push("Welcome to");           //stack operation
        NMJ.Push("Abjima");
        NMJ.Push(58);
        NMJ.Push(99);
        NMJ.Push(null);
        NMJ.Push(1010);
        Console.WriteLine("Number of Elements in Stack: {0}", NMJ.Count);
        Console.WriteLine("---Stack Elements---");

        foreach (var item in NMJ)
        {
            Console.WriteLine(item);
        }


        Stack PLK = new Stack();
        PLK.Push("Welcome");
        PLK.Push("bhawani");               //access the elements
        PLK.Push(40001);
        PLK.Push(63);
        PLK.Push(852);
        PLK.Push(7878);
        Console.WriteLine("Number of Elements in Stack: {0}", PLK.Count);   
        Console.WriteLine("---Stack Elements---");
        while (PLK.Count > 0)
        {
           Console.WriteLine(PLK.Pop());
        }
        Console.WriteLine("Number of Elements in Stack: {0}", PLK.Count);


        Console.WriteLine("Contains Element 4: {0}",PLK.Contains(63));          //checking element present or not
        Console.WriteLine("Contains Element 100: {0}", PLK.Contains(100));
        Console.WriteLine("Contains Key 'Hello': {0}", PLK.Contains("Hey Everyone"));

       
        int[][] arr = new int[2][];
        arr[0] = new int[5] { 88, 13, 52, 77, 39 };
        arr[1] = new int[4] { 2, 4, 6, 8 };

        for (int t = 0; t < arr.Length; t++)
        {
            Console.Write("Element({0}): ", t);

            for (int j = 0; j < arr[t].Length; j++)
            {
               Console.WriteLine("{0}{1}", arr[t][j], j == (arr[t].Length - 1) ? "" : " ");
            }
            Console.WriteLine();
        }
           Console.WriteLine("Press any key to exit.");



                                                         // declare and initialize jagged array with 2D array
        int[][,] jaggedArray = new int[3][,]  {
                                                new int[ , ] { {10, 18}, {63, 76} },
                                                new int[ , ] { {06, 36}, {55, 66}, {92, 110} },
                                                new int[ , ] { {101, 223}, {1000, 808}, {001, 10} }
                                                                                              };

        Console.WriteLine(jaggedArray[0][0, 1]);
        Console.WriteLine(jaggedArray[1][2, 1]);
        Console.WriteLine(jaggedArray[2][1, 0]);



        int[][] jaggedArr = new int[3][];

        jaggedArr[0] = new int[2] { 2, 4 }; 
        jaggedArr[1] = new int[4] { 45, 25, 23, 65 };
        jaggedArr[2] = new int[3] { 23, 67, 52 };

        for (int e = 0; e < jaggedArr.Length; e++) 
        {
            System.Console.Write("Element({0})", e + 1);
            for (int j = 0; j < jaggedArr[e].Length; j++) 
            {
                System.Console.Write(jaggedArr[e][j] + "\t"); 

            }
            System.Console.WriteLine();
        }


        Console.ReadKey();
    }
}
