class Sport
{
    enum Pilka
    {
        Reczna,Nozna,Siatkowa,Koszykowka
    }

    enum SprzetSportowy
    {
        Kij,Pilka,Lotki,Paletki,Rakiety
    }
    enum Wyniki
    {
        Gole=10,
        Mecze=15,
        ZolteKartki=7,
        
    }
    static int razem = (int)Wyniki.Gole + (int)Wyniki.Mecze + (int)Wyniki.ZolteKartki;
    

    static void Main(string[] args)
    {
        Pilka pilka = Pilka.Reczna;
        
        Console.WriteLine(SprzetSportowy.Pilka);
        Console.WriteLine(Pilka.Reczna);
        Console.WriteLine($"Wynikiem całościowy z meczami, golami oraz żółtymi kartkami {razem}");
    }

}
