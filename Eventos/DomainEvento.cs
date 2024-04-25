namespace CargoControl;

public abstract class DomainEvento
{
	internal DateTime Gravado { get; private set; }
	internal DateTime Ocorrido { get; private set; }

	internal DomainEvento(DateTime ocorrido)
	{
		Ocorrido = ocorrido;
		Gravado = DateTime.Now;
	}

	abstract internal void Processo();
	abstract internal void Reverso();

	abstract internal string Descricao();
}
