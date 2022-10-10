namespace UniversityRegistrar.Models
{
  public class CourseStudent
  {       
    public int CourseStudentId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public virtual Student Student { get; set; }
    public virtual Course Course { get; set; }
  }
}