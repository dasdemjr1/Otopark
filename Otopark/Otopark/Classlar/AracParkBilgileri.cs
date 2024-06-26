﻿using DevExpress.XtraEditors.Mask.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Classlar
{
    internal class AracParkBilgileri
    {
        public int ID { get; set; }
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
        [Column(TypeName = "varchar")]
        public string ACiklama { get; set; }
        public DateTime GirisTarihi { get; set; }
        public virtual AracParkYerleri AracParkYerleri { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual Seri Seri { get; set; }
    }
}
