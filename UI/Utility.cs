using System;
using System.Text;
using System.Threading;
using System.Globalization;

public static class Utility
{
  private static CultureInfo culture = new CultureInfo("en-US");
  public static decimal GetValidDecimalInputAmt(string input)
  {
    bool valid = false;
    string rawInput = string.Empty;
    decimal amount = 0;

    // Get user's input input type is valid
    while (!valid)
    {
      rawInput = GetRawInput(input);
      valid = decimal.TryParse(rawInput, out amount);
      if (!valid)
      {
        PrintMessage("Invalid input. Try again.", false);
      }
    }

    return amount;
  }

  public static Int64 GetValidIntInputAmt(string input)
  {
    bool valid = false;
    string rawInput = string.Empty;
    Int64 amount = 0;

    // Get user's input input type is valid
    while (!valid)
    {
      rawInput = GetRawInput(input);
      valid = Int64.TryParse(rawInput, out amount);
      if (!valid)
      {
        PrintMessage("Invalid input. Try again.", false);
      }
    }

    return amount;
  }


  public static string GetRawInput(string message)
  {
    Console.Write($"Enter {message}: ");
    return Console.ReadLine();
  }

  public static string GetHiddenConsoleInput()
  {
    StringBuilder input = new StringBuilder();
    while (true)
    {
      var key = Console.ReadKey(true);
      if (key.Key == ConsoleKey.Enter)
      {
        break;
      }
      if (key.Key == ConsoleKey.Backspace && input.Length > 0)
      {
        input.Remove(input.Length - 1, 1);
      }
      else if (key.Key != ConsoleKey.Backspace)
      {
        input.Append(key.KeyChar);
      }
    }
    return input.ToString();
  }

  #region UIOutput - UX and output format
  public static void PrintDotAnimation(int timer = 10)
  {
    for (var x = 0; x < timer; x++)
    {
      System.Console.Write(".");
      Thread.Sleep(100);
    }
    Console.WriteLine();
  }

  public static string FormatAmount(decimal amt)
  {
    return String.Format(culture, "{0:C2}", amt);
  }

  public static void PrintMessage(string msg, bool success)
  {
    if (success)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
    }

    Console.WriteLine(msg);
    Console.ResetColor();
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
  }
  #endregion
}