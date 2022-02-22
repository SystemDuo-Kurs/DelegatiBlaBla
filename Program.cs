internal static class Delegati
{
    public static void Main()
    {
        Predavac p = new();
        Polaznik po1 = new Polaznik { _ime = "Pera" };
        Polaznik po2 = new Polaznik { _ime = "Neko" };
        Polaznik po3 = new Polaznik { _ime = "Trecko" };
        Diktafon d = new();
        p._diktafons.Add(d);

        p._polaznici.Add(po1);
        p._polaznici.Add(po2);
        p._polaznici.Add(po3);

        p.Brbljanje("Bla bla bla truc truc");
    }
}

internal class Predavac
{
    public string _ime;
    public List<Polaznik> _polaznici = new();
    public List<Diktafon> _diktafons = new();

    public void Brbljanje(string prica)
    {
        _polaznici.ForEach(p => p.Slusanje(prica));
        _diktafons.ForEach(d => d.Snimanje(prica));
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