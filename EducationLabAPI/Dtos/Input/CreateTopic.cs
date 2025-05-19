namespace EducationLabAPI.Dtos.Input
{
    /// <summary>
    /// Creates a topic
    /// </summary>
    public class CreateTopic
    {
        /// <summary>
        /// Topic name
        /// </summary>
        public string Name { get; init; } = default!;

        // other parameters to be added here
    }
}
