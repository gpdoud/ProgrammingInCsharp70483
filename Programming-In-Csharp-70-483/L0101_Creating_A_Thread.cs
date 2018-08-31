using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// Creating a thread
	/// </summary>
	class L0101_Creating_A_Thread {

		public static void ThreadMethod() {
			for (int i = 0; i < 10; i++) {
				Console.WriteLine("ThreadProc: {0}", i);
				Thread.Sleep(0);
			}
		}

		public static void Start() {
			Thread t = new Thread(new ThreadStart(ThreadMethod));
			t.Start();

			for (int i = 0; i < 4; i++) {
				Console.WriteLine("Main thread: Do some work.");
				Thread.Sleep(0);
			}

			t.Join(); // let other threads finish
		}
	}
}
