using LibraryServices.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryServices.Data.Interfaces
{
    public interface ICityRepository
    {
        List<City> GetAllCity();
        City GetCity(int Id);
        void AddCity(City city);
        void UpdateCity(City city);
        void DeleteCity(int Id);

    }
}
