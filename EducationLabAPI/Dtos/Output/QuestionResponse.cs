namespace EducationLabAPI.Dtos.Output
{
    /// <summary>
    /// Representation of a Question
    /// </summary>
    public class QuestionResponse
    {
        /// <summary>
        /// Question id
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Question name
        /// </summary>
        public string Name { get; init; } = default!;

        /// <summary>
        /// Question description
        /// </summary>
        public string Description { get; init; } = default!;

        /// <summary>
        /// Image Url
        /// </summary>
        public string ImageUrl { get; init; } = default!;

        /// <summary>
        /// Correct answer
        /// </summary>
        public string Answer { get; init; } = default!;

        /// <summary>
        /// Question explanation
        /// </summary>
        public string Explanation { get; init; } = default!;

        /// <summary>
        /// SubTopic
        /// </summary>
        public SubTopicResponse SubTopic { get; init; } = default!;

        // other parameters to be added here
    }
}
