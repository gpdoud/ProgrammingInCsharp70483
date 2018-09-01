using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Practice {

	class O0104_DefiningAndRaisingEventsUsingAction {

		public static Action OnFire { get; set; }

		public static void Fire() {

			if (OnFire != null)
				OnFire();

		}

		public static void Start() {

			OnFire += () => Console.WriteLine("1st method");
			OnFire += () => Console.WriteLine("2nd method");
			OnFire += () => Console.WriteLine("3rd method");
			Fire();

			Console.ReadKey();

		}

	}
}
