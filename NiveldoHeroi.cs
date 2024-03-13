using System;

class Program
{
    static void Main()
    {
        // Solicitar nome do herói
        Console.Write("Digite o nome do herói: ");
        string nomeHeroi = Console.ReadLine();

        // Solicitar quantidade de experiência (XP)
        Console.Write("Digite a quantidade de experiência (XP) do herói: ");
        int xp = Convert.ToInt32(Console.ReadLine());

        // Determinar o nível com base na quantidade de XP
        string nivel = DeterminarNivel(xp);

        // Exibir a mensagem final
        Console.WriteLine($"O Herói de nome {nomeHeroi} está no nível de {nivel}");

        // Aguardar a tecla Enter ser pressionada antes de fechar o console
        Console.ReadLine();
    }

    static string DeterminarNivel(int xp)
    {
        string nivel;

        if (xp < 1000)
            nivel = "Ferro";
        else if (xp <= 2000)
            nivel = "Bronze";
        else if (xp <= 5000)
            nivel = "Prata";
        else if (xp <= 7000)
            nivel = "Ouro";
        else if (xp <= 8000)
            nivel = "Platina";
        else if (xp <= 9000)
            nivel = "Ascendente";
        else if (xp <= 10000)
            nivel = "Imortal";
        else
            nivel = "Radiante";

        return nivel;
    }
}
