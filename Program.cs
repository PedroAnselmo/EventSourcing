using CargoControl;

var proc = new ProcessadorDeEventos();

var p = new Carga("Porra");
var mp = new Navio("Minha Pica");
var sb = new Porto("Sua Boca", EPais.BRASIL);
var sr = new Porto("Seu Cu", EPais.CANADA);
var sx = new Porto("Sua Xota", EPais.US);

proc.Processar(new ChegadaEvento(DateTime.Now, sb, mp));
proc.Processar(new CargaEvento(DateTime.Now, p, mp));
proc.Processar(new PartidaEvento(DateTime.Now, sb, mp));
proc.Processar(new ChegadaEvento(DateTime.Now, sx, mp));
proc.Processar(new DescargaEvento(DateTime.Now, p, sx));
proc.Processar(new PartidaEvento(DateTime.Now, sx, mp));
proc.Processar(new ChegadaEvento(DateTime.Now, sr, mp));
proc.Processar(new PartidaEvento(DateTime.Now, sr, mp));

Console.WriteLine($"{proc.Log}");