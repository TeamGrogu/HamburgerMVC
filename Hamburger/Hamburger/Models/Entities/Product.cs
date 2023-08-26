﻿namespace Hamburger.Models.Entities
{
	public class Product:BaseEntity
	{
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
		public string? Description { get; set; }
	}
}