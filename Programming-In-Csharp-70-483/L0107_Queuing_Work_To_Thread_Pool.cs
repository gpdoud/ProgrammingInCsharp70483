using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// Submitting work to the thread pool
	/// </summary>
	class L0107_Queuing_Work_To_Thread_Pool {

		public static void Start() {

			ThreadPool.QueueUserWorkItem((s) => {

				Console.WriteLine("Working on a thread from threadpool");

			});

			Console.ReadKey();

		}
	}
}
