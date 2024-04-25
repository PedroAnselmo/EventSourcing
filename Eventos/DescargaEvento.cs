namespace CargoControl;

public class DescargaEvento : DomainEvento
{
	internal Carga Carga { get; set; }
	internal Porto Porto { get; set; }
	internal Navio? NavioAnterior { get; set; }


	internal DescargaEvento(DateTime ocorrido, Carga carga, Porto porto) : base(ocorrido)
    {
		Carga = carga;
		Porto = porto;
	}

    internal override void Processo()
		=> Carga.Descargar(this);

	internal override void Reverso()
		=> Carga.DescargarReverso(this);

	internal override string Descricao()
		=> $"{NavioAnterior} descarregou {Carga} em {Porto} em {Ocorrido}";
}
