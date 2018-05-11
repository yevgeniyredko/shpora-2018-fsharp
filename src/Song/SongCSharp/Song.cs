using System;

namespace SongCSharp
{
    class Song : IEquatable<Song>
    {
        public Song(string author, string name)
        {
            Author = author;
            Name = name;
        }

        public string Author { get; }
        public string Name { get; }

        public Song WithAuthor(string author) => new Song(author, Name);
        public Song WithName(string name) => new Song(Author, name);

        public override bool Equals(object obj) => Equals(obj as Song);

        public bool Equals(Song other) => 
            other != null &&
            Author == other.Author &&
            Name == other.Name;

        public override int GetHashCode() => HashCode.Combine(Author, Name);

        public override string ToString() => 
            $"Author: {Author}, Name: {Name}";
    }
}
