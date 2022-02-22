internal static class Delegati
{
    public static void Main()
    {
        Predavac p = new();
        Polaznik po1 = new Polaznik { _ime = "Pera" };
        Polaznik po2 = new Polaznik { _ime = "Neko" };
        Polaznik po3 = new Polaznik { _ime = "Trecko" };
        Diktafon d = new();

        //p._delegatZaGovor += po1.Slusanje;
        p._delegatZaGovor += d.Snimanje;
        //p._delegatZaGovor += po2.Slusanje;
        //p._delegatZaGovor -= po3.Slusanje;

        p.Brbljanje("Bla bla bla truc truc");
    }
}

internal class Predavac
{
    public string _ime;

    public delegate void TipDelegata(string bla);

    public event TipDelegata _delegatZaGovor;

    public void Brbljanje(string prica)
    {
        _delegatZaGovor?.Invoke(prica);
    }
}

internal class Polaznik
{
    public string _ime;

    public void Slusanje(string cuo)
    {
        Console.WriteLine($"{_ime} je cuo {cuo}");
    }
}

internal class Diktafon
{
    public void Snimanje(string govor)
    {
        Console.WriteLine($"Diktafon snima {govor}");
    }
}