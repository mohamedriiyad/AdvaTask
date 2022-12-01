import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Department } from '../_models/department';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getDepartments() {
    return this.http.get<Department[]>(this.baseUrl + 'departments/get');
  }

  getDepartment(id: number) {
    return this.http.get<Department>(this.baseUrl + 'departments/get/' + id);
  }

  createDepartment(department: Department) {
    return this.http.post(this.baseUrl + 'departments/create', department);
  }

  editDepartment(department: Department) {
    return this.http.put(this.baseUrl + 'departments/edit', department);
  }

  deleteDepartment(id: number) {
    return this.http.delete(this.baseUrl + 'departments/edit/' + id);
  }
}
