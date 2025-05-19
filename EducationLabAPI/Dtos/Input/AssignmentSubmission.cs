namespace EducationLabAPI.Dtos.Input
{
    /// <summary>
    /// A representation of an assignment submission (either to be submitted or saved)
    /// </summary>
    public class AssignmentSubmission
    {
        /// <summary>
        /// The Answers submitted or saved
        /// </summary>
        public IEnumerable<CreateAssignmentAnswer> Answers { get; set; } = Enumerable.Empty<CreateAssignmentAnswer>();
    }

    /// <summary>
    /// A representation of saving an assignment
    /// </summary>
    public class AssignmentSave : AssignmentSubmission { }
}
