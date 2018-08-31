using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// Create a background thread
	/// </summary>
	class L0102_UsingABackgroundThread {

		public static void ThreadMethod() {
			for(int i = 0; i < 10; i++) {
				Console.WriteLine("ThreadProc: {0}", i);
				Thread.Sleep(1000);
			}
		}

		public static void Start() {
			Thread t = new Thread(new ThreadStart(ThreadMethod));
			// change to false to print msg 10 times
			t.IsBackground = true;
			t.Start();

			for(int i = 0; i < 4; i++) {
				Console.WriteLine("Main thread: Do some work.");
				Thread.Sleep(0);
			}

			t.Join(); // let other threads finish
		}
	}
}
