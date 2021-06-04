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
        
        [HttpPost]
        [Route("{Id:int}")]
        public async Task<ActionResult<Book>> AddBook([FromBody] Book book,[FromRoute] int authorId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Book toAdd = await bookService.AddBookAsync(book, authorId);
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
    }
}