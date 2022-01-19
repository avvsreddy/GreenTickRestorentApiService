using GT_BL.Interface;
using GT_DL.Interface;
using GT_DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT_BL.Implementation
{
   public class BeverageManager : IBeverageManager
    {
        IBeverageRepository repository;
        public BeverageManager(IBeverageRepository _repository)
        {
            repository = _repository;
        }
        public List<Beverage> GetAllBeverages()
        {
            try
            {
                return repository.GetAllBeverages();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public Beverage GetBeverageById(int Id)
        {
            try
            {
                return repository.GetBeverageById(Id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
