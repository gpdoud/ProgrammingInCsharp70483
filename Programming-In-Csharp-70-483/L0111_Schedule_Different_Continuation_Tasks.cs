using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// Process different continuation tasks
	/// </summary>
	class L0111_Schedule_Different_Continuation_Tasks {

		public static void Start() {

			Task<int> t = Task.Run(() => {

				return 42;

			});

			t.ContinueWith((i) => {
				Console.WriteLine("Canceled");
			}, TaskContinuationOptions.OnlyOnCanceled);

			t.ContinueWith((i) => {
				Console.WriteLine("Faulted");
			}, TaskContinuationOptions.OnlyOnFaulted);

			var completedTask = t.ContinueWith((i) => {
				Console.WriteLine("Completed");
			}, TaskContinuationOptions.OnlyOnRanToCompletion);

			completedTask.Wait();

			Console.ReadKey();

		}

	}
}
