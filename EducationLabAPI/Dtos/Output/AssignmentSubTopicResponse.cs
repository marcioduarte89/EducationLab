namespace EducationLabAPI.Dtos.Output
{
    /// <summary>
    /// Sub Topic details for an assessment 
    /// </summary>
    public record AssignmentSubTopicResponse
    {
        /// <summary>
        /// SubTopic Id
        /// </summary>
        public int SubTopicId { get; init; }

        /// <summary>
        /// SubTopic Name
        /// </summary>
        public string Name { get; init; } = default!;

        /// <summary>
        /// Proposed questions of a sub topic for a specific assessment
        /// </summary>
        public IEnumerable<AssignmentQuestionResponse> Questions { get; init; } = Enumerable.Empty<AssignmentQuestionResponse>();
    }
}
