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
        /// Gets the existing question
        /// </summary>
        /// <param name="topicId">Topic id</param>
        /// <param name="subTopicId">Sub Topic Ids</param>
        /// <param name="ids">Question Ids</param>
        /// <returns>Returns the questions based on filtering, if they exist</returns>
        [HttpGet]
        [Route("{topicId}/subtopics/{subTopicId}/questions")]
        [ProducesResponseType(typeof(IEnumerable<TopicResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(IEnumerable<TopicResponse>), StatusCodes.Status404NotFound)]
        public Task<IActionResult> GetQuestions(int topicId, int subTopicId, int[]? ids)
        {
            // other parameters could be provided above, filtering by id, name, etc
            var questions = new[]
            {
                new QuestionResponse()
                {
                    Id = 1,
                    Name = "Number",
                    Answer = "A",
                    Description = "Some description",
                    Explanation = "Explanation",
                    ImageUrl = "https://www.someimage.com/jpeg",
                    SubTopic = new SubTopicResponse()
                    {
                        Id = 1,
                        Name = "Fractions",
                    }
                }
            };

            return Task.FromResult<IActionResult>(Ok(questions));
        }

        /// <summary>
        /// Gets a specific question by id
        /// </summary>
        /// <param name="topicId">Topic Id</param>
        /// <param name="subTopicId">Sub Topic Id</param>
        /// <param name="id">Questio Id</param>
        /// <returns>Returns the Question based on topic id and subtopic id, if they exist</returns>
        [HttpGet]
        [Route("{topicId}/subTopics/{subTopicId}/questions/{id}")]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status404NotFound)]
        public Task<IActionResult> GetTopic(int topicId, int subTopicId, int id)
        {
            // other parameters could be provided above, filtering by id, name, etc
            var question = new QuestionResponse()
            {
                Id = 1,
                Name = "Number",
                Answer = "A",
                Description = "Some description",
                Explanation = "Explanation",
                ImageUrl = "https://www.someimage.com/jpeg",
                SubTopic = new SubTopicResponse()
                {
                    Id = 1,
                    Name = "Fractions",
                }
            };

            return Task.FromResult<IActionResult>(Ok(question));
        }

        /// <summary>
        /// Creates a question
        /// </summary>
        /// <param name="topicId">The Topic id</param>
        /// <param name="subTopicId">The Subtopic id</param>
        /// <param name="question">The question created</param>
        /// <returns>Returns the created Subtopic</returns>
        [HttpPost]
        [Route("{topicId}/subTopics/{subTopicId}/questions")]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(TopicResponse), StatusCodes.Status404NotFound)]
        public Task<IActionResult> CreateQuestion(int topicId, int subTopicId, [Required][FromBody] CreateQuestion question)
        {
            return Task.FromResult<IActionResult>(Ok(question));
        }
    }
}
