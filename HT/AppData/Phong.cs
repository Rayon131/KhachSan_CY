﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class Phong
	{
		[Key]
		public int MaPhong { get; set; }
		public string TenPhong { get; set; }
		public string MoTa { get; set; }
		public string Hinh { get; set; }
		public decimal gia {  get; set; }
        public int MaLoaiPhong { get; set; }
        public LoaiPhong? LoaiPhong { get; set; }
        public ICollection<PhongChiTiet> ?PhongChiTiets { get; set; }
	}
}
