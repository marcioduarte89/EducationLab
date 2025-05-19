using EducationLabAPI.Dtos.Output;
using Microsoft.AspNetCore.Mvc;

namespace EducationLabAPI.Controllers
{
    /// <summary>
    /// Operations related to Questions
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        /// <summary>
        /// Gets the question explanation for a user
        /// The explanation is only retrieved if the user has attempted to answer the question in the current assignment
        /// </summary>
        /// <param name="id">The question id to get the explanation</param>
        /// <returns>Returns the question explanation</returns>
        [HttpGet]
        [Route("{id}/explanation")]
        [ProducesResponseType(typeof(QuestionExplanationResponse), StatusCodes.Status200OK)]
        public Task<IActionResult> Get(int id)
        {
            return Task.FromResult<IActionResult>(Ok(new QuestionExplanationResponse()
            {
                QuestionId = id,
                Answer = "A",
                Explanation = "Some explanation"
            }));
        }
    }
}
