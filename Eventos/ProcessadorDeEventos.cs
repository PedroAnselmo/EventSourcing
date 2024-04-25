namespace CargoControl;

public class ProcessadorDeEventos
{
	public Log Log = new();

	public void Processar(DomainEvento evento) {
		evento.Processo();
		Log.Adicionar(evento);
	}
}