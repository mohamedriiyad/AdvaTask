import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Department } from '../../_models/department';
import { Employee } from '../../_models/employee';
import { DepartmentService } from '../../_services/department.service';
import { EmployeesService } from '../../_services/employees.service';

@Component({
  selector: 'app-edit-department',
  templateUrl: './edit-department.component.html',
  styleUrls: ['./edit-department.component.css']
})
export class EditDepartmentComponent implements OnInit {
  id: number;
  managers: Employee[];
  department: Department = { id: null, manager: null, managerId: null, name: "" };

  constructor(private route: ActivatedRoute,
    private employeeService: EmployeesService,
    private departmentSevice: DepartmentService) { }

  ngOnInit() {
    this.route.params.subscribe(params => this.id = params['id']);
    this.getDepartment();
    this.getManagers();
  }

  private getManagers() {
    this.employeeService.getEmployees().subscribe(result => {
      this.managers = result;
    });
  }

  private getDepartment() {
    this.departmentSevice.getDepartment(this.id).subscribe(result => {
      this.department = result;
    });
  }

  save() {
    this.departmentSevice.editDepartment(this.department).subscribe(result => {
      alert("Edited Successfully");
    }, error => {
      alert("There is a department with this Manager");
    });
  }
}
