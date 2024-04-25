namespace CargoControl;

public class PartidaEvento : DomainEvento
{
	internal Porto Porto { get; private set; }
	internal Navio Navio { get; private set; }

    public PartidaEvento(DateTime ocorrido, Porto porto, Navio navio) : base(ocorrido) {
		Porto = porto;
		Navio = navio;
	}

    internal override void Processo()
		=> Navio.Partir(this);

	internal override void Reverso()
		=> throw new NotImplementedException();

	internal override string Descricao()
		=> $"{Navio} saiu de {Porto} em {Ocorrido}";
}
