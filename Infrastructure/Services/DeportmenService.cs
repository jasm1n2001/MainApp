using Domain.Models;

namespace Infrastructure.Services;

public class DepartmentService
{
    List<Department> _departments;

    public DepartmentService()
    {
        _departments = new List<Department>();
    }


    public List<Department> GetDepartments()
    {
        return _departments;
    }

    public void AddDepartment(Department Department)  
    {
        Department.Id = _departments.Count + 1;
        _departments.Add(Department);
    }  

    public Department UpdateDepartment(Department Department)
    {
        foreach (var e in _departments)
        {
            if ( e.Id == Department.Id )
            {
                e.FirstName = Department.FirstName;
                e.LastName = Department.LastName;
                e.BirthDate = Department.BirthDate;
                e.Salary = Department.Salary;
                e.Department.Name = Department.Department.Name;
                e.Department.Description = Department.Department.Description; 

                return e;
            }
        }
        return null;
    }

    public string DeleteDepartment(int id)
    {

        
        foreach (var e in _departments)
        {
            if (e.Id == id)
            {
                _departments.Remove(e);
                return "Department deleted successfully";
            }
        }
        return "Department not found";
    }
}