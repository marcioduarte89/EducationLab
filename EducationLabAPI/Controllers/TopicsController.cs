using EducationLabAPI.Dtos.Input;
using EducationLabAPI.Dtos.Output;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EducationLabAPI.Controllers
{
    /// <summary>
    /// Topics Controller
    /// </summary>
    [Route("api/[controller]")]
    public partial class TopicsController : Controller
    {
        /// <summary>
        /// Gets the existing topics
        /// </summary>
        /// <param name="ids">Topic Ids</param>
        /// <param name="names">Topic names</param>
        /// <returns>Returns the topics based on filtering, if they exist</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<TopicResponse>), StatusCodes.Status200OK)]
        public Task<IActionResult> GetTopics(int[]? ids, string[]? names)
        {
            // other parameters could be provided above, filtering by id, name, etc
            var topics = new[]
            {
                new TopicResponse()
                {
                    Id = 1,
                    Name = "Number"
                },
                new TopicResponse()
                {
                    Id = 2,
                    Name = "Algebra"
                },
            };

            return Task.FromResult<IActionResult>(Ok(topics));
        }

        /// <summary>
        /// Gets a specific topic by id
        /// </summary>
        /// <param name="id">Topic Id</param>
        /// <returns>Returns the topic based on id, if they exist</returns>
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status404NotFound)]
        public Task<IActionResult> GetTopic(int id)
        {
            // other parameters could be provided above, filtering by id, name, etc
            var topic = new TopicResponse()
            {
                Id = 1,
                Name = "Number"
            };

            return Task.FromResult<IActionResult>(Ok(topic));
        }

        /// <summary>
        /// Creates a topic
        /// </summary>
        /// <param name="topic">The Topic to be created</param>
        /// <returns>Returns the created topic</returns>
        [HttpPost]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status201Created)]
        public Task<IActionResult> CreateTopic([Required][FromBody]CreateTopic topic)
        {
            return Task.FromResult<IActionResult>(Ok(topic));
        }
    }
}
