/* ----------------------------------------------------------------
 * › Chapitre 01 - Les espaces de noms (Namespaces)
 */

// Utilisation du mot-clé 'using' pour importer l'espace de noms System
using System;
// Déclaration d'un alias pour éviter les conflits ou pour simplifier le code
using MonAlias = EspaceDeNomsSecondaire;

// Déclaration de l'espace de noms principal
namespace EspaceDeNomsPrincipal
{
    // Une classe simple dans l'espace de noms principal
    class MaClasse
    {
        public void AfficherMessage()
        {
            Console.WriteLine("Message de EspaceDeNomsPrincipal.MaClasse");
        }
    }

    // Imbrication d'un espace de noms
    namespace EspaceDeNomsImbrique
    {
        // Une classe dans l'espace de noms imbriqué
        class MaClasse
        {
            public void AfficherMessage()
            {
                Console.WriteLine("Message de EspaceDeNomsPrincipal.EspaceDeNomsImbrique.MaClasse");
            }
        }

        // Démonstration de la portée et de la dissimulation
        public class Test
        {
            public void Tester()
            {
                // La classe MaClasse du même espace de noms (dissimulation)
                MaClasse classeLocale = new MaClasse();
                classeLocale.AfficherMessage();

                // La classe MaClasse de l'espace de noms parent (portée)
                EspaceDeNomsPrincipal.MaClasse classeParent = new EspaceDeNomsPrincipal.MaClasse();
                classeParent.AfficherMessage();
            }
        }
    }
}

// Déclaration d'un second espace de noms pour montrer la répétition
namespace EspaceDeNomsSecondaire
{
    // Une classe avec le même nom que dans EspaceDeNomsPrincipal
    class MaClasse
    {
        public void AfficherMessage()
        {
            Console.WriteLine("Message de EspaceDeNomsSecondaire.MaClasse");
        }
    }
}

// Classe principale du programme
class Program
{
    static void Main(string[] args)
    {
        // Utilisation de la classe dans l'espace de noms principal
        EspaceDeNomsPrincipal.MaClasse maClasse = new EspaceDeNomsPrincipal.MaClasse();
        maClasse.AfficherMessage();

        // Utilisation de la classe dans l'espace de noms imbriqué
        EspaceDeNomsPrincipal.EspaceDeNomsImbrique.MaClasse maClasseImbriquee = new EspaceDeNomsPrincipal.EspaceDeNomsImbrique.MaClasse();
        maClasseImbriquee.AfficherMessage();

        // Utilisation de la classe dans l'espace de noms secondaire avec alias
        MonAlias.MaClasse maClasseAlias = new MonAlias.MaClasse();
        maClasseAlias.AfficherMessage();

        // Test de la portée et de la dissimulation
        EspaceDeNomsPrincipal.EspaceDeNomsImbrique.Test test = new EspaceDeNomsPrincipal.EspaceDeNomsImbrique.Test();
        test.Tester();
    }
}
