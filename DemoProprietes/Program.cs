namespace ExempleProprietes
{
    class ExempleClasse
    {
        // Variable membre privée
        private int _valeur;

        // Propriété avec accesseur (get) et mutateur (set) complets
        public int Valeur
        {
            get
            {
                // Ici, on peut ajouter une logique supplémentaire pour le 'get'
                return _valeur;
            }
            set
            {
                // Ici, on peut ajouter une logique pour valider ou modifier la valeur
                if (value >= 0) // Simple validation
                {
                    _valeur = value;
                }
                else
                {
                    Console.WriteLine("La valeur doit être positive.");
                }
            }
        }

        // Propriété en lecture seule (readonly)
        public int ValeurReadOnly { get; }

        // Propriété en écriture seule (writeonly)
        private int _valeurWriteOnly;
        public int ValeurWriteOnly
        {
            set { _valeurWriteOnly = value; }
        }
        
        // Propriété avec un 'set' privé
        public int ValeurAvecSetPrive { get; private set; }

        // Propriété avec un 'get' privé
        private int _valeurAvecGetPrive;
        public int ValeurAvecGetPrive
        {
            private get { return _valeurAvecGetPrive; }
            set { _valeurAvecGetPrive = value; }
        }

        // Auto-propriété
        public string NomAutoPropriete { get; set; }

        // Constructeur
        public ExempleClasse()
        {
            ValeurReadOnly = 10; // Initialisation de la propriété en lecture seule
            ValeurAvecSetPrive = 15; // Initialisation de la propriété avec 'set' privé
            ValeurAvecGetPrive = 20; // Initialisation de la propriété avec 'get' privé
        }
        
        // Méthode pour démontrer l'utilisation de 'ValeurAvecGetPrive'
        public void AfficherValeurAvecGetPrive()
        {
            Console.WriteLine($"ValeurAvecGetPrive (interne): {_valeurAvecGetPrive}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExempleClasse exemple = new ExempleClasse();

            // Utilisation de la propriété avec accesseur et mutateur
            exemple.Valeur = 5;
            Console.WriteLine($"Valeur: {exemple.Valeur}");

            // Tentative de définition d'une valeur négative
            exemple.Valeur = -3; // Affichera un message d'erreur

            // Utilisation de l'auto-propriété
            exemple.NomAutoPropriete = "Cognitic";
            Console.WriteLine($"NomAutoPropriete: {exemple.NomAutoPropriete}");

            // Lecture de la propriété en lecture seule
            Console.WriteLine($"ValeurReadOnly: {exemple.ValeurReadOnly}");

            // Écriture dans la propriété en écriture seule
            exemple.ValeurWriteOnly = 20;
            // Note: Il n'y a pas de moyen de lire cette valeur depuis l'extérieur de la classe
            
            // Utilisation de la propriété avec 'set' privé
            Console.WriteLine($"ValeurAvecSetPrive: {exemple.ValeurAvecSetPrive}");
            // Note: Impossible de modifier 'ValeurAvecSetPrive' de l'extérieur de la classe

            // Utilisation de la propriété avec 'get' privé
            exemple.ValeurAvecGetPrive = 25;
            // Note: Impossible de lire 'ValeurAvecGetPrive' de l'extérieur de la classe
            exemple.AfficherValeurAvecGetPrive(); // Affichage interne
        }
    }
}
