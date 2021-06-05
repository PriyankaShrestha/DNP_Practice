using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Model;
using AuthorAPI.Service.Books;
using Microsoft.AspNetCore.Mvc;

namespace AuthorAPI.Controllers
{
    [ApiController]
    [Route("/books")]
    public class BookController : ControllerBase
    {
        private IBookService bookService;

        public BookController(IBookService service)
        {
            bookService = service;
        }
        
        [HttpPost]
        [Route("{AuthorId:int}")]
        public async Task<ActionResult<string>> AddBook([FromBody] Book book,[FromRoute] int authorId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                string toAdd = await bookService.AddBookAsync(book, authorId);
                Console.WriteLine(toAdd.ToString() + "---------------------*******************");
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IList<Book>>> GetBooks()
        {
            try
            {
                IList<Book> books = await bookService.GetBooksAsync();
                return Ok(books);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{bookId:int}")]
        public async Task<ActionResult<string>> DeleteBook([FromRoute] int bookId)
        {
            try
            {
                string message = await bookService.DeleteBookAsync(bookId);
                return message;
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}