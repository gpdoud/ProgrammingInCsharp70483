using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// Stopping a thread
	/// </summary>
	class L0104_Stopping_A_Thread {

		public static void Start() {
			bool stopped = false;

			Thread t = new Thread(new ThreadStart(() => {

				while (!stopped) {
					Console.WriteLine("Running...");
					Thread.Sleep(1000);
				}

			}));

			t.Start();
			Console.WriteLine("Press any key to exit");
			Console.ReadKey();

			stopped = true;
			t.Join();
		}

	}
}
