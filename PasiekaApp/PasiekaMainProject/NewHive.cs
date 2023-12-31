﻿using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Ocsp;
using PasiekaMainProject.Helpers;
using PasiekaMainProject.Model;
using PasiekaMainProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasiekaMainProject
{
    public partial class NewHive : Form
    {

        private IPasiekaRepository repository;

        public delegate void RefreshPasiekaGrid();

        public RefreshPasiekaGrid refreshPasiekaGrid { get; set; }
        private List<int> lockNumbers => repository.GetAllLockNumber();
        public NewHive()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
        }

        private int lastValue;
        private void nudNr_ValueChanged(object sender, EventArgs e)
        {
            if (nudNr.Value == lastValue)
                return;
            lastValue = nextValue((int)nudNr.Value, lastValue);
            nudNr.Value = lastValue;
        }


        private void NewHive_Load(object sender, EventArgs e)
        {
            lastValue = SpecialValues.MinHiveNumber;
            nudNr.Minimum = SpecialValues.MinHiveNumber;
            nudNr.Value = nextValue(SpecialValues.MinHiveNumber, lastValue);
        }

        private int nextValue(int val, int last)
        {
            bool isNotSmaller = last <= val;
            var ln = lockNumbers;
            while (ln.Contains(val))
            {
                val = isNotSmaller ? ++val : --val;
                if (val < SpecialValues.MinHiveNumber)
                    return last;
            }
            return val;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int nr = (int)nudNr.Value;
            if (lockNumbers.Contains(nr))
            {
                nudNr.Value = nextValue((int)nudNr.Value, lastValue);
                return;
            }
            UlModel ul = new UlModel(nr);

            ul.DataDodania = DateTime.Now;
            ul.DataPoddaniaMatki = SpecialValues.MinDateTime;
            ul.RasaId = SpecialValues.NoBeeQueenID;
            repository.AddUl(ul);
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewHive_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshPasiekaGrid?.Invoke();
        }
    }
}
