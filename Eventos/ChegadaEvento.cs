namespace CargoControl;

public class ChegadaEvento : DomainEvento
{
	internal Porto Porto { get; private set; }
	internal Navio Navio { get; private set; }

	public ChegadaEvento(DateTime ocorrido, Porto porto, Navio navio) : base(ocorrido)
    {
		Porto = porto;
		Navio = navio;
	}

	internal override void Processo()
		=> Navio.Chegar(this);

	internal override void Reverso()
		=> throw new NotImplementedException();

	internal override string Descricao()
		=> $"{Navio} chegou em {Porto} em {Ocorrido}";
}
