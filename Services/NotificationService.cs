using Firebase.Database.Query;
using Firebase.Database;
using Porfolio.Models;

namespace Porfolio.Services
{
    public class NotificationService
    {

        FirebaseClient _client;

        public NotificationService()
        {
            _client = new FirebaseClient("https://mzansigopro-f8d36-default-rtdb.firebaseio.com");
        }

        public async Task<bool> SendMsgAsync(NotificationM noti)
        {
            try
            {
                var response = await _client.Child("notifications").PostAsync(noti);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
