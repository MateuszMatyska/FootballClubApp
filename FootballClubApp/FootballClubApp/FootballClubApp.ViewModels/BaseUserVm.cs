using System.Collections.Generic;

namespace FootballClubApp.ViewModels
{
    public class BaseUserVm
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }

    }
}
