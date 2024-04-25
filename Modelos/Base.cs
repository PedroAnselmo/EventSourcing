namespace CargoControl;

public class Base
{
	internal string Nome { get; set; }

	internal Base(string nome) => Nome = nome;

	public override string ToString() => Nome;
}
