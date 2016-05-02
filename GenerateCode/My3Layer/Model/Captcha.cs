using System; 
namespace Itcast.Mall.Model
{
	public class Captcha
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// UserId
        /// </summary>
        public int UserId { get; set; }
		/// <summary>
		/// Token
        /// </summary>
        public string Token { get; set; }
		/// <summary>
		/// Actived
        /// </summary>
        public bool Actived { get; set; }
		/// <summary>
		/// Expired
        /// </summary>
        public DateTime Expired { get; set; }
		   
	}
}

