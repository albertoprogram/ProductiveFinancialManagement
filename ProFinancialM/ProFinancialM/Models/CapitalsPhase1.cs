using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProFinancialM.Models
{
    public class CapitalsPhase1
    {
        public long Id { get; set; }

        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Por favor, ingrese el Monto.")]
        public decimal Amount { get; set; }

        [Display(Name = "Concepto")]
        [Required(ErrorMessage = "Por favor, ingrese el Concepto")]
        [StringLength(250)]
        public string Concept { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateTimeTXN { get; set; }
    }
}