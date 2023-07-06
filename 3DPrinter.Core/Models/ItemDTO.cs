using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPrinter.Core.Models
{
	public class ItemDTO
	{
		/// <summary>
		/// Item identifier
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Item name
		/// </summary>
		[Required]
		[StringLength(50)]
		public string Name { get; set; } = null!;

		/// <summary>
		/// Name of person who uploaded the item
		/// </summary>
		[Required]
		public string Author { get; set; }

		/// <summary>
		/// Item data
		/// </summary>
		public byte[] Data { get; set; }

		/// <summary>
		/// Item price without shipping
		/// </summary>
		[Range(typeof(decimal), "0.1", "100000", ConvertValueInInvariantCulture = true)]
		public decimal Price { get; set; }
	}
}
