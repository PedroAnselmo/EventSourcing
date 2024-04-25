

namespace CargoControl;

public class Navio : Base
{
	public Porto? Porto { get; private set; }
	public List<Carga> Cargas { get; private set; } = new();

	public Navio(string nome) : base(nome)
		=> Nome = nome;

	internal void Partir(PartidaEvento evento)
		=> Porto = null;

	internal void Chegar(ChegadaEvento evento)
    {
		Porto = evento.Porto;
		foreach (var carga in Cargas)
			carga.Chegar(evento);
	}

	internal void Cargar(CargaEvento evento)
		=> Cargas.Add(evento.Carga);

	internal void CargarReverso(CargaEvento evento)
	 	=> Cargas.Remove(evento.Carga);

	public override string ToString() => Nome;
}
