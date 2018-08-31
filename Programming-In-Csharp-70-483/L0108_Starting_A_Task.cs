using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// Starting a task
	/// </summary>
	class L0108_Starting_A_Task {

		public static void Start() {

			// start the task immediately
			Task t = Task.Run(() => {

				for(int x = 0; x < 100; x++) {
					Console.Write('*');
				}

			});

			// wait until the task finished
			// before ending the app
			t.Wait();

		}
	}
}
