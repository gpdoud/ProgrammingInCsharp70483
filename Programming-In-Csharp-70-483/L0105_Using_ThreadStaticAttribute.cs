using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1 {

	/// <summary>
	/// Declare a static variable unique to each thread
	/// without [ThreadStatic], both thread share the variable
	/// </summary>
	class L0105_Using_ThreadStaticAttribute {

		[ThreadStatic]
		public static int _field;

		public static void Start() {

			new Thread(() => {

				for (int x = 0; x < 10; x++) {
					_field++;
					Console.WriteLine("Thread A: {0}", _field);
				}

			}).Start();

			new Thread(() => {

				for(int x = 0; x < 10; x++) {
					_field++;
					Console.WriteLine("Thread B: {0}", _field);
				}

			}).Start();

			Console.ReadKey();
		}
	}
}
