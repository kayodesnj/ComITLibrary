namespace ComitLibrary
{
    public class Book
    {
        public Book(long id, string title, string author) {
            Id = id;
            Title = title;
            Author = author;
        }

        // Book data members go here
        public long Id { get; }
        public string Title { get; private set; }
        public string Author {get; private set;}

    }
}