
namespace CargoControl;

public class Porto : Base
{
	public EPais Pais { get; private set; }

	public Porto(string nome, EPais pais) : base(nome)
	{
		Nome = nome;
		Pais = pais;
	}

	public override string ToString() => Nome;
}
