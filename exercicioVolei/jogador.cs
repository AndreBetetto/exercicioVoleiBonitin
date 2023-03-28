namespace exercicioVolei;

internal class jogador
{
    public string nome { get; set; }
    public bool titular { get; set; }
    public int altura { get; set; }

    public void mostra()
    {
        Console.WriteLine(nome);
        Console.WriteLine(titular);
        Console.WriteLine(altura);
    }

    public static string nomearjog()
    {
        Random r = new Random();
        List<string> nome = new List<string>(); 
        nome.Add("andre");
        nome.Add("Wallace");
        nome.Add("robertao");
        nome.Add("rebeca");
        nome.Add("duda");
        nome.Add("bruno");
        nome.Add("paulao");
        nome.Add("vanessa");
        nome.Add("gabriela");
        nome.Add("barbara");
        nome.Add("jose");
        nome.Add("kim");
        nome.Add("Antônio");
        nome.Add("Carlos");
        nome.Add("Fernanda");
        nome.Add("Isabela");
        nome.Add("Sofia");
        nome.Add("Larissa");
        nome.Add("Vitor");
        nome.Add("Marcelo");
        nome.Add("Rafael");
        nome.Add("Henrique");
        nome.Add("Ricardo");
        nome.Add("Luana");
        nome.Add("Mariana");
        nome.Add("Amanda");
        nome.Add("Bruno");
        nome.Add("Gabriel");
        nome.Add("Renata");
        nome.Add("Bianca");
        nome.Add("Lúcia");
        nome.Add("Lucas");
        nome.Add("Matheus");
        nome.Add("Roberto");
        nome.Add("Vinicius");
        nome.Add("Júlia");
        nome.Add("Letícia");
        nome.Add("Raquel");
        nome.Add("Thiago");
        nome.Add("Rodrigo");
        nome.Add("Cristina");
        nome.Add("Diego");
        nome.Add("Gustavo");
        nome.Add("Hélio");
        nome.Add("Milton");

        int numnome;
        string nomejogador;
        numnome = nome.Count;
        nomejogador = nome[r.Next(0, numnome)];
        return nomejogador;
    }

    public static int alturajog()
    {
        Random r = new Random();
        int h = r.Next(150, 240);
        return h;
    }

}