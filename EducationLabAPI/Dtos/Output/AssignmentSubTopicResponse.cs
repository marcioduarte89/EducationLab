namespace EducationLabAPI.Dtos.Output
{
    /// <summary>
    /// Sub Topic details for an assessment 
    /// </summary>
    public record AssignmentSubTopicResponse
    {
        /// <summary>
        /// Topic Id
        /// </summary>
        public int SubTopicId { get; init; }

        /// <summary>
        /// Topic Name
        /// </summary>
        public string Name { get; init; } = default!;

        /// <summary>
        /// Proposed questions of a sub topic for a specific assessment
        /// </summary>
        public IEnumerable<AssignmentQuestionResponse> Questions { get; init; } = Enumerable.Empty<AssignmentQuestionResponse>();
    }
}
