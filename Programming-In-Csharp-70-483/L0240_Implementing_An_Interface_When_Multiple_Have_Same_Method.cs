using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2 {

	class L0240_Implementing_An_Interface_When_Multiple_Have_Same_Method {

		interface ILeft {
			void Move();
		}
		interface IRight {
			void Move();
		}

		/// <summary>
		/// The implementation requires using the explicit
		/// interface because the class implements more than
		/// one interface with the same method
		/// </summary>
		class MoveableObject : ILeft, IRight {
			void ILeft.Move() { }
			void IRight.Move() { }
		}

		public static void Start() {
			Console.WriteLine("No execution - review the code.");
		}
	}
}
