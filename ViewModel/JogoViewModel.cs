﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CriaçãoDeUmaApiCatlogoDeJogos.ViewModel;

namespace CriaçãoDeUmaApiCatlogoDeJogos.ViewModel
{
    public class JogoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preço { get; set; }
    }
}
