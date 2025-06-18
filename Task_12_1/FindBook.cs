namespace Task_12_1
{
    static class BookFinder
    {
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (var book in books)
            {
                if (book.Code.Equals(code))
                    return book;
            }
            return null;
        }
    }
}
