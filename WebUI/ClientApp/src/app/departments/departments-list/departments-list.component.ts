import { Component, OnInit } from '@angular/core';
import { Department } from '../../_models/department';
import { DepartmentService } from '../../_services/department.service';

@Component({
  selector: 'app-departments-list',
  templateUrl: './departments-list.component.html',
  styleUrls: ['./departments-list.component.css']
})
export class DepartmentsListComponent implements OnInit {
  departments: Department[];

  constructor(private departmentService: DepartmentService) { }

  ngOnInit() {
    this.getDepartments();
  }

  private getDepartments() {
    this.departmentService.getDepartments().subscribe(result => {
      this.departments = result;
      console.log(this.departments)
    });
  }

  delete(id: number) {
    var confirmed = confirm('You want to delete this department?');
    if (confirmed)
      this.departmentService.deleteDepartment(id).subscribe(result => {
        alert('Deleted successfuly');
        this.getDepartments();
      }, error => {
        alert('Somthing went wrong');
      });
  }
}
