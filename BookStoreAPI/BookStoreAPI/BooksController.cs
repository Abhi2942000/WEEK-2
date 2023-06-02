using System.Collections.Generic;
using BookStoreAPI;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    private static List<Book> books = new List<Book>()
    {
            new Book { Id = 1, Title = "Myth", Author = "Devdutt Pattanaik", Genre = "Mythology", Price = 200 },
            new Book { Id = 2, Title = "The Palace of Illusions", Author = "Chitra Banerjee", Genre = "Fiction", Price = 300 },
            new Book { Id = 3, Title = "The God of Small Things", Author = "Arundhati Roy", Genre = "Historic Fiction", Price = 560 },
            new Book { Id = 4, Title = "The White Tiger", Author = "Aravind Adiga", Genre = "Satire", Price = 600 },
            new Book { Id = 5, Title = "The Immortals of Mehula", Author = "Amish Tripathi", Genre = "Mythological Fiction", Price = 900 }
        }; // In-memory storage for simplicity


    // GET /api/books
    [HttpGet]
    public IActionResult GetAllBooks()
    {
        return Ok(books);
    }

    // GET /api/books/{id}
    [HttpGet("{id}")]
    public IActionResult GetBookById(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }

        return Ok(book);
    }

    // POST /api/books
    [HttpPost]
    public IActionResult AddBook(Book book)
    {
        //book.Id = books.Count + 1; // Assign a new ID
        //books.Add(book);
        //return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        using (var db = new BookstoreContext())
        {
            db.Books.Add(book);
            db.SaveChanges();
        }
        return Ok();
    }

    // PUT /api/books/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, Book updatedBook)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }

        book.Title = updatedBook.Title;
        book.Author = updatedBook.Author;
        book.Genre = updatedBook.Genre;
        book.Price = updatedBook.Price;

        return NoContent();
    }

    // DELETE /api/books/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }

        books.Remove(book);
        return NoContent();
    }
}
