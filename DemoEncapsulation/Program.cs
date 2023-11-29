/* ----------------------------------------------------------------
 * › Chapitre 02 - L'Encapsulation
 */

namespace ExempleEncapsulation
{
    // Classe de niveau supérieur dans un espace de noms
    // Par défaut, elle a un niveau d'accessibilité 'internal'
    class ClasseNiveauSuperieur
    {
        // Membre 'public' : accessible de partout où la classe est accessible
        public int VariablePublique = 10;

        // Membre 'protected' : accessible seulement à l'intérieur de la classe et ses classes dérivées
        protected int VariableProtegee = 20;

        // Membre 'internal' : accessible à l'intérieur de l'assembly courant
        internal int VariableInterne = 30;

        // Membre 'protected internal' : accessible à l'intérieur de l'assembly et aux classes dérivées
        protected internal int VariableProtegeeInterne = 40;

        // Membre 'private' : accessible seulement à l'intérieur de cette classe
        private int VariablePrivee = 50;

        // Membre 'private protected' : accessible aux types dérivés dans le même assembly
        private protected int VariablePriveeProtegee = 60;

        // Méthode pour démontrer l'accès aux variables
        public void AfficherVariables()
        {
            Console.WriteLine($"Publique: {VariablePublique}");
            Console.WriteLine($"Protégée: {VariableProtegee}");
            Console.WriteLine($"Interne: {VariableInterne}");
            Console.WriteLine($"Protégée Interne: {VariableProtegeeInterne}");
            Console.WriteLine($"Privée: {VariablePrivee}");
            Console.WriteLine($"Privée Protégée: {VariablePriveeProtegee}");
        }
    }

    // Classe dérivée
    // La notion d'héritage sera vue au chapitre 7
    class ClasseDerivee : ClasseNiveauSuperieur
    {
        public void AfficherVariablesDerivees()
        {
            Console.WriteLine($"Protégée (héritée): {VariableProtegee}");
            // Attention: VariablePrivee n'est pas accessible ici
            Console.WriteLine($"Protégée Interne (héritée): {VariableProtegeeInterne}");
            Console.WriteLine($"Privée Protégée (héritée): {VariablePriveeProtegee}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClasseNiveauSuperieur objet = new ClasseNiveauSuperieur();
            objet.AfficherVariables();

            ClasseDerivee objetDerive = new ClasseDerivee();
            objetDerive.AfficherVariablesDerivees();

            // Accès direct aux membres publics et internes
            Console.WriteLine($"Accès direct au public: {objet.VariablePublique}");
            Console.WriteLine($"Accès direct à l'interne: {objet.VariableInterne}");

            // Les lignes suivantes génèrent des erreurs de compilation car elles tentent d'accéder à des membres protégés, privés ou privés protégés
            // Console.WriteLine(objet.VariableProtegee);
            // Console.WriteLine(objet.VariablePrivee);
            // Console.WriteLine(objet.VariablePriveeProtegee);
        }
    }
}
