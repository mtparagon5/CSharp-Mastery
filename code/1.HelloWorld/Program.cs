using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello World!");

      // integers
      #region integers

      // int counter; // declaring

      // counter = 5; // assigning

      // counter += 1;

      // Console.WriteLine(counter);

      // counter++;

      // Console.WriteLine(counter);

      // counter--;

      // Console.WriteLine(counter);

      // counter *= 2;

      // Console.WriteLine(counter);

      // counter /= 2;

      // Console.WriteLine(counter);

      // counter %= 2;

      // Console.WriteLine(counter);

      #endregion integers

      // value types
      #region value types

      // // integral types -- smallest to largest
      // // 2 ^ n_bits
      // // s = signed, u = unsigned
      // sbyte mySByte;    // -128 to 127
      // byte myByte;      // 0 to 255
      // short myShort;    // -32,768 to 32,767
      // ushort myUShort;  // 0 to 65,535
      // int myInt;        // -2,147,483,648 to 2,147,483,647
      // uint myUInt;      // 0 to 4,294,967,295
      // long myLong;      // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
      // ulong myULong;    // 0 to 18,446,744,073,709,551,615

      // // floats
      // float f;      // 6-9 digits (32 bits)
      // double d;     // 15-17 digits (64 bits)
      // decimal dec;  // 28-29 digits (128 bits)
      // // use decimal for high precision, e.g., 111111111151111.05f


      // // booleans
      // bool myBool;
      // char myChar;
      // string myString;

      // Console.WriteLine($"A boolean is {sizeof(bool) * 8} bits"); // bytes converted to bits by multiplying by 8
      // Console.WriteLine($"An int is {sizeof(int) * 8} bits");
      // Console.WriteLine($"A char is {sizeof(char) * 8} bits"); // ushort

      // DateTime myDate;
      // TimeSpan myTime;

      #endregion value types

      // var / suffix assignment
      #region using var and suffix assignment

      var mySByte = (sbyte)-0b01;         // sbyte -> -128 to 127 -> or denoted by 0b... in C#7 
      var myByte = (byte)0b0101;          // byte -> 0 to 255 -> or denoted by 0b... in C#7 
      var myShort = (short)1;             // short -> -32,768 to 32,767
      var myUShort = (ushort)1;           // ushort -> 0 to 65,535
      var myInt = 1;                      // int -> -2,147,483,648 to 2,147,483,647 -> this is the default
      var myUInt = (uint)1;               // uint -> 0 to 4,294,967,295
      var myLong = 1L;                    // long -> -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
      var myULong = 1UL;                  // ulong ->  0 to 18,446,744,073,709,551,615

      // floats
      var f = 1.1F;                       // float -> 6-9 digits (32 bits)
      var d = 1.1;                        // double -> 15-17 digits (64 bits) - this is the default
      var dec = 1.1M;                     // decimal -> 28-29 digits (128 bits)



      #endregion methods

      #region string interpolation
      var amount = 500;
      var string1 = $"I earned ${amount} this week.";

      // strings on multiple lines
      var string2 = $"Last week, though, I earned " + // pressing enter inside the "" will add a new line for you when in VS2019
                    $"${amount * 2} :(";                   // this is useful for writing more readable code in longer examples

      Console.WriteLine(string1);
      Console.WriteLine(string2);

      #endregion parsing
    }
  }
}
