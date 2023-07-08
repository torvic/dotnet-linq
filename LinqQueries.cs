public class LinqQueries
{
	private List<Book> booksList = new List<Book>();

	public LinqQueries()
	{
		using (StreamReader reader = new StreamReader("books.json"))
		{
			string json = reader.ReadToEnd();
			this.booksList = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
		}
	}

	public IEnumerable<Book> getAllBooks()
	{
		return booksList;
	}

	public IEnumerable<Book> getBooksAfterTheYear2010()
	{
		// extension method
		// return booksList.Where(book => book.PublishedDate.Year > 2010);

		// query expresion
		return from book in booksList where book.PublishedDate.Year > 2010 select book;
	}

	public IEnumerable<Book> getBooksWithMoreThan250PagesWithInActionWord()
	{
		// extension method
		// return booksList.Where(book => book.PageCount > 250 && book.Title.Contains("in Action"));

		// query expresion
		return from book in booksList where book.PageCount > 250 && book.Title.Contains("in Action") select book;
	}
}