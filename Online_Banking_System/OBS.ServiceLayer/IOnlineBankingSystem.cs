using OBS.DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBS.ServiceLayer
{
    public interface IOnlineBankingSystem
    {
        public void CalcInterest(TermAccount Interest);
    }
}
