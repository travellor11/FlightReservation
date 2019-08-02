using System.Threading.Tasks;
using FlightReservation.API.Models;

namespace FlightReservation.API.Data
{
    public interface IAuthRespository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}