using DesignPatterns.Observer.DAL;

namespace DesignPatterns.Observer.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
