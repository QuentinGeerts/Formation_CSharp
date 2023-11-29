/* ----------------------------------------------------------------
 * › Chapitre 13 - Les exceptions
 */

// Les exceptions sont utilisées pour gérer les erreurs qui se produisent pendant l'exécution d'un programme.
// Elles sont des objets qui héritent de la classe "System.Exception".

/*
    Utilisation de try, catch, finally
    try :
        Ce bloc est utilisé pour envelopper le code qui peut potentiellement générer une exception.
    catch :
        Ce bloc est utilisé pour capturer et gérer l'exception.
    finally :
        Ce bloc est exécuté après les blocs try et catch, qu'une exception soit survenue ou non.
        Il est souvent utilisé pour nettoyer les ressources.
*/

// Vous pouvez avoir plusieurs blocs catch pour gérer différents types d'exceptions.

using DemoExceptions.CustomExceptions;

try
{
    // Code susceptible de générer une exception
    // int x = int.Parse("ceci n'est pas un nombre"); // Format incorrect
    // int x = int.Parse(null); // Argument null
    int x = int.Parse((Int64.MaxValue/2).ToString()); // Dépassement
}
catch (ArgumentNullException ex)
{
    // Gestion d'une exception spécifique
    // Dans le cas où l'argument est null
    Console.WriteLine("Argument null : " + ex.Message);
}
catch (FormatException ex)
{
    // Gestion d'une exception spécifique
    // Ne respecte pas le format autorisé
    Console.WriteLine("Format incorrect : " + ex.Message);
}
catch (OverflowException ex)
{
    // Gestion d'une exception spécifique
    // Dépasse les valeurs autorisées
    Console.WriteLine("Dépassement : " + ex.Message);
}
finally
{
    // Nettoyage, exécuté qu'il y ait une exception ou non
    Console.WriteLine("Bloc finally exécuté.");
}

// Le mot-clé throw est utilisé pour lever une exception.

try
{
    throw new InvalidOperationException("Une erreur s'est produite.");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Erreur : " + ex.Message);
}

// Vous pouvez créer vos propres types d'exceptions en héritant de la classe Exception.

try
{
    throw new MyException("Ceci est mon exception personnalisée.");
}
catch (MyException ex)
{
    Console.WriteLine(ex.Message);
}