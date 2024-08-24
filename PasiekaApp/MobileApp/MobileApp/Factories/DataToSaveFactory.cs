using Data.Core.Models;
using MobileApp.Factories.Interfaces;
using MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories
{
    public class DataToSaveFactory : IDataToSaveFactory
    {
        public BeeQueen CreateMatkaPszczela(QueenDetailsVM queenDetailsVM)
        {
            return new BeeQueen()
            {
                Id = queenDetailsVM.Id,
                Race = queenDetailsVM.Race,
                BirthDate = queenDetailsVM.BirthDate,
                Description = queenDetailsVM.Description,
            };
        }
    }
}
