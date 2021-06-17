using System;
using System.Collections.Generic;


namespace XmlDbDemo
{
    public class EmployeeDetail
    {
        public int id;
        public string employeeName;
        public int age;
        public List<AddressDetail> addressDetail;
        public Salary salary;
        public Department DepartmentDetail;

        public List<EmployeeDetail> GetEmployeeList()
        {
            Random random = new Random();
            List<EmployeeDetail> employeeList = new List<EmployeeDetail>();
            for (int i = 1; i < 10; i++)
            {

                EmployeeDetail employeeDetail = new EmployeeDetail();
                Salary sal = new Salary();
                Department dp = new Department();

                employeeDetail.id = i;
                employeeDetail.employeeName = "Employee" + i.ToString();
                employeeDetail.age = random.Next(20, 61);

                List<AddressDetail> addressList = new List<AddressDetail>();
                for (int j = i; j < i+2; j++)
                {
                    AddressDetail ad = new AddressDetail();
                    ad.Id = i;
                    ad.HouseNumber = j + i - 1;
                    ad.HouseName = "House" + (j + i - 1).ToString();
                    addressList.Add(ad);
                }
                employeeDetail.addressDetail = addressList;

                sal.Id = i;
                sal.SalaryOfEmployee = random.Next(20, 61) * 1000;
                employeeDetail.salary = sal;

                dp.Id = i;
                dp.DepartmentId = random.Next(1, 21);
                dp.DepartmentName = "Department" + dp.DepartmentId.ToString();
                employeeDetail.DepartmentDetail = dp;

                employeeList.Add(employeeDetail);
            }
            return employeeList;
        }

    }
}
