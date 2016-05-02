using System; 
namespace Itcast.Mall.Model
{
	public class Category
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// Name
        /// </summary>
        public string Name { get; set; }
		/// <summary>
		/// ParentId
        /// </summary>
        public int ParentId { get; set; }
		   
	}
}

