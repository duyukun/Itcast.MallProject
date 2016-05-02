using System; 
namespace Itcast.Mall.Model
{
	public class Comment
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// Content
        /// </summary>
        public string Content { get; set; }
		/// <summary>
		/// Created
        /// </summary>
        public DateTime Created { get; set; }
		/// <summary>
		/// BookId
        /// </summary>
        public int BookId { get; set; }
		   
	}
}

