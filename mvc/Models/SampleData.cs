using System.Collections.Generic;

namespace DataGridFileUploader.Models {
    static class SampleData {
        public static readonly IEnumerable<Employee> Employees = new[] {
            new Employee {
                ID = 1,
                FirstName = "John",
                LastName = "Heart",
                Picture = "01.png"
            },
            new Employee {
                ID = 2,
                FirstName = "Olivia",
                LastName = "Peyton",
                Picture = "02.png"
            },
        };
    }
}