/* ----------------------------------------------------------------
 * › Chapitre 05 - Indexeurs
 */

namespace ExempleIndexeurs
{
    class CollectionPersonnalisee
    {
        private Dictionary<int, string> _elements = new Dictionary<int, string>();

        public KeyValuePair<int, string>[] Elements
        {
            get { return _elements.ToArray(); }
        }

        // Indexeur par défaut
        public string this[int index]
        {
            get
            {
                return _elements.ContainsKey(index) ? _elements[index] : null;
            }
            set
            {
                _elements[index] = value;
            }
        }

        // Indexeur surchargé avec un paramètre de type string
        public string this[string cle]
        {
            get
            {
                foreach (KeyValuePair<int, string> pair in _elements)
                {
                    if (pair.Value == cle)
                        return pair.Value;
                }
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CollectionPersonnalisee maCollection = new CollectionPersonnalisee();

            // Utilisation de l'indexeur par défaut
            maCollection[0] = "Premier élément";
            maCollection[1] = "Deuxième élément";

            Console.WriteLine($"Élément à l'index 0 : {maCollection[0]}");
            Console.WriteLine($"Élément à l'index 1 : {maCollection[1]}");

            // Utilisation de l'indexeur surchargé
            string recherche = "Deuxième élément";
            Console.WriteLine($"Recherche de '{recherche}' : {maCollection[recherche]}");
        }
    }
}