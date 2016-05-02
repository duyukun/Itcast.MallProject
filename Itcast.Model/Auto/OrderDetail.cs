using System; 
namespace Itcast.Mall.Model
{
	public class OrderDetail
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// OrderID
        /// </summary>
        public string OrderID { get; set; }
		/// <summary>
		/// BookID
        /// </summary>
        public int BookID { get; set; }
		/// <summary>
		/// Quantity
        /// </summary>
        public int Quantity { get; set; }
		/// <summary>
		/// UnitPrice
        /// </summary>
        public decimal UnitPrice { get; set; }
		   
	}
}

