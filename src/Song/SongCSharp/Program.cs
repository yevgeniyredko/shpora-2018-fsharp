using System;

namespace SongCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var song1 = new Song("Queen", "Bohemian Rhapsody");
            var song2 = new Song("Queen", "Bohemian Rhapsody");
            Console.WriteLine(song1.Equals(song2)); //true

            var song3 = song2.WithName("We Are the Champions");
            Console.WriteLine(song3);
        }
    }
}
