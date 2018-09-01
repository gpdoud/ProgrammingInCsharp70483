using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Practice {

	class O0104_CreatingAndUsingADelegate {

		public delegate string Name(string first, string last);

		public static string FirstLast(string first, string last) { return $"{first} {last}";  }
		public static string LastFirst(string first, string last) { return $"{last}, {first}"; }

		public static void Start() {

			Name name = FirstLast;
			Console.WriteLine("FirstLast: " + name("Greg", "Doud"));
			name = LastFirst;
			Console.WriteLine("LastFirst: " + name("Greg", "Doud"));

			Console.ReadKey();
		}
	}
}
