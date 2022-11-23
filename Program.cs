using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<char> Fruit = new Queue<char>();
        Queue<char> Output = new Queue<char>();
        Progress1(Fruit, Output);
    }

    static void Progress1(Queue<char> Fruit, Queue<char> Output)
    {
        char start = 'x';
        
        while (start == 'x' || start == 'L' || start == 'M' || start == 'S' )
        {
            char input = char.Parse(Console.ReadLine());

            if ( input == 'L' )
            {
                Fruit.Push('M');
                Fruit.Push('M');
                Output.Push('1');
            }
            else if ( input == 'M' )
            {
                Fruit.Push('S');
                Fruit.Push('S');
                Fruit.Push('S');
                Output.Push('2');
            }
            else if ( input == 'S' )
            {
                Output.Push('3');
            }
            else
            {
                Progress2(Fruit, Output);
            }
        }
    }

    static void Progress2(Queue<char> Fruit, Queue<char> Output)
    {
        for ( int i = 0; i < Fruit.GetLength(); i++)
        {
            char input = Fruit.Get(i);

            if ( input == 'M' )
            {
                Fruit.Push('S');
                Fruit.Push('S');
                Fruit.Push('S');
                Output.Push('2');
            }
            else if ( input == 'S' )
            {
                Output.Push('3');
            }
        }

        Print(Output);
    }

    static void Print(Queue<char> Output)
    {
        for ( int i = 0; i < Output.GetLength(); i++)
        {
            Console.Write(Output.Get(i));
        }

        Console.ReadLine();
    }
}