using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
	public class DietInfoCareTaker : DietInfo
	{
		protected ArrayList<DietInfoMemento> estados;

		public DietInfoCareTaker()
		{
			this.estados = new ArrayList<>();
		}

		public void adicionarMemento(DietInfoMemento memento)
		{
			this.estados.add(memento);
		}

		public DietInfoMemento getUltimoEstadoSalvo()
		{
			if (estados.isEmpty())
				return new DietInfoMemento("", "", "");

			DietInfoMemento estadoSalvo = estados.get(estados.size() - 1);
			estados.remove(estados.size() - 1);

			return estadoSalvo;
		}
	}
}
