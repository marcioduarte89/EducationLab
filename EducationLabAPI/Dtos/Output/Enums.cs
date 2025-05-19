namespace EducationLabAPI.Dtos.Output
{
    /// <summary>
    /// Assignment status
    /// </summary>
    public enum AssignmentStatus
    {
        /// <summary>
        /// Draft - represents an assignment has not yet been submitted (ie. just created, or saved by the student)
        /// </summary>
        Draft,

        /// <summary>
        /// Completed assignment
        /// </summary>
        Completed,

        /// <summary>
        /// Cancelled assignment
        /// </summary>
        Cancelled
    }
}
