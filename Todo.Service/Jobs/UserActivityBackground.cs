using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using Todo.Entities;

namespace Todo.Service.Jobs
{
    public class UserActivityBackground : IHostedService, IDisposable
    {
        private Timer _timer;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserActivityBackground(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }       

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(CheckUserActivity, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));
            return Task.CompletedTask;
        }

        private async void CheckUserActivity(object state)
        {
            var users = _userManager.Users.ToList();
            foreach (var user in users)
            {
                if ((DateTime.UtcNow - user.LastActivity).TotalMinutes > 5)
                {
                    user.LockoutEnabled = true;
                    user.LockoutEnd = DateTimeOffset.MaxValue; // Permanently lock the account
                    await _userManager.UpdateAsync(user);
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
