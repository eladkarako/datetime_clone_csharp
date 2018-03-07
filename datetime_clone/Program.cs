using System;
using System.Text;

namespace datetime_clone
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.UTF8;
      Console.InputEncoding = Encoding.UTF8;

      string source = args[0];
      string target = args[1];

      System.IO.File.SetCreationTimeUtc(target, System.IO.File.GetCreationTimeUtc(source));
      System.IO.File.SetLastAccessTimeUtc(target, System.IO.File.GetLastAccessTimeUtc(source));
      System.IO.File.SetLastWriteTimeUtc(target, System.IO.File.GetLastWriteTimeUtc(source));
    }
  }
}