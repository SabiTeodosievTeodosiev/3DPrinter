using _3DPrinter.Core.Contracts;
using _3DPrinter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPrinter.Core.Services
{
	/// <summary>
	/// Manipulates item data
	/// </summary>
	public class ItemService : IItemService
	{
		/// <summary>
		/// Gets all items
		/// </summary>
		/// <returns>List of items</returns>
		public Task<IEnumerable<ItemDTO>> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
