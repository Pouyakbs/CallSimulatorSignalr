using System;
using System.Linq;
using System.Threading.Tasks;

namespace CallSimulatorSignalr.Models
{

    public class User
    {
        public string Username { get; set; }
        public string ConnectionId { get; set; }
        public bool InCall { get; set; }
    }
}
