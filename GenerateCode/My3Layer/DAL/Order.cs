using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Itcast.Mall.Model;
using Itcast.Mall.Utility;

namespace Itcast.Mall.DAL
{
	public partial class OrderService
	{
        #region 向数据库中添加一条记录 +int Insert(Order model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(Order model)
        {
            #region SQL语句
            const string sql = @"
INSERT INTO [dbo].[Order] (
	[OrderId]
	,[OrderDate]
	,[UserId]
	,[TotalPrice]
	,[PostAddress]
	,[state]
)
VALUES (
	@OrderId
	,@OrderDate
	,@UserId
	,@TotalPrice
	,@PostAddress
	,@state
);select @@IDENTITY";
            #endregion
            var res = SqlHelper.ExecuteScalar(sql,
					new SqlParameter("@OrderId", model.OrderId),					
					new SqlParameter("@OrderDate", model.OrderDate),					
					new SqlParameter("@UserId", model.UserId),					
					new SqlParameter("@TotalPrice", model.TotalPrice),					
					new SqlParameter("@PostAddress", model.PostAddress),					
					new SqlParameter("@state", model.state)					
                );
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region 删除一条记录 +int Delete(string orderid)
        public int Delete(string orderid)
        {
            const string sql = "DELETE FROM [dbo].[Order] WHERE [OrderId] = @OrderId";
            return SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@OrderId", orderid));
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(Order model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(Order model)
        {
            #region SQL语句
            const string sql = @"
UPDATE [dbo].[Order]
SET 
	[OrderId] = @OrderId
	,[OrderDate] = @OrderDate
	,[UserId] = @UserId
	,[TotalPrice] = @TotalPrice
	,[PostAddress] = @PostAddress
	,[state] = @state
WHERE [OrderId] = @OrderId";
            #endregion
            return SqlHelper.ExecuteNonQuery(sql,
					new SqlParameter("@OrderId", model.OrderId),					
					new SqlParameter("@OrderDate", model.OrderDate),					
					new SqlParameter("@UserId", model.UserId),					
					new SqlParameter("@TotalPrice", model.TotalPrice),					
					new SqlParameter("@PostAddress", model.PostAddress),					
					new SqlParameter("@state", model.state)					
                );
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<Order> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<Order> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        {
            var parameters = new List<SqlParameter>();
            var whereBuilder = new System.Text.StringBuilder();
            if (wheres != null)
            {
                var props = wheres.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.Name.Equals("__o", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // 操作符
                        whereBuilder.AppendFormat(" {0} ", prop.GetValue(wheres, null).ToString());
                    }
                    else
                    {
                        var val = prop.GetValue(wheres, null).ToString();
                        whereBuilder.AppendFormat(" [{0}] = @{0} ", prop.Name);
                        parameters.Add(new SqlParameter("@" + prop.Name, val));
                    }
                }
            }
            var sql = SqlHelper.GenerateQuerySql("Order", new[] { "OrderId", "OrderDate", "UserId", "TotalPrice", "PostAddress", "state" }, index, size, whereBuilder.ToString(), orderField, isDesc);
            using (var reader = SqlHelper.ExecuteReader(sql, parameters.ToArray()))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<Order>(reader);
                    }
                }
            }
        }
        #endregion

        #region 查询单个模型实体 +Order QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public Order QuerySingle(object wheres)
        {
            var list = QueryList(1, 1, wheres, null);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region 查询单个模型实体 +Order QuerySingle(string orderid)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="orderid">key</param>
        /// <returns>实体</returns>
        public Order QuerySingle(string orderid)
        {
            const string sql = "SELECT TOP 1 [OrderId], [OrderDate], [UserId], [TotalPrice], [PostAddress], [state] FROM [dbo].[Order] WHERE [OrderId] = @OrderId";
            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@OrderId", orderid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<Order>(reader);
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region 查询条数 +int QueryCount(object wheres)
        /// <summary>
        /// 查询条数
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns>条数</returns>
        public int QueryCount(object wheres)
        {
            var parameters = new List<SqlParameter>();
            var whereBuilder = new System.Text.StringBuilder();
            if (wheres != null)
            {
                var props = wheres.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.Name.Equals("__o", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // 操作符
                        whereBuilder.AppendFormat(" {0} ", prop.GetValue(wheres, null).ToString());
                    }
                    else
                    {
                        var val = prop.GetValue(wheres, null).ToString();
                        whereBuilder.AppendFormat(" [{0}] = @{0} ", prop.Name);
                        parameters.Add(new SqlParameter("@" + prop.Name, val));
                    }
                }
            }
            var sql = SqlHelper.GenerateQuerySql("Order", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
	}
}