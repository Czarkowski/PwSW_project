using Data.Core.Models;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers.Interfaces
{
    public interface IUpdateDataHelper
    {
        void UpdateQueenDetails(ref BeeQueen matkaPszczela, QueenDetailsVM queenDetailsVM);
        void UpdateHiveDetails(ref Hive ul, HiveDetailsVM hive);
    }
}
