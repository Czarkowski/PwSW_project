using Data.Core.Models;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers
{
    public class UpdateDataHelper : IUpdateDataHelper
    {

        public ref Hive UpdateHiveDetails(ref Hive ul, HiveDetailsVM hive)
        {
            ul.Description = hive.Description;
            ul.Number = hive.Number;
            ul.AddBeeQueenDate = hive.QueenAddDate;
            ul.BeeQueen = hive.BeeQueen;
            return ref ul;
        }

        public ref BeeQueen UpdateQueenDetails(ref BeeQueen matkaPszczela, QueenDetailsVM queenDetailsVM)
        {
            matkaPszczela.Description = queenDetailsVM.Description;
            matkaPszczela.Race = queenDetailsVM.Race;
            matkaPszczela.BirthDate = queenDetailsVM.BirthDate;
            matkaPszczela.Hive = queenDetailsVM.Hive;
            return ref matkaPszczela;
        }
    }
}
