using Data.Core.Models;
using MobileApp.ViewModels.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.ViewModels
{
    public class HiveDetailsVM : BaseVM
    {
        public readonly Hive Hive;
        public HiveDetailsVM(Hive hive) : base(hive.Id)
        {
            Hive = hive;
        }
        public int Number { get; set; }
        public string Description { get; set; }
        public BeeQueen BeeQueen { get; set; }
        public DateTime? QueenAddDate { get; set; }
        private TimeSpan? _queenAge { get; set; }
        public TimeSpan? QueenAge { get => _queenAge; set => _queenAge = value; }
        public string QueenDescription { get; set; }
        public bool HasQueen => BeeQueen != null;
        public bool HasQueen_N => !HasQueen;
    }
}
