namespace MinimalAPI_Microservices.Model;

public class DataSeeder
{
    private readonly EmployeeDbContext employeeDbContext;

    public DataSeeder(EmployeeDbContext employeeDbContext)
    {
        this.employeeDbContext = employeeDbContext;
    }

    public void Seed()
    {
        if (!employeeDbContext.Employee.Any())
        {
            var employees = new List<Employee>()
                {
                        new Employee()
                        {
                            Name = "Javi",
                            Citizenship = "Spain",
                            EmployeeId = "1"
                        },
                        new Employee()
                        {
                            Name = "Javi2",
                            Citizenship = "US",
                            EmployeeId = "2"
                        }
                };

            employeeDbContext.Employee.AddRange(employees);
            employeeDbContext.SaveChanges();
        }
    }
}