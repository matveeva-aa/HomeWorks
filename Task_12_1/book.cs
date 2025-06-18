namespace Task_12_1
{
    class Book<T, U>
    {
        public T Code { get; }
        public string Title { get; }
        public U PublicationYear { get; }
        public string Author { get; }

        public Book(T code, string title, U publicationYear, string author)
        {
            Code = code;
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }

        public override string ToString()
        {
            return $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
        }
    }
}
