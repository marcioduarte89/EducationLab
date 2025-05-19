namespace EducationLabAPI.Dtos.Input
{
    /// <summary>
    /// Creates a specific Assignment
    /// </summary>
    public class CreateAssignment
    {
        /// <summary>
        /// Assignment name
        /// </summary>
        public string Name { get; init; } = default!;

        /// <summary>
        /// User assignment to the assignment
        /// </summary>
        public int UserId { get; init; }

        /// <summary>
        /// Question ids in the assignment
        /// </summary>
        public IEnumerable<int> QuestionIds { get; init; } = Enumerable.Empty<int>();
    }
}
