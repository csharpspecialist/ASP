//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCDbasePrac2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Burger
    {
        [Display(Name = "Burger Name")]
        public int BurgerId { get; set; }
        public string BurgerName { get; set; }
        public Nullable<decimal> BurgerPrice { get; set; }
    }
}
