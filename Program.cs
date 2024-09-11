internal class Program
{
  private static void Main(string[] args)
  {
    //foreach (string directory in Directory.GetDirectories("C:\\"))
    //  Console.WriteLine(directory);
    //foreach (string file in Directory.EnumerateFiles("F:\\"))
    //  Console.WriteLine(file);
    foreach (string еntrie in Directory.GetFileSystemEntries("C:\\"))
      Console.WriteLine(еntrie);
  }
}