namespace EducationLabAPI.Dtos.Output
{
    /// <summary>
    /// Questions for a specific Assignment
    /// </summary>
    public record AssignmentQuestionResponse
    {
        /// <summary>
        /// Question id
        /// </summary>
        public int QuestionId { get; init; }

        /// <summary>
        /// To be fetched by the client, served by CDN, for example
        /// </summary>
        public string ImageUrl { get; init; } = default!;

        /// <summary>
        /// Answer given by the user for the Assignment question
        /// </summary>
        public string? UsersAnswer { get; init; }

        /// <summary>
        /// Whether the answer given for the assignment is correct
        /// </summary>
        public bool? IsAnswerCorrect { get; init; }
    }
}
