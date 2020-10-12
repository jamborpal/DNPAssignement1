using System.Collections.Generic;
using Models;

namespace Assignment1.Data
{
    public interface IAdultService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(Adult toRemove);
        void EditAdult();
        IList<Adult> getMales();
        IList<Adult> getFemales();

    }
}