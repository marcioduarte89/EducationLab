namespace EducationLabAPI.Dtos.Input
{
    /// <summary>
    /// Creates a question
    /// </summary>
    public class CreateQuestion
    {
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
    }
}
