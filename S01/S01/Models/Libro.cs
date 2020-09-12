using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace S01.Models
{
    public class Libro
    {
        [DisplayName("CODIGO")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Ingrese el Codigo")]
        public int codigo { get; set; }

        [DisplayName("TITULO DEL LIBRO")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el Titulo")]
        public string titulo { get; set; }

        [DisplayName("AUTOR DEL LIBRO")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el Autor")]
        public string autor { get; set; }

        [DisplayName("NUMERO DE PAGINAS")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el Paginas")]
        [Range(1,int.MaxValue,ErrorMessage ="El rango es mayor a 1")]
        public int paginas { get; set; }

        [DisplayName("AREA DEL TITULO")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese el Area")]
        [RegularExpression(@"^((CI)|(RE)|(AS))$", ErrorMessage ="[CI]-[RE]-[AS]")]
        public string area { get; set; }


    }
}