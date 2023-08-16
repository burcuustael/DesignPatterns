using DesignPatterns.Observer.DAL;
using System;

namespace DesignPatterns.Observer.ObserverPattern
{
    public class CreateMagazineAnnocunment : IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        Context context = new Context();

        public CreateMagazineAnnocunment(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Yeni sayısı 1 Martta..."
            });

            context.SaveChanges();
        }
    }
}
