using System; 
namespace Itcast.Mall.Model
{
	public class Book
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// CategoryId
        /// </summary>
        public int CategoryId { get; set; }
		/// <summary>
		/// Title
        /// </summary>
        public string Title { get; set; }
		/// <summary>
		/// Author
        /// </summary>
        public string Author { get; set; }
		/// <summary>
		/// PublisherId
        /// </summary>
        public int PublisherId { get; set; }
		/// <summary>
		/// PublishDate
        /// </summary>
        public DateTime PublishDate { get; set; }
		/// <summary>
		/// ISBN
        /// </summary>
        public string ISBN { get; set; }
		/// <summary>
		/// WordsCount
        /// </summary>
        public int WordsCount { get; set; }
		/// <summary>
		/// UnitPrice
        /// </summary>
        public decimal UnitPrice { get; set; }
		/// <summary>
		/// ContentDescription
        /// </summary>
        public string ContentDescription { get; set; }
		/// <summary>
		/// AurhorDescription
        /// </summary>
        public string AurhorDescription { get; set; }
		/// <summary>
		/// EditorComment
        /// </summary>
        public string EditorComment { get; set; }
		/// <summary>
		/// TOC
        /// </summary>
        public string TOC { get; set; }
		   
	}
}


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


using System; 
namespace Itcast.Mall.Model
{
	public class Cart
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
		/// BookId
        /// </summary>
        public int BookId { get; set; }
		/// <summary>
		/// Count
        /// </summary>
        public int Count { get; set; }
		   
	}
}


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


using System; 
namespace Itcast.Mall.Model
{
	public class Option
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
		/// Value
        /// </summary>
        public string Value { get; set; }
		/// <summary>
		/// Enabled
        /// </summary>
        public bool Enabled { get; set; }
		   
	}
}


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


using System; 
namespace Itcast.Mall.Model
{
	public class Publisher
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// Name
        /// </summary>
        public string Name { get; set; }
		   
	}
}


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


using System; 
namespace Itcast.Mall.Model
{
	public class User
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// Login
        /// </summary>
        public string Login { get; set; }
		/// <summary>
		/// Email
        /// </summary>
        public string Email { get; set; }
		/// <summary>
		/// Mobile
        /// </summary>
        public string Mobile { get; set; }
		/// <summary>
		/// Password
        /// </summary>
        public string Password { get; set; }
		/// <summary>
		/// Nickname
        /// </summary>
        public string Nickname { get; set; }
		/// <summary>
		/// Status
        /// </summary>
        public int Status { get; set; }
		   
	}
}


