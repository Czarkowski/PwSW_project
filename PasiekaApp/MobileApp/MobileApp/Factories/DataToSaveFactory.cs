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
        public MatkaPszczela CreateMatkaPszczela(QueenDetailsVM queenDetailsVM)
        {
            return new MatkaPszczela()
            {
                Id = queenDetailsVM.Id,
                Rasa = queenDetailsVM.Race,
                DataUrodzenia = queenDetailsVM.BirthDate,
                Opis = queenDetailsVM.Description,
            };
        }
    }
}
