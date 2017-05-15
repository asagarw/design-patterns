using System;
using System.IO;

namespace Solid_Master.DecoratorMain
{
    public static class StreamRead
    {
        public static void Main(string[] args)
        {
            StreamReaderExample();
        }

        public static void StreamReaderExample()
        {
            using (var streamReader =
                new StreamReader(
                    new BufferedStream(
                        new FileStream(
                            "D:\\Work\\CodeOps\\SOLID-Training\\C#\\Solid-Master\\Solid-Master\\Decorator\\Read.cs",
                            FileMode.Open, FileAccess.Read))))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}