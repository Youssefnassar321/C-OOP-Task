using System;
using System.Linq;
using System.IO;




namespace ConsoleApp2
{
    internal class Program
    {
        #region methods
        //static void Mymehod() 
        //{
        //    Console.WriteLine("this is a new method");

        //}

        //static void MyName(string name = "youssef " , int age = 44 ) 
        //{
        //    Console.WriteLine($"my name is {name} my age is {age}");    

        //}

        //static int New(int x = 0 , int y = 0 ) 
        //{
        //    return x + y;
        //}

        //static double New(double x = 0, double y = 0)
        //{
        //    return x + y;
        //}
        //static void Main(string[] args)
        //{
        //    #region array

        //    // string[] phones = { "sumsung ", "iphone", "hwawi" };
        //    //// Console.WriteLine(phones.Length - 1);
        //    //// Console.WriteLine(phones[1]);
        //    // Array.Sort(phones);
        //    // foreach (string phone in phones)
        //    // {
        //    //     Console.WriteLine(phone);
        //    // }
        //    //int[] numbers = { 5, 2, 6, 2, 8, 9, 1, 7, 2, 3, 8, };
        //    //Console.WriteLine(numbers.Max());
        //    //Console.WriteLine(numbers.Min());
        //    //Console.WriteLine(numbers.Sum());

        //    //int[,] mynumbers = { { 1, 2, 3, 3, 2 }, { 1, 2, 21, 21, 21 } };
        //    //for (int i = 0; i < mynumbers.GetLength(0); i++)
        //    //{
        //    //    for (int j = 0; j < mynumbers.GetLength(1); j++)
        //    //    {
        //    //        Console.WriteLine(mynumbers[i, j]);
        //    //    }
        //    //} 
        //    #endregion

        //    Mymehod();
        //    MyName("youssef nassar", 23);
        //    MyName();
        //    int z = New(5, 6);
        //    int m = New(7, 8);
        //    Console.WriteLine(z);
        //    Console.WriteLine(m);
        //    MyName(age : 88, name : "moha,ed");
        //    double mynum1 = New(5.4, 7.8);
        //    Console.WriteLine(mynum1);

        //} 
        #endregion

        #region oop1
        //class car
        //{
        //    string color = "red ";


        //    public static void Main(string[] args)
        //    {
        //        car obj = new car();
        //        car obj2 = new car();

        //        Console.WriteLine(obj.color);
        //        Console.WriteLine(obj.color);
        //    }
        //} 
        #endregion

        #region oop2
        //class car 
        //{
        //    public string color = "red";
        //}

        //class program 
        //{
        //    static void Main(string[] args)
        //    {
        //        car s = new car();
        //        Console.WriteLine(s.color);
        //    }
        //}
        //class car 
        //{
        //    string name = "youssef";
        //    int y = 4;
        //    public void method()
        //    {
        //        Console.WriteLine("hello");
        //    }
        //}
        //class car
        //{
        //    public string name;
        //    public string color;
        //    public int price;

        //    public void Method(string name)
        //    {
        //        Console.WriteLine($"my name is {name}");
        //    }

        //}
        //    static void Main(string[] args)
        //    {
        //        car s1 = new car();
        //        car s2 = new car();
        //        car s3 = new car();

        //        s1.name = "KAI";
        //        s1.color = "green";
        //        s1.price = 30000000;

        //        s2.name = "honda";
        //        s2.color = "red";
        //        s2.price = 500000000;

        //        s3.name = "BMW";
        //        s3.color = "black";
        //        s3.price = 100000;

        //        Console.WriteLine(s1.name);
        //        Console.WriteLine(s2.name);
        //        Console.WriteLine(s3.name);
        //        car obj = new car();
        //        obj.Method("youssef nassar ");

        //    }

        #endregion

        #region oop3
        //class car
        //{
        //    public string model;
        //    public string color;
        //    public int price;

