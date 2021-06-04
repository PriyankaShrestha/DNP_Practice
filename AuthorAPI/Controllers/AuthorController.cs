using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Model;
using AuthorAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace AuthorAPI.Controllers
{
    [ApiController]
    [Route("/authors")]
    public class AuthorController : ControllerBase
    {
        private IAuthorService authorService;

        public AuthorController(IAuthorService service)
        {
            authorService = service;
        }
        
        [HttpPost]
        public async Task<ActionResult<Author>> AddAuthor([FromBody] Author author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //Console.WriteLine(author.ToString());
                Author toAdd = await authorService.AddAuthorAsync(author);
                Console.Write(toAdd.ToString());
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<IList<Author>>> GetAuthors()
        {
            try
            {
                IList<Author> authors = await authorService.GetAuthorsAsync();
                return Ok(authors);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}