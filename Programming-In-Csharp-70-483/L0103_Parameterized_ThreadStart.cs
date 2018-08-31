using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// How to pass a parameter to a thread
	/// </summary>
	class L0103_Parameterized_ThreadStart {

		public static void ThreadMethod(object o) {
			for(int i = 0; i < (int)o; i++) {
				Console.WriteLine("ThreadProc: {0}", i);
				Thread.Sleep(0);
			}
		}

		public static void Start() {
			Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
			t.Start(5);
			t.Join();
		}
	}
}
