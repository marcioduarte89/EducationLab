namespace EducationLabAPI.Dtos.Output
{
    /// <summary>
    /// Question explanation
    /// </summary>
    public record QuestionExplanationResponse
    {
        /// <summary>
        /// Question id
        /// </summary>
        public int QuestionId { get; init; }

        /// <summary>
        /// Question explanation
        /// </summary>
        public string Explanation { get; init; } = default!;

        /// <summary>
        /// Question correct answer
        /// </summary>
        public string Answer { get; init; } = default!;
    }
}
