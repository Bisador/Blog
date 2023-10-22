
using Application.CMS.Article.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presentation.Shared;

namespace Presentation.Controllers;

[ApiController]
[Route("[controller]/[Action]")]
public class ArticleController : BaseController
{
    /// <summary>
    /// Get the article with specified id
    /// </summary>
    /// <param name="id">The article identifier</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>the article with specified id</returns>
    [HttpGet("{id:Guid}")]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid id, CancellationToken cancellationToken)
    {
        return Ok(new { id });
    }

    [HttpPost]
    [ProducesResponseType(typeof(Guid), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Guid>> Create([FromBody] CreateArticleRequest request, CancellationToken cancellationToken)
    {
        var id = Guid.NewGuid();
        //var article = Article.Create(id, "new Article", DateTime.Now, null);
        var actionName = nameof(Create);
        CreateArticleCommand command = new(
            Content: "AAA",
            PublishDate: DateTime.UtcNow,
            Title: "",
            WriterId: Guid.NewGuid()
        );
        var result = await Mediator.Send(command, cancellationToken);
        //return ID
        return result.IsSuccess ? CreatedAtAction(actionName, new { result }, result) : BadRequest(result.Error); 
    }

}
