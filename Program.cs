LinqQueries queries = new LinqQueries();

Console.WriteLine("================= GET ALL BOOKS =================");
printValues(queries.getAllBooks());

Console.WriteLine("================= GET BOOKS AFTER THE YEAR 2000 =================");
printValues(queries.getBooksAfterTheYear2010());

Console.WriteLine("================= GET BOOKS WITH MORE THAN 250 PAGES WITH IN ACTION WORD =================");
printValues(queries.getBooksWithMoreThan250PagesWithInActionWord());

void printValues(IEnumerable<Book> booksList)
{
	Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
	foreach (var book in booksList)
	{
		Console.WriteLine("{0,-60} {1, 15} {2, 15}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
	}
}