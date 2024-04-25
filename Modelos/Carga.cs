
namespace CargoControl;

public class Carga : Base
{
	public Porto? Porto { get; set; }

	public Navio? Navio { get; set; }

	public bool EsteveNoCanada { get; private set; }

	public Carga(string nome) : base(nome) => Nome = nome;

	internal void Chegar(ChegadaEvento evento)
    {
        if(evento.Porto.Pais == EPais.CANADA)
			EsteveNoCanada = true;
    }

	internal void Cargar(CargaEvento evento)
	{
		evento.PortoAnterior = evento.Navio.Porto;
		Porto = null;

		Navio = evento.Navio;
		Navio.Cargar(evento);
	}

	internal void CargarReverso(CargaEvento evento)
	{
		Navio!.CargarReverso(evento);
		Navio = null;

		Porto = evento.PortoAnterior;
	}

	internal void Descargar(DescargaEvento evento)
	{
		evento.NavioAnterior = Navio;
		Navio = null;

		Porto = evento.Porto;
	}

	internal void DescargarReverso(DescargaEvento evento)
	{
		Navio = evento.NavioAnterior;

		Porto = null;
	}
}