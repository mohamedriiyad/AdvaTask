import { Department } from "./department";

export interface Employee {
  id: number;
  name: string;
  salary: number;
  departmentId: number;
  department: Department;
}
