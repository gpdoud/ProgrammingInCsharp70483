using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2.Practice {

	class O0204_IComparable {

		class Student : IComparable {
			public string Name;
			public int Age;

			public int CompareTo(object o) {
				var obj = o as Student;
				if (obj == null)
					throw new Exception("Item is not a student");
				return obj.Age - this.Age;
			}
		}

		public static void Start() {
			var students = new List<Student>() {
				new Student { Name = "Greg", Age = 61 },
				new Student { Name = "Cindy", Age = 64 },
				new Student { Name = "Nick", Age = 33 },
				new Student { Name = "Ken", Age = 27 }
			};

			students.Sort();

			foreach (var s in students) {
				Console.WriteLine($"Name: {s.Name}; Age: {s.Age}");
			}
		}
	}
}
