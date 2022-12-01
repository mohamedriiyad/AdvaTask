import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { EmployeesComponent } from './employees/employees/employees.component';
import { EditEmployeeComponent } from './employees/edit-employee/edit-employee.component';
import { CreateEmployeeComponent } from './employees/create-employee/create-employee.component';
import { DepartmentsListComponent } from './departments/departments-list/departments-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    EmployeesComponent,
    EditEmployeeComponent,
    CreateEmployeeComponent,
    DepartmentsListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'employees', component: EmployeesComponent },
      { path: 'departments', component: DepartmentsListComponent },
      { path: 'edit-employee/:id', component: EditEmployeeComponent },
      { path: 'create-employee', component: CreateEmployeeComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
