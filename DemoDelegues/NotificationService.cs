namespace DemoDelegues;

// Définition du délégué pour les méthodes de notification
public delegate void NotificationDelegate(string message);

public class NotificationService
{
    // Délégué pour la méthode de notification
    private NotificationDelegate _notificationDelegate;
    
    // Méthode pour enregistrer la méthode de notification
    public void RegisterNotification(NotificationDelegate method)
    {
        _notificationDelegate += method;
    }

    // Méthode pour désenregistrer la méthode de notification
    public void UnregisterNotification(NotificationDelegate method)
    {
        _notificationDelegate -= method;
    }
    
    // Méthode pour exécuter le système de notification
    public void SendNotification(string message)
    {
        if (_notificationDelegate != null)
            // _notificationDelegate(message);
            _notificationDelegate.Invoke(message);
        
        // _notificationDelegate?.Invoke(message);
    }
}