using EducationLabAPI.Dtos.Input;
using EducationLabAPI.Dtos.Output;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EducationLabAPI.Controllers
{
    /// <summary>
    /// Topics Controller
    /// </summary>
    public partial class TopicsController : Controller
    {
        /// <summary>
        /// Gets the existing sub topics
        /// </summary>
        /// <param name="topicId">Topic id</param>
        /// <param name="ids">Sub Topic Ids</param>
        /// <param name="names">Sub Topic names</param>
        /// <returns>Returns the sub topics based on filtering, if they exist</returns>
        [HttpGet]
        [Route("{topicId}/subTopics")]
        [ProducesResponseType(typeof(IEnumerable<TopicResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(IEnumerable<TopicResponse>), StatusCodes.Status404NotFound)]
        public Task<IActionResult> GetSubTopics(int topicId, int[]? ids, string[]? names)
        {
            // other parameters could be provided above, filtering by id, name, etc
            var subTopics = new[]
            {
                new SubTopicResponse()
                {
                    Id = 1,
                    Name = "Fractions",
                    Topic = new TopicResponse()
                    {
                        Id = topicId,
                        Name = "Number"
                    }
                }
            };

            return Task.FromResult<IActionResult>(Ok(subTopics));
        }

        /// <summary>
        /// Gets a specific sub topic by id
        /// </summary>
        /// <param name="topicId">Topic Id</param>
        /// <param name="id">SubTopic Id</param>
        /// <returns>Returns the Sub topic based on topic id and subtopic id, if they exist</returns>
        [HttpGet]
        [Route("{topicId}/subTopics/{id}")]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status404NotFound)]
        public Task<IActionResult> GetSubTopic(int topicId, int id)
        {
            // other parameters could be provided above, filtering by id, name, etc
            var topic = new SubTopicResponse()
            {
                Id = 1,
                Name = "Fractions",
                Topic = new TopicResponse()
                {
                    Id = 1,
                    Name = "Number"
                }
            };

            return Task.FromResult<IActionResult>(Ok(topic));
        }

        /// <summary>
        /// Creates a subtopic
        /// </summary>
        /// <param name="id">The Topic di</param>
        /// <param name="subTopic">The Sub Topic to be created</param>
        /// <returns>Returns the created Subtopic</returns>
        [HttpPost]
        [Route("{id}/subTopics")]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status404NotFound)]
        public Task<IActionResult> CreateSubTopic(int id, [Required][FromBody] CreateSubTopic subTopic)
        {
            return Task.FromResult<IActionResult>(Ok(subTopic));
        }
    }
}
