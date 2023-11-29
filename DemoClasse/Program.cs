/* ----------------------------------------------------------------
 * › Chapitre 03 - Notion de classe
 */

// Déclaration d'une classe partielle
// Fichier 1
public partial class MaClasse
{
    // Variable membre de la classe
    public string Nom;

    // Constructeur de la classe
    public MaClasse(string nom)
    {
        Nom = nom;
    }

    // Méthode partielle déclarée
    partial void MessagePartiel();

    // Méthode de la classe
    public void AfficherNom()
    {
        // Appel de la méthode partielle
        MessagePartiel();
        Console.WriteLine($"Nom: {Nom}");
    }
}

// Fichier 2
public partial class MaClasse
{
    // Implémentation de la méthode partielle
    partial void MessagePartiel()
    {
        Console.WriteLine("Message depuis la méthode partielle.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciation de la classe MaClasse
        MaClasse objet = new MaClasse("Cognitic");

        // Appel de la méthode de l'objet
        objet.AfficherNom();
    }
}