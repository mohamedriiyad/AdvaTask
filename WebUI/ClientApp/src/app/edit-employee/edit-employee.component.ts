import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from '../_models/employee';
import { EmployeesService } from '../_services/employees.service';

@Component({
  selector: 'app-edit-employee',
  templateUrl: './edit-employee.component.html',
  styleUrls: ['./edit-employee.component.css']
})
export class EditEmployeeComponent implements OnInit {
  id: number;
  employee: Employee;

  constructor(private route: ActivatedRoute, private employeeService: EmployeesService) { }

  ngOnInit() {
    this.route.params
      .subscribe(params => {
        this.id = params['id']; 
      });

    this.employeeService.getEmployee(this.id).subscribe(result => {
      this.employee = result;
      console.log(this.employee);
    })
  }
  log() {
    console.log(this.employee.name)
    console.log(this.employee.salary)
  }

}
