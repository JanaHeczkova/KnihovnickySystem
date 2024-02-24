namespace KnihovnickySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Knihovna mojeKnihovna = new Knihovna();

        Autor AlenaMornstajnova = new Autor("Alena", "Mornštajnová", 1963);
        Autor PatrikHratl = new Autor("Patrik", "Hartl", 1976);
        Autor JoNesbo = new Autor("Jo", "Nesbo", 1960);
        Autor MichaelaHanauer = new Autor("Michaela", "Hanauer", 1969);
        Kniha mojeKniha1 = new Kniha("Hana", AlenaMornstajnova, 2017, false);
        Kniha mojeKniha2 = new Kniha("Listopád", AlenaMornstajnova, 2021, false);
        Kniha mojeKniha3 = new Kniha("Gazely", PatrikHratl, 2023, false);
        Kniha mojeKniha4 = new Kniha("15 roků lásky", PatrikHratl, 2021, false);
        Kniha mojeKniha5 = new Kniha("Sněhulák", JoNesbo, 2012, false);
        Kniha mojeKniha6 = new Kniha("Rulantika - Utajený ostrov", MichaelaHanauer, 2022, false);
        Kniha mojeKniha7 = new Kniha("Rulantika - Spiknutí bohů", MichaelaHanauer, 2023, false);
        Navstevnik navstevnik1 = new Navstevnik("Jan", "Novák", 1);
        Navstevnik navstevnik2 = new Navstevnik("Jana", "Nováková", 2);
        mojeKnihovna.PridejNavstevnika(navstevnik1);
        mojeKnihovna.PridejNavstevnika(navstevnik2);
        Console.WriteLine(mojeKniha1);
        Console.WriteLine(mojeKniha2);
        mojeKnihovna.PridejKnihu(mojeKniha1);
        mojeKnihovna.PridejKnihu(mojeKniha2);
        mojeKnihovna.PridejKnihu(mojeKniha3);
        mojeKnihovna.PridejKnihu(mojeKniha4);
        mojeKnihovna.PridejKnihu(mojeKniha5);
        mojeKnihovna.PridejKnihu(mojeKniha6);
        mojeKnihovna.PridejKnihu(mojeKniha7);
        mojeKnihovna.VypisSeznamKnih();
        mojeKnihovna.VypujciKnihu(mojeKniha6, navstevnik1);
        mojeKnihovna.VypujciKnihu(mojeKniha4, navstevnik1);
        mojeKnihovna.VypujciKnihu(mojeKniha2, navstevnik1);
        mojeKnihovna.VypujciKnihu(mojeKniha5, navstevnik1);
        navstevnik1.VypisVypujceneKnihyNavstevnika();
        mojeKnihovna.VratKnihu(mojeKniha6, navstevnik1);
        navstevnik1.VypisVypujceneKnihyNavstevnika();
        mojeKnihovna.VratKnihu(mojeKniha2, navstevnik1);
        mojeKnihovna.VypujciKnihu(mojeKniha5, navstevnik1);
        navstevnik1.VypisVypujceneKnihyNavstevnika();
        mojeKnihovna.VypujciKnihu(mojeKniha3, navstevnik2);
        navstevnik2.VypisVypujceneKnihyNavstevnika();
        mojeKnihovna.VypujciKnihu(mojeKniha3, navstevnik1);
        navstevnik1.VypisVypujceneKnihyNavstevnika();
        }
    }
}