using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.Practice {

	class MyEventArgs : EventArgs {

		public string value { get; set; }

		public MyEventArgs(string value) { this.value = value; }
	}

	class EventEnabledObject {

		public event EventHandler<MyEventArgs> OnFire = delegate { };

		public void Fire() {

			OnFire("self", new MyEventArgs("Fired!"));

		}
	}

	class O0104_EventsUsingEventType {


		public static void Start() {

			EventEnabledObject o = new EventEnabledObject();

			o.OnFire += (sender, e) => Console.WriteLine($"sender {sender}, e.value {e.value}");

			o.Fire();

			Console.ReadKey();

		}
	}
}
