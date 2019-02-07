using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public enum EKartTipi
    {
        mastercard,
        visa,
        americanexpress
    };

    public class KartFactory
    {
        public IKart getKart(EKartTipi kartTipi)
        {
            switch (kartTipi)
            {
                case EKartTipi.mastercard:
                    return new MasterCard();
                case EKartTipi.visa:
                    return new Visa();
                case EKartTipi.americanexpress:
                    return new AmericanExpress();
                default:
                    return null;
            }
        }
    }
}
