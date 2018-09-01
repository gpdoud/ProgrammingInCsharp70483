using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Practice {

	class O0104_UsingBuildInCalculateDelegate {

		//Calculate is a built-in delegate: delegate int Calculate(int x, int y)

		public delegate int Calculate(int x, int y);

		public static void Start() {

			Calculate add = (x, y) => x + y;

			var s = sqr(add(1, 2));

			log(s);

			Console.ReadKey();

		}

		/// <summary>
		/// Using lambda syntax to create a function (may return a value)
		/// </summary>
		public static Func<int, int> sqr = n => n * n;

		/// <summary>
		/// Using lambda syntax to create an action (may NOT return a value)
		/// </summary>
		public static Action<int> log = n => { Console.WriteLine(n); };
	}
}
