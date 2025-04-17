
using microsoft_blazor_exam.Models;
 
namespace microsoft_blazor_exam.Services
{
    public class UserSessionService
    {
        private User _currentUser = new();

        public User GetCurrentUser() => _currentUser;

        public void SetUser(User user) => _currentUser = user;

        public bool IsUserRegistered() => !string.IsNullOrWhiteSpace(_currentUser.Name);
    }
}
