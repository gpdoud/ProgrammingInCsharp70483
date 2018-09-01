using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Practice {

	class O0104_MulticastingDelegates {

		public delegate void Message(string message);

		public static void Info(string message) { Console.WriteLine($"Info: {message}"); }
		public static void Warn(string message) { Console.WriteLine($"Warn: {message}"); }
		public static void Err(string message) { Console.WriteLine($"Err: {message}"); }

		public static void Start() {

			Message msg = Info;
			msg += Warn;
			msg += Err;
			msg("Info/Warn/Error Message");

			Console.ReadKey();
		}
	}
}
