namespace EjercicioLINQ2
{
    public class Book
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublicationDate { get; set; } // Year
        public int Sales { get; set; } // Millions

        public Book(string title, int authorId, int publicationDate, int sales)
        {
            this.Title = title;
            this.AuthorId = authorId;
            this.PublicationDate = publicationDate;
            this.Sales = sales;
        }

        public static List<Book> Books()
        {
            return new List<Book>
            {
                new Book("Don Quijote de la Mancha", 1, 1605, 500),
                new Book("Historia de dos ciudades", 2, 1859, 200),
                new Book("El Señor de los Anillos", 3, 1978, 150),
                new Book("El principito", 4, 1951, 140),
                new Book("El hobbit", 3, 1982, 100),
                new Book("Sueño en el pabellón rojo", 5, 1792, 100),
                new Book("Las aventuras de Alicia en el país de las maravillas", 6, 1865, 100),
                new Book("Diez negritos", 7, 1939, 100),
                new Book("El león, la bruja y el armario", 8, 1950, 85),
                new Book("El código Da Vinci", 9, 2003, 80),
                new Book("El guardián entre el centeno", 10, 1951, 65),
                new Book("El alquimista", 11, 1988, 65),
            };
        }
    }

    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public Author(int authorId, string name)
        {
            this.AuthorId = authorId;
            this.Name = name;
        }

        public static List<Author> Authors()
        {
            return new List<Author>
                {
                new Author(1, "Miguel de Cervantes"),
                new Author(2, "Charles Dickens"),
                new Author(3, "J. R. R. Tolkien"),
                new Author(4, "Antoine de Saint-Exupéry"),
                new Author(5, "Cao Xueqin"),
                new Author(6, "Lewis Car"),
                new Author(7, "Agatha Christie"),
                new Author(8, "C. S. Lewis"),
                new Author(9, "Dan Brown"),
                new Author(10, "J. D. Salinger"),
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = Book.Books();
            var authors = Author.Authors();

            
            // Mostrar en consola los 3 libros con más ventas
            var top3Books= books.OrderByDescending(b => b.Sales).Take(3);
            Console.WriteLine("Top 3 libros con más ventas:\n");
            foreach (var book in top3Books)
            {
                Console.WriteLine($"{book.Title} - Ventas: {book.Sales} millones");
            }
            // Mostrar en consola los 3 libros con menos ventas
            var bottom3Books = books.OrderBy(b => b.Sales).Take(3);
            Console.WriteLine("\nTop 3 libros con más ventas:\n");
            foreach (var book in bottom3Books)
            {
                Console.WriteLine($"{book.Title} - Ventas: {book.Sales} millones");
            }
            // Mostrar en consola el autor con más libros publicados.
            var authorWithMostBooks = books.GroupBy(b => b.AuthorId)
                                           .OrderByDescending(g => g.Count())
                                           .FirstOrDefault();
            if (authorWithMostBooks != null)
            {
                var authorName = authors.First(a => a.AuthorId == authorWithMostBooks.Key).Name;
                Console.WriteLine($"\nAutor con más libros publicados: {authorName} ({authorWithMostBooks.Count()} libros)");
            }
            // Mostrar en consola el autor y la cantidad de libros publicados.
            var authorBookCounts = books.GroupBy(b => b.AuthorId)
                .Select(g => new
                {
                    AuthorName = authors.FirstOrDefault(a => a.AuthorId == g.Key)?.Name ?? "Desconocido",
                    BookCount = g.Count()
                });

            Console.WriteLine("\nAutores y cantidad de libros publicados:");
            foreach (var author in authorBookCounts)
            {
                Console.WriteLine($"{author.AuthorName} - {author.BookCount} libros");
            }



            // Mostrar en consola los libros publicados hace menos de 50 años.
            var recentBooks = books.Where(b => (DateTime.Now.Year - b.PublicationDate < 50));
            Console.WriteLine("\n Libros publicados hace menos de 50 años\n");
            foreach (var book in recentBooks)
            {
                Console.WriteLine($"{book.Title} - Fecha: {book.PublicationDate}");
            }

            // Mostrar en consola el libro más viejo.
            var oldestBook = books.OrderBy(b => b.PublicationDate).FirstOrDefault();
            Console.WriteLine("Libro mas viejo");
            if (oldestBook != null)
            {
                Console.WriteLine($"\nLibro más viejo: {oldestBook.Title} ({oldestBook.PublicationDate})\n");
            }

            // Mostrar en consola los autores que tengan un libro que comience con "El". 
            var authorsWithBooksStartingWithEl = books.Where(b => b.Title.StartsWith("El "))
                                          .Select(b => b.AuthorId)
                                          .Distinct()
                                          .Join(authors, id => id, a => a.AuthorId, (id, a) => a.Name);
            Console.WriteLine("\nAutores con libros que comienzan con 'El':");
            foreach (var authorName in authorsWithBooksStartingWithEl)
            {
                Console.WriteLine(authorName);
            }

        }
    }
}
