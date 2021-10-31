using Registermvc.Models;

namespace Registermvc.Services
{
    public interface IRegister
    {
     int  RegisterNewUser (RegisterViewModel model); 
     
    }
}