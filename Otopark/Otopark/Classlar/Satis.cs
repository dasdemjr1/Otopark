﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Classlar
{
    internal class Satis
    {
        public int ID { get; set; }
        public int SatisID { get; set; }

        public int MusteriID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string AdiSoyadi { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Telefon { get; set; }
        public int MarkaID { get; set; }
        public int SeriID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Plaka { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Yil { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Renk { get; set; }
        public int ParkYeriID { get; set; }
        public decimal SaatUCreti { get; set; }
        public decimal Sure { get; set; }
        public decimal Tutar { get; set; }
        [Column(TypeName = "varchar")]
        public string ACiklama { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
    }
}
