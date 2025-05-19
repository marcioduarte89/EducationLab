namespace EducationLabAPI.Dtos.Output
{
    /// <summary>
    /// Representation of a SubTopic
    /// </summary>
    public class SubTopicResponse
    {
        /// <summary>
        /// Sub topic id
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Sub Topic name
        /// </summary>
        public string Name { get; init; } = default!;

        /// <summary>
        /// The topic belonging to the subtopic
        /// </summary>
        public TopicResponse Topic { get; init; } = default!;

        // other parameters to be added here
    }
}
