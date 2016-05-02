using System; 
namespace Itcast.Mall.Model
{
	public class Order
	{
   		     
      	/// <summary>
		/// OrderId
        /// </summary>
        public string OrderId { get; set; }
		/// <summary>
		/// OrderDate
        /// </summary>
        public DateTime OrderDate { get; set; }
		/// <summary>
		/// UserId
        /// </summary>
        public int UserId { get; set; }
		/// <summary>
		/// TotalPrice
        /// </summary>
        public decimal TotalPrice { get; set; }
		/// <summary>
		/// PostAddress
        /// </summary>
        public string PostAddress { get; set; }
		/// <summary>
		/// state
        /// </summary>
        public int state { get; set; }
		   
	}
}

