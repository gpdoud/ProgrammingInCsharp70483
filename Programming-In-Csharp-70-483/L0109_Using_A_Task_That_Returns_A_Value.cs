using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// A task that returns a value
	/// </summary>
	class L0109_Using_A_Task_That_Returns_A_Value {

		public static void Start() {

			Task<int> t = Task.Run(() => {

				return 42;

			});

			Console.WriteLine("The task returned {0}", t.Result);

			Console.ReadKey();

		}
	}
}
