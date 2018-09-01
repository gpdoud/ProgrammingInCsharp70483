using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// Environment.FailFast to immediately shutdown
	/// without executing the finally block
	/// </summary>
	class L0192_Using_Environment_FailFast {

		public static void Start() {

			string s = Console.ReadLine();

			try {

				int i = int.Parse(s);
				if (i == 42)
					Environment.FailFast("Special number 42 entered.");

			} finally {

				Console.WriteLine("Program complete.");

			}
		}
	}
}
