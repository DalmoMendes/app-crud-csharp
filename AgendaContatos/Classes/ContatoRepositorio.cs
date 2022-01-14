using System;
using System.Collections.Generic;
using AgendaContatos.Interfaces;

namespace AgendaContatos
{
	public class ContatoRepositorio : IRepositorio<Contato>
	{
		private List<Contato> listaContato = new List<Contato>();
		public void Atualiza(int id, Contato objeto)
		{
			listaContato[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaContato[id].Excluir();
		}

		public void Insere(Contato objeto)
		{
			listaContato.Add(objeto);
		}

		public List<Contato> Lista()
		{
			return listaContato;
		}

		public int ProximoId()
		{
			return listaContato.Count;
		}

		public Contato RetornaPorId(int id)
		{
			return listaContato[id];
		}
	}
}
