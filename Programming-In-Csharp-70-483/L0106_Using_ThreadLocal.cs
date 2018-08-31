using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1 {
	/// <summary>
	/// How to local data used by a thread
	/// </summary>
	class L0106_Using_ThreadLocal {

		public static ThreadLocal<int> _field =
			new ThreadLocal<int>(() => {

				return Thread.CurrentThread.ManagedThreadId;

			});

		public static void Start() {

			new Thread(() => {

				for(int x = 0; x < _field.Value; x++) {
					Console.WriteLine("Thread A: {0}", x);
				}

			}).Start();

			new Thread(() => {

				for (int x = 0; x < _field.Value; x++) {
					Console.WriteLine("Thread B: {0}", x);
				}

			}).Start();

			Console.ReadKey();

		}
	}
}
