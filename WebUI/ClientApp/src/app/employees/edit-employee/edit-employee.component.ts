import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Department } from '../../_models/department';
import { Employee } from '../../_models/employee';
import { DepartmentService } from '../../_services/department.service';
import { EmployeesService } from '../../_services/employees.service';

@Component({
  selector: 'app-edit-employee',
  templateUrl: './edit-employee.component.html',
  styleUrls: ['./edit-employee.component.css']
})
export class EditEmployeeComponent implements OnInit {
  id: number;
  employee: Employee = { name: "", departmentId: null, id: 0, salary: null, department: null };
  departments: Department[];

  constructor(private route: ActivatedRoute,
    private employeeService: EmployeesService,
    private departmentSevice: DepartmentService) { }

  ngOnInit() {
    this.route.params.subscribe(params => this.id = params['id']);
    this.getEmployee();
    this.getDepartments();
  }

    private getDepartments() {
        this.departmentSevice.getDepartments().subscribe(result => {
            this.departments = result;
        });
    }

    private getEmployee() {
        this.employeeService.getEmployee(this.id).subscribe(result => {
            this.employee = result;
        });
    }

    save() {
      this.employeeService.editEmployee(this.employee).subscribe(result => {
        alert("Edited Successfully");
      }, error => {
          alert("Somthing went wrong");
      });
  }
}
