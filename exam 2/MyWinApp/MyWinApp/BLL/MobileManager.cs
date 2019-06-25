using MyWinApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Repository;
using System.Data;

namespace MyWinApp.BLL
{
    public class MobileManager
    {
        MobileRepository _mobileRepository = new MobileRepository();
        public bool Insert(Mobile mobile)
        {

            return _mobileRepository.Insert(mobile);
        }


        public DataTable SearchByPrice(double lowRange, double highRange)
        {
           

            return _mobileRepository.SearchByPrice( lowRange,  highRange);
        }

        public Mobile SearchByIMEI(string IMEI)
        {
           
            return _mobileRepository.SearchByIMEI(IMEI);
        }

        public bool IsExists(string IMEI)
        {

            return _mobileRepository.IsExists(IMEI);
        }

        


    }
}
