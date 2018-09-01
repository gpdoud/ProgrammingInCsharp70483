using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1 {

	class EventEnabledObjectArgs : EventArgs {

		public int Value { get; set; }

	}

	class EventEnabledObject {
		/// <summary>
		/// A customer event accessor allows control as to what can
		/// be attached to the event
		/// </summary>
		private event EventHandler<EventEnabledObjectArgs> onChange = delegate { };
		public event EventHandler<EventEnabledObjectArgs> OnChange {
			add {
				// this lock is required to make it thread safe
				lock(onChange) {
					onChange += value;
				}
			}
			remove {
				lock(onChange) {
					onChange -= value;
				}
			}
		}

		public void Raise() {
			if(onChange != null) {
				onChange("self", new EventEnabledObjectArgs { Value = -1 });
			}
		}

	}

	class L0185_Custom_Event_Accessor {

		public static void Start() {

			var eeo = new EventEnabledObject();

			eeo.OnChange += (self, e) => Console.WriteLine($"self: {self}; e.Value: {e.Value}");

			eeo.Raise();

			Console.ReadKey();

		}
	}
}
