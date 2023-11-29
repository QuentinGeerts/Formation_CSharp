/* ----------------------------------------------------------------
 * › Chapitre 06 - Surcharge d'opérateurs
 */
namespace SurchargeOperateurs
{
    class Fraction
    {
        public int Numerateur { get; private set; }
        public int Denominateur { get; private set; }

        public Fraction(int numerateur, int denominateur)
        {
            if (denominateur == 0)
            {
                // Nous verrons les Exceptions plus en détails dans le chapitre 13.
                throw new ArgumentException("Le dénominateur ne peut pas être zéro.");
            }

            Numerateur = numerateur;
            Denominateur = denominateur;
            Simplifier();
        }

        // Méthode pour simplifier la fraction
        private void Simplifier()
        {
            int pgcd = PGCD(Numerateur, Denominateur);
            Numerateur /= pgcd;
            Denominateur /= pgcd;
        }

        // Calcul du Plus Grand Commun Diviseur
        private static int PGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Surcharge de l'opérateur '+'
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerateur = a.Numerateur * b.Denominateur + b.Numerateur * a.Denominateur;
            int denominateur = a.Denominateur * b.Denominateur;
            return new Fraction(numerateur, denominateur);
        }

        // Surcharge de l'opérateur '=='
        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Numerateur == b.Numerateur && a.Denominateur == b.Denominateur;
        }

        // Surcharge de l'opérateur '!='
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        // Méthodes Equals et GetHashCode surchargées pour une bonne pratique
        public override bool Equals(object obj)
        {
            if (obj is Fraction)
            {
                Fraction f = (Fraction)obj;
                return this == f;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Numerateur.GetHashCode() ^ Denominateur.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Numerateur}/{Denominateur}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(2, 4);
            Fraction f4 = new Fraction(2, 5);

            // Utilisation de l'opérateur surchargé '+'
            Fraction f3 = f1 + f2;
            Console.WriteLine($"f1 + f2 = {f3}"); // Affiche 1/1

            // Utilisation des opérateurs surchargés '==' et '!='
            Console.WriteLine($"f1 == f2: {f1 == f2}"); // Affiche True
            Console.WriteLine($"f1 != f2: {f1 != f2}"); // Affiche False
            Console.WriteLine($"f1 == f4: {f1 == f4}"); // Affiche False

            Console.WriteLine(new Fraction(10, 4) + new Fraction(1, 10));
        }
    }
}
