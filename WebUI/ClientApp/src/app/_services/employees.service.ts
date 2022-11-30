import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Employee } from '../_models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {
  baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getEmployees() {
    return this.http.get<Employee[]>(this.baseUrl + 'employees/get');
  }

  getEmployee(id: number) {
    return this.http.get<Employee>(this.baseUrl + 'employees/get/' + id);
  }

  createEmployee(employee: Employee) {
    return this.http.post(this.baseUrl + 'employees/create', employee);
  }

  editEmployee(employee: Employee) {
    return this.http.put(this.baseUrl + 'employees/edit', employee);
  }

  deleteEmployee(id: number) {
    return this.http.delete(this.baseUrl + 'employees/edit/' + id);
  }
}
