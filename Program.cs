using System;
using System.IO;
using System.Threading;

namespace SimpleTextEditor
{
  
  class Program
  {

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
      Console.WriteLine("What do U wanna do?");
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
    {}

    static void Edit()
    {

      string text = "";
      Console.WriteLine("Enter your text (Press [esc] to exit)");
      Console.WriteLine("=================");

      do{

        text += Console.ReadLine();
        text += Environment.NewLine;

      } while(Console.ReadKey().Key != ConsoleKey.Escape);
      Console.WriteLine(text);
      Start();
    }

    static void Save()
    {}

  }
}
