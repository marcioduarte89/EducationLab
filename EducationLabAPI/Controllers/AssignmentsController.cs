using EducationLabAPI.Dtos.Input;
using EducationLabAPI.Dtos.Output;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EducationLabAPI.Controllers
{
    /// <summary>
    /// Operations related to the user assignment
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        /// <summary>
        /// Gets the assignments for the logged in user
        /// </summary>
        /// <param name="assignmentStatus">Assignment status, ie. Draft, completed or other </param>
        /// <param name="correctAnswers">Whether we should filter based only on correct answers or not</param>
        /// <returns>Returns the active assignments for the user</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<AssignmentResponse>), StatusCodes.Status200OK)]
        public Task<IActionResult> GetAssignments(AssignmentStatus? assignmentStatus, bool? correctAnswers)
        {
            // other parameters could be provided above
            var userAssignments = new[]
            {
                new AssignmentResponse()
                {
                    Id = 1,
                    Name = "Student x 18/05/2025 Assignment",
                    Status = AssignmentStatus.Draft,
                    Topics =
                    [
                        new ()
                        {
                            TopicId = 1,
                            Name = "Number",
                            SubTopics = [
                                new AssignmentSubTopicResponse() {

                                    SubTopicId = 2,
                                    Name = "Fractions",
                                    Questions = [
                                        new AssignmentQuestionResponse()
                                        {
                                            QuestionId = 3,
                                            ImageUrl = "https://www.some-domain.com/image.jpeg",
                                            IsAnswerCorrect = correctAnswers,
                                            UsersAnswer = "A"
                                        }
                                    ]
                                }
                            ]
                        }
                    ]
                }
            };

            return Task.FromResult<IActionResult>(Ok(userAssignments));
        }

        /// <summary>
        /// Gets the assignment by id for the logged in user
        /// </summary>
        /// <param name="id">The assignment id to return </param>
        /// <returns>Returns the assignments by id for the user</returns>
        [HttpGet]
        [Route("{id}/")]
        [ProducesResponseType(typeof(AssignmentResponse), StatusCodes.Status200OK)]
        public Task<IActionResult> Get(int id)
        {
            var userAssignment = new AssignmentResponse()
            {
                Id = 1,
                Name = "Student x 18/05/2025 Assignment",
                Status = AssignmentStatus.Draft,
                Topics =
                    [
                        new AssignmentTopicsResponse()
                        {
                            TopicId = 1,
                            Name = "Number",
                            SubTopics = [
                                new AssignmentSubTopicResponse() {

                                    SubTopicId = 2,
                                    Name = "Fractions",
                                    Questions = [
                                        new AssignmentQuestionResponse()
                                        {
                                            QuestionId = 3,
                                            ImageUrl = "https://www.some-domain.com/image.jpeg",
                                            IsAnswerCorrect = true,
                                            UsersAnswer = "A"
                                        }
                                    ]
                                }
                            ]
                        }
                    ]
            };

            return Task.FromResult<IActionResult>(Ok(userAssignment));
        }

        /// <summary>
        /// Creates an assignment for a user
        /// </summary>
        /// <param name="assignment">The assignment to be created</param>
        /// <returns>Returns the saved assignments for the user</returns>
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(AssignmentResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(AssignmentResponse), StatusCodes.Status404NotFound)]
        public Task<IActionResult> CreateAssignment([Required][FromBody] CreateAssignment assignment)
        {
            // use named route
            return Task.FromResult<IActionResult>(Created("api/assignments/id", assignment));
        }

        /// <summary>
        /// Saves an assignment for the logged in user
        /// </summary>
        /// <param name="id">The assignment id to be saved</param>
        /// <param name="assignment">The assignment to be saved</param>
        /// <returns>Returns the saved assignments for the user</returns>
        [HttpPost]
        [Route("{id}/save")]
        [ProducesResponseType(typeof(AssignmentResponse), StatusCodes.Status200OK)]
        public Task<IActionResult> SaveAssignment(int id, [Required][FromBody] AssignmentSave assignment)
        {
            return Task.FromResult<IActionResult>(Ok(assignment));
        }

        /// <summary>
        /// Submits an assignment for the logged in user
        /// </summary>
        /// <param name="id">The assignment id to be submitted</param>
        /// <param name="assignment">The assignment to be submitted</param>
        /// <returns>Returns the submitted assignments for the user</returns>
        [HttpPost]
        [Route("{id}/submit")]
        [ProducesResponseType(typeof(AssignmentResponse), StatusCodes.Status200OK)]
        public Task<IActionResult> SaveAssignment(int id, [Required][FromBody] AssignmentSubmission assignment)
        {
            return Task.FromResult<IActionResult>(Ok(assignment));
        }
    }
}
