/* ----------------------------------------------------------------
 * › Chapitre 14 - Les délégués
 */

using DemoDelegues;

var notificationService = new NotificationService();

// Enregistrer les méthodes de notification personnalisées
notificationService.RegisterNotification(SendEmail);
notificationService.RegisterNotification(SendSMS);

// Envoi des notifications
notificationService.SendNotification("Notification envoyée : 'Hello !'"); // Email + SMS

Console.WriteLine("---");

notificationService.UnregisterNotification(SendEmail);
notificationService.SendNotification("Notification envoyée : 'Seulement par SMS !'"); // SMS



static void SendEmail(string message)
{
 Console.WriteLine("Envoi d'email : " + message);
}

static void SendSMS(string message)
{
 Console.WriteLine("Envoi de SMS : " + message);
}