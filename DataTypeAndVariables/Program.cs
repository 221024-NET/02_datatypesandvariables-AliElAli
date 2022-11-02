using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte = 64;
          sbyte mySbyte = 16;
          int myInt = -10;
          uint myUint = 10;
          short myShort = -2;
          ushort myUShort = 2;
          float myFloat = 32.89f;
          double myDouble = 67.11;
          char myCharacter = 'X';
          bool myBool = true;
          string myText = "I control text";
          string numText = "32";

          Console.WriteLine(myByte);
          Console.WriteLine(mySbyte);
          Console.WriteLine(myInt);
          Console.WriteLine(myUint);
          Console.WriteLine(myShort);
          Console.WriteLine(myUShort);
          Console.WriteLine(myFloat);
          Console.WriteLine(myDouble);
          Console.WriteLine(myCharacter);
          Console.WriteLine(myBool);
          Console.WriteLine(myText);
          Console.WriteLine(numText);
          Console.WriteLine(Text2Num("64000"));
      }

      public static int Text2Num(string numText)
      {
        int result = 0;
        if (Int32.TryParse(numText, out result))
        {
          return result;
        }
        return result;
      }
    }
}
