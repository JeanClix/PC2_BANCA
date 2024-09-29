using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using PC2.Models;

namespace PC2.ViewModel
{
    public class BancoVM
    {
        public Banco FormBanco { get; set; }

        [ValidateNever]
        public List<Banco> ListBanco { get; set; }

        public BancoVM()
        {
            FormBanco = new Banco();
            ListBanco = new List<Banco>();
        }
    }
}