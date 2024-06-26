﻿namespace MinimalAPI_Microservices.Model;

public interface IDataRepository
{
    List<Employee> AddEmployee(Employee employee);
    List<Employee> GetEmployees();
    Employee PutEmployee(Employee employee);
    Employee GetEmployeeById(string id);
}