namespace EducationLabAPI.Dtos.Output
{
    /// <summary>
    /// Topic covered in the assignment
    /// </summary>
    public record AssignmentTopicsResponse
    {
        /// <summary>
        /// Topic id
        /// </summary>
        public int TopicId { get; init; }

        /// <summary>
        /// Topic Name
        /// </summary>
        public string Name { get; init; } = default!;

        /// <summary>
        /// Sub topic covered in the Assignment
        /// </summary>
        public IEnumerable<AssignmentSubTopicResponse> SubTopics { get; init; } = Enumerable.Empty<AssignmentSubTopicResponse>();
    }
}
