﻿using Data.Core.Models;
using MobileApp.ViewModels.PickerItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Factories.Interfaces
{
    public interface IPickerItemFactories
    {
        List<RacePickerItem> CreateRacePickerItems(IEnumerable<Race> races);
    }
}
