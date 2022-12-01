import { Component, OnInit } from '@angular/core';
import { Department } from '../../_models/department';
import { Employee } from '../../_models/employee';
import { DepartmentService } from '../../_services/department.service';
import { EmployeesService } from '../../_services/employees.service';

@Component({
  selector: 'app-create-employee',
  templateUrl: './create-employee.component.html',
  styleUrls: ['./create-employee.component.css']
})
export class CreateEmployeeComponent implements OnInit {
  employee: Employee = { name: "", departmentId: null, id: 0, salary: null, department: null };
  departments: Department[];

  constructor(private employeeService: EmployeesService,
    private departmentSevice: DepartmentService) { }

  ngOnInit() {
    this.getDepartments();
  }

  private getDepartments() {
    this.departmentSevice.getDepartments().subscribe(result => {
      this.departments = result;
      console.log(this.departments)
    });
  }

  create() {
    this.employeeService.createEmployee(this.employee).subscribe(result => {
        alert("Created Successfully");
    }, error => {
        alert("Somthing went wrong");
    });
  }
}
