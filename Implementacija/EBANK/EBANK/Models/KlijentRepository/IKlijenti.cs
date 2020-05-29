﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBANK.Models.KlijentRepository
{
    interface IKlijenti
    {
        public Task DodajKlijenta(Klijent klijent);
        public Task UrediKlijenta(Klijent klijent);
        public Task UkloniKlijenta(int? id);
        public Task<List<Klijent>> DajSveKlijente();
        public Task<Klijent> DajKlijenta(int? id);
        public bool DaLiPostojiKlijent(int? id);
    }
}