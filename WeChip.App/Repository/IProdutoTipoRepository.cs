﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChip.App.Models;

namespace WeChip.App.Repository
{
    public interface IProdutoTipoRepository
    {
        Task<List<ProdutoTipo>> GetProdutoTiposAsync();
    }
}
