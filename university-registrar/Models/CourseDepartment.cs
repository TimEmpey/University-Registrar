namespace UniversityRegistrar.Models
{
  public class CourseDepartment
  {       
    public int CourseDepartmentId { get; set; }
    public int DepartmentId { get; set; }
    public int CourseId { get; set; }
    public virtual Course Course { get; set; }
    public virtual Department Department { get; }
  }
}