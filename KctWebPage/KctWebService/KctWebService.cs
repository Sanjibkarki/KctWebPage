using KctWebPage.Models;
using KctWebPage.KctWebPageInterface;

namespace KctWebPage.KctWebService
{
    public class KctWebService : IKctInterface
    {
        public List<KctWebModel> GetAllItems()
        {
            // Mock data
            return new List<KctWebModel>
            {
                new KctWebModel { Id = 1, Name = "Item 1", Description = "Description 1" },
                new KctWebModel { Id = 2, Name = "Item 2", Description = "Description 2" },
                new KctWebModel { Id = 3, Name = "Item 3", Description = "Description 3" }
            };
        }
    }
}
