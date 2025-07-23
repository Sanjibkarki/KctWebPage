using System.Collections.Generic;
using KctWebPage.Models;

namespace KctWebPage.KctWebPageInterface
{
    public interface IKctInterface
    {
        List<KctWebModel> GetAllItems();
    }
}
