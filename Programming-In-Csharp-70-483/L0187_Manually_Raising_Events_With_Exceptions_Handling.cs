using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1 {

	class L0187_Manually_Raising_Events_With_Exceptions_Handling {

		class EventEnabledObject {

			public event EventHandler OnChange = delegate { };
			public void Raise() {

				var exceptions = new List<Exception>();

				foreach(var handler in OnChange.GetInvocationList()) {

					try {
						handler.DynamicInvoke("self", EventArgs.Empty);
					} catch (Exception ex) {
						exceptions.Add(ex);
					}
				}
				if(exceptions.Any()) {
					throw new AggregateException(exceptions);
				}
			}
		}

		public static void Start() {

			var eeo = new EventEnabledObject();

			eeo.OnChange += (sender, e) => Console.WriteLine("1st method");

			eeo.OnChange += (sender, e) => throw new Exception();

			eeo.OnChange += (sender, e) => Console.WriteLine("3rd method");

			eeo.Raise();
		}
	}
}
