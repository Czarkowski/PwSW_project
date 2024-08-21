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
        public void UpdateHiveDetails(ref Ul ul, HiveDetailsVM hive)
        {
            ul.Opis = hive.Description;
            ul.Numer = hive.Number;
            ul.DataPoddaniaMatki = hive.QueenAddDate;
            ul.MatkaPszczela = hive.BeeQueen;
        }

        public void UpdateQueenDetails(ref MatkaPszczela matkaPszczela, QueenDetailsVM queenDetailsVM)
        {
            matkaPszczela.Opis = queenDetailsVM.Description;
            matkaPszczela.Rasa = queenDetailsVM.Race;
            matkaPszczela.DataUrodzenia = queenDetailsVM.BirthDate;
            matkaPszczela.Ul = queenDetailsVM.Hive;
        }
    }
}
