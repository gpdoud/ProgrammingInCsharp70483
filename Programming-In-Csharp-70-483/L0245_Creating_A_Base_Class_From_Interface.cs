using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2 {

	class L0245_Creating_A_Base_Class_From_Interface {

		public static void Start() {
			Console.WriteLine("No execution - review the code.");
		}
	}

	interface IEntity {
		int Id { get; }
	}
	/// <summary>
	/// The generic class implements IEntity and
	/// requires that the generic Repository operate
	/// on types that also implement IEntity
	/// </summary>
	/// <typeparam name="T"></typeparam>
	class Repository<T> : IEntity where T : IEntity {

		public int Id { get; set; }

		protected IEnumerable<T> _elements;

		public Repository(IEnumerable<T> elements) {
			_elements = elements;
		}

		public T FindById(int id) {
			return _elements.SingleOrDefault(e => e.Id == id);
		}
	}
}
