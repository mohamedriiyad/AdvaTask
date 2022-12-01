import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { error } from 'console';
import { Employee } from '../../_models/employee';
import { EmployeesService } from '../../_services/employees.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
    employees: Employee[];

    constructor(private employeesService: EmployeesService) { }

    ngOnInit() {
      this.getEmployees();
    }

    private getEmployees() {
        this.employeesService.getEmployees().subscribe(result => {
            this.employees = result;
        });
    }

    delete(id: number) {
      var confirmed = confirm('You want to delete this employee?');
      if (confirmed)
        this.employeesService.deleteEmployee(id).subscribe(result => {
          alert('Deleted successfuly');
          this.getEmployees();
        }, error => {
            alert('Somthing went wrong');
        });
    }
}
