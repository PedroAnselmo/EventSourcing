using System.Text;

namespace CargoControl;

public class Log
{
	public IList<DomainEvento> Logs { get; set; }

	public Log()
	{
		Logs = new List<DomainEvento>();
	}

	public void Adicionar(DomainEvento evento)
		=> Logs.Add(evento);

	public void Remover(DomainEvento evento)
		=> Logs.Remove(evento);

	public void Remover(IList<DomainEvento> eventos) {
		foreach (var log in Logs) Remover(log);
	}

	public void Limpar()
		=> Logs.Clear();


	public override string ToString()
	{
		var logsBuilder = new StringBuilder();

		foreach (var log in Logs)
		{
			logsBuilder.AppendLine(log.Descricao());
		}

		return logsBuilder.ToString();
	}
}