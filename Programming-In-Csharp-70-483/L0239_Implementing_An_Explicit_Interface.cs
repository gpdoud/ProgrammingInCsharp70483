using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2 {

	class L0239_Implementing_An_Explicit_Interface {

		interface IInterfaceA {

			void MyMethod();

		}

		class Implementation : IInterfaceA {

			void IInterfaceA.MyMethod() { }

		}

		public static void Start() {

			// MyMethod is hidden in impl
			var impl = new Implementation();
			// impl.MyMethod() -> error
			
			// impl must be cast to the interface to use MyMethod
			((IInterfaceA)impl).MyMethod();

		}
	}
}