        //    public car(string modelname, string colorname, int pricenum)
        //    {
        //        model = modelname;
        //        color = colorname;
        //        price = pricenum;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    car ford = new car("musting", "red", 700);
        //    Console.WriteLine(ford.model + " " + ford.color + " " + ford.price);
        //}
        #endregion

        #region oop4
        //class person
        //{

        //    public string NAME
        //    {
        //        get;
        //        set;
        //    }
        //}
        //class program
        //{
        //    static void Main(string[] args)
        //    {
        //        person per1 = new person();
        //        per1.NAME = "youssef";
        //        Console.WriteLine(per1.NAME);

        //    }
        //} 
        #endregion

        #region inheritance
        //sealed class vehical
        //{
        //    public string brand = "BMW";
        //    public void price()
        //    {
        //        Console.WriteLine("the car price is 26374 ");

        //    }
        //}
        //class car : vehical
        //{
        //    public string color = "red";
        //}
        //class program
        //{
        //    static void Main(string[] args)
        //    {
        //        car obj1 = obj1 = new car();
        //        obj1.price();
        //        Console.WriteLine(obj1.brand + " " + obj1.color);
        //    }
        //} 
        #endregion

        #region override
        //class anmail
        //{
        //    public virtual void Sound() 
        //    {
        //        Console.WriteLine("the animal has a sound ");
        //    }
        //}
        //class pig : anmail
        //{
        //    public override void Sound()
        //    {
        //        Console.WriteLine("the pig says : bow bow ");

        //    }
        //}
        //class dog : anmail
        //{
        //    public override void Sound()
        //    {
        //        Console.WriteLine("the dog say : hawww hawwww");
        //    }
        //}
        //class program
        //{
        //    static void Main (string[] args) 
        //    {
        //        anmail obj = new anmail();
        //        anmail obj2 = new pig();
        //        anmail obj3 = new dog();
        //        obj.Sound();
        //        obj2.Sound();
        //        obj3.Sound();

        //    }
        //} 
        #endregion

        #region inerface 
        //interface Ianimal
        //{
        //     void sound();

        //}
        //class pig : Ianimal
        //{
        //    public  void sound()
        //    {
        //        Console.WriteLine("the pig sound is : bowo bowwo ");
        //    }
        //}
        //class dog : Ianimal
        //{
        //    public void sound()
        //    {
        //        Console.WriteLine("th dog sound is : haww hawww ");

        //    }
        //}
        //class program
        //{
        //    static void Main(string[] args)
        //    {
        //        pig nnn = new pig();

        //        nnn.sound();
        //    }
        //} 
        #endregion

        #region enum
        //class program
        //{
        //    enum level
        //    {
        //        low,
        //        medium = 10,
        //        high
        //    }
        //    static void Main (string[] args) 
        //    {
        //        level myvar = level.high;
        //        switch (myvar)
        //        {
        //            case level.low:
        //                Console.WriteLine ("low level");
        //                break;
        //            case level.medium:
        //                Console.WriteLine("medium level");
        //                break;
        //            case level.high:
        //                Console.WriteLine("high level");
        //                break;

        //        }
        //        int my = (int) level.high;
        //        Console.WriteLine (my);
        //    }
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region file
            //string x = "hello world";
            //File.WriteAllText("filename.txt", x);

            //string y = File.ReadAllText("filename.txt");
            //Console.WriteLine(y); 
            #endregion

            #region excption
            //try
            //{
            //    string[] strings = { "rrrrrrr", "fffffffff", "gggggggggg", "vvvvvvvvv" };
            //    Console.WriteLine(strings[10]);
            //}
            //catch (Exception e)            
            //{
            //    Console.WriteLine("erroor");

            //}
            //finally
            //{
            //    Console.WriteLine("the final of the program good byyyy");
            //}
            //    static void Checkage(int age)
            //    {
            //        if (age < 18)
            //        {
            //            throw new ArithmeticException("access deinid - you are must at least 18 years old  ");

            //        }
            //        else
            //        {
            //            Console.WriteLine("acsses granted - your agre is accepted");
            //        }
            //    }
            //    Checkage(10);


            #endregion



        }


    }
}
