using System; 
namespace Itcast.Mall.Model
{
	public class SensitiveWord
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// Original
        /// </summary>
        public string Original { get; set; }
		/// <summary>
		/// 是否禁用
        /// </summary>
        public bool IsForbid { get; set; }
		/// <summary>
		/// 是否需要审核
        /// </summary>
        public bool IsReplace { get; set; }
		/// <summary>
		/// Replace
        /// </summary>
        public string Replace { get; set; }
		   
	}
}

