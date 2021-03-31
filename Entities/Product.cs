using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Product:IEntities
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Barkod bilgisi giriniz.")]
        public string Barcode { get; set; }

        [Required(ErrorMessage = "Fiyat bilgisi giriniz.")]
        public int Price { get; set; }
        
        [Required(ErrorMessage = "Resim bilgisi giriniz.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Açıklama bilgisi giriniz.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Adet bilgisi giriniz.")]
        public int Piece { get; set; }
        public byte IsDeleted { get; set; }
    }
}
