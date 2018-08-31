using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// Continuation after a task ends
	/// </summary>
	class L0110_Continuation_After_Task {

		public static void Start() {

			Task<int> t = Task.Run(() => {

				return 42;

			}).ContinueWith((i) => {

				return i.Result * 2;

			});

			Console.WriteLine(t.Result);

			Console.ReadKey();

		}
	}
}
