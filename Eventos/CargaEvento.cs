namespace CargoControl;

public class CargaEvento : DomainEvento
{
	internal Carga Carga { get; private set; }
	internal Navio Navio { get; private set; }

	internal Porto? PortoAnterior { get; set; }

	public CargaEvento(DateTime ocorrido, Carga carga, Navio navio) : base(ocorrido)
    {
		Carga = carga;
		Navio = navio;
	}

    internal override void Processo()
		=> Carga.Cargar(this);

	internal override void Reverso()
		=> Carga.CargarReverso(this);

	internal override string Descricao()
		=> $"{PortoAnterior} carregou {Carga} em {Navio} em {Ocorrido}";
}
