using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2 {

	class L0248_Hiding_A_Method_With_The_New_Keyword {

		public static void Start() {
			Base b = new Base();
			b.Execute(); // displays Base.Execute()
			b = new Derived();
			b.Execute(); // also displays Base.Execute() because not virtual/override
			Derived d = new Derived();
			d.Execute(); // displays Derived.Execute()
		}

	}

	class Base {
		public void Execute() {
			Console.WriteLine("Base.Execute()");
		}
	}

	class Derived : Base {
		public new void Execute() {
			Console.WriteLine("Derived.Execute()");
		}
	}
}
