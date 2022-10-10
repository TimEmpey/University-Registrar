using System.Collections.Generic;

namespace UniversityRegistrar.Models

{
  public class Department
  {
    public int DepartmentId { get; set; }
    public string Name {get; set; }
    public virtual ICollection<CourseDepartment> JoinEntities { get; set; }
  }
}