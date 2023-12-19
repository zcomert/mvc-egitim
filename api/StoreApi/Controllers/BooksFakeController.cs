using Microsoft.AspNetCore.Mvc;
using StoreApi.InMemoryRepositories;
using StoreApi.Models;

namespace StoreApi.Controllers;

[ApiController]
[Route("api/booksfake")]
public class BooksFakeController : ControllerBase
{
    private readonly BookRepositoryFake _fakeBookRepositoy;

    public BooksFakeController(BookRepositoryFake fakeBookRepositoy)
    {
        _fakeBookRepositoy = fakeBookRepositoy;
    }

    [HttpGet]
    public IActionResult GetAllBooks()
    {
        try
        {
            return Ok(_fakeBookRepositoy.Books);
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    [HttpGet("{id:int}")]
    public IActionResult GetOneBook([FromRoute(Name = "id")] int id)
    {
        try
        {
            return Ok(_fakeBookRepositoy.GetOne(id));
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    [HttpPost]
    public IActionResult CreateOneBook([FromBody] Book book)
    {
        try
        {
            _fakeBookRepositoy.Add(book);
            return NoContent();
        }
        catch (System.Exception)
        {
            throw;
        }

    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateOneBook([FromRoute(Name = "id")] int id,
    [FromBody] Book book)
    {
        try
        {
            return Ok(_fakeBookRepositoy.UpdateBook(id, book));

        }
        catch (System.Exception)
        {
            throw;
        }
    }
}