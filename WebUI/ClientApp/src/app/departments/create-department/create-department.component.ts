import { Component, OnInit } from '@angular/core';
import { Department } from '../../_models/department';
import { Employee } from '../../_models/employee';
import { DepartmentService } from '../../_services/department.service';
import { EmployeesService } from '../../_services/employees.service';

@Component({
  selector: 'app-create-department',
  templateUrl: './create-department.component.html',
  styleUrls: ['./create-department.component.css']
})
export class CreateDepartmentComponent implements OnInit {
  managers: Employee[];
  department: Department = { id: null, manager: null, managerId: null, name: "" };

  constructor(private employeeService: EmployeesService,
    private departmentSevice: DepartmentService) { }

  ngOnInit() {
    this.getEmployees();
  }

  private getEmployees() {
    this.employeeService.getEmployees().subscribe(result => {
      this.managers = result;
    });
  }

  create() {
    this.departmentSevice.createDepartment(this.department).subscribe(result => {
      alert("Created Successfully");
    }, error => {
        alert(error.error);
    });
  }
}
