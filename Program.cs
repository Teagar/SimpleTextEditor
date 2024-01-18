using System;
using System.IO;
using System.Threading;

namespace SimpleTextEditor
{
  
  class Program
  {

    static string text = "";
    static void Main(string[] args)
    {

      Start();
    }

    static void Menu()
    {}

    static void PreStart()
    {}

    static void Start()
    {

      Console.Clear();
      Console.WriteLine("What do U wanna do?\n");
      Console.WriteLine("1\tOpen");
      Console.WriteLine("2\tEdit");
      Console.WriteLine("3\tSave");
      Console.WriteLine("0\tExit");
      short option = 0; 
      short.TryParse(Console.ReadLine(), out option);

      switch(option)
      {
        
        case 0: System.Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Edit(); break;
        case 3: Save(); break;
        default: Start(); break;
      }
    }

    static void Open()
    {

      
    }

    static void Edit()
    {

      Console.Clear();
      Console.WriteLine("Enter your text (Press [esc] to exit)");
      Console.WriteLine("=================");

      do{

        text += Console.ReadLine();
        text += Environment.NewLine;
      } while(Console.ReadKey().Key != ConsoleKey.Escape);
      Start();
    }

    static void Save()
    {

      string? path = Console.ReadLine();

      using(var file = new StreamWriter(path))
      {

        file.Write(text);
      }
    }

  }
}
