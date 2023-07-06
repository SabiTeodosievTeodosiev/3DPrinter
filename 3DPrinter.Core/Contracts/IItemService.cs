using _3DPrinter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPrinter.Core.Contracts
{
	/// <summary>
	/// Manipulates item data
	/// </summary>
	public interface IItemService
	{
		/// <summary>
		/// Gets all items
		/// </summary>
		/// <returns>List of items</returns>
		Task<IEnumerable<ItemDTO>> GetAll();
	}
}
