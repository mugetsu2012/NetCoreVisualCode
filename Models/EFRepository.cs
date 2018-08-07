using System.Collections.Generic;

namespace NetCoreVisualCode.Models
{
    public class EFRepository: IRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<GuestResponse> Responses => context.Invites;

        public void AddResponse(GuestResponse reponse)
        {
            context.Invites.Add(reponse);
            context.SaveChanges();
        }
    }
}