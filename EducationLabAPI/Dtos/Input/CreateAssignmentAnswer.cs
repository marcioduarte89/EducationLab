namespace EducationLabAPI.Dtos.Input
{
    /// <summary>
    /// A representation of a Assignment answer to be submitted or saved
    /// </summary>
    public class CreateAssignmentAnswer
    {
        /// <summary>
        /// Question id
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// Answer to the question
        /// </summary>
        public string Answer { get; set; } = default!;
    }
}
