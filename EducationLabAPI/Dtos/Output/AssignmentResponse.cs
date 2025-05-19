namespace EducationLabAPI.Dtos.Output
{
    /// <summary>
    /// Assignment response
    /// </summary>
    public record AssignmentResponse
    {
        /// <summary>
        /// Assignment TopicId
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Assignment name
        /// </summary>
        public string Name { get; init; } = default!;

        /// <summary>
        /// Assignment status
        /// </summary>
        public AssignmentStatus Status { get; init; }

        /// <summary>
        /// Topic covered in the Assignment
        /// </summary>
        public IEnumerable<AssignmentTopicsResponse> Topics { get; init; } = Enumerable.Empty<AssignmentTopicsResponse>();
    }
}
