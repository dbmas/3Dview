using DapperExtensions;
using DapperExtensions.Mapper;
using DapperExtensions.Predicate;
using System;
using System.Collections.Generic;
using System.Data;

namespace DbHelper
{
    /// <summary>
    /// 数据访问层接口
    /// </summary>
    public interface ISqlHelper
    {
        /// <summary>
        /// 数据库连接 Connection 对象
        /// </summary>
        IDbConnection Connection { get; }


        /// <summary>
        /// 获取一个对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="id">dynamic</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <returns></returns>
        T Get<T>(dynamic id, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 新增对象（无返回值）
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="entities">泛型集合</param>
        /// <param name="commandTimeout">sql超时时间</param>
        void Insert<T>(IEnumerable<T> entities, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 新增对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="entity">泛型参数·</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <returns></returns>
        dynamic Insert<T>(T entity, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="entity">更新对象</param>
        /// <param name="updateProperties">更新的属性</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <param name="ignoreAllKeyProperties"></param>
        /// <returns>bool</returns>
        bool Update<T>(T entity, List<string> updateProperties = null, int? commandTimeout = null, bool ignoreAllKeyProperties = false) where T : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="entity">删除对象</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <returns></returns>
        bool Delete<T>(T entity, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 根据条件删除对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="predicate">条件</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <returns></returns>
        bool Delete<T>(object predicate, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="T">指定获取的类型</typeparam>
        /// <param name="predicate">查询条件</param>
        /// <param name="sort">排序</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <param name="buffered"></param>
        /// <returns></returns>
        IEnumerable<T> GetList<T>(object predicate = null, IList<ISort> sort = null, int? commandTimeout = null, bool buffered = true) where T : class;

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="T">指定获取的类型</typeparam>
        /// <param name="predicate">查询条件</param>
        /// <param name="sort">排序</param>
        /// <param name="page"></param>
        /// <param name="resultsPerPage"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="buffered"></param>
        /// <returns></returns>
        IEnumerable<T> GetPage<T>(object predicate, IList<ISort> sort, int page, int resultsPerPage, int? commandTimeout = null, bool buffered = true) where T : class;

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="sort"></param>
        /// <param name="firstResult"></param>
        /// <param name="maxResults"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="buffered"></param>
        /// <returns></returns>
        IEnumerable<T> GetSet<T>(object predicate, IList<ISort> sort, int firstResult, int maxResults, int? commandTimeout, bool buffered) where T : class;

        /// <summary>
        /// 聚合函数 Count
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        int Count<T>(object predicate, int? commandTimeout = null) where T : class;

        /// <summary>
        /// 返回多个结果集
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        IMultipleResultReader GetMultiple(GetMultiplePredicate predicate, int? commandTimeout = null);

        /// <summary>
        /// 清除缓存
        /// </summary>
        void ClearCache();

        /// <summary>
        /// 生成GUID对象
        /// </summary>
        /// <returns></returns>
        Guid GetNextGuid();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IClassMapper GetMap<T>() where T : class;

        /// <summary>
        /// 释放资源
        /// </summary>
        void Dispose();



        #region sql 语句
        /// <summary>
        /// 获取第一个字段第一个值（sql）
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="sql">sql</param>
        /// <param name="param">查询参数</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <param name="commandType">commandType</param>
        /// <returns>T</returns>
        T GetValue<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null);

        /// <summary>
        /// 获取list泛型集合
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="param">查询参数</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <param name="commandType">commandType</param>
        /// <returns>List<T></returns>
        List<T> Query<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null);

        /// <summary>
        /// 返回动态的 Dictionary 泛型
        /// </summary>
        /// <typeparam name="T1">泛型对象1</typeparam>
        /// <typeparam name="T2">泛型对象2</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="param">查询参数</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <param name="commandType">commandType</param>
        /// <returns>Dictionary<T1, T2></returns>
        Dictionary<dynamic, dynamic> GetDic<T1, T2>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null);
        /// <summary>
        /// Dictionary<string, dynamic> sql
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>Dictionary<string, dynamic></returns>
        Dictionary<string, dynamic> GetFirstValues(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null);

        /// <summary>
        /// GetModel<T> sql
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>T</returns>
        T GetModel<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null) where T : class;

        /// <summary>
        /// GetModelList<T>
        /// </summary>
        /// <typeparam name="T">泛型参数T</typeparam>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="buffered">buffered</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>List<T></returns>
        List<T> GetModelList<T>(string sql, object param = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null) where T : class;

        /// <summary>
        /// GetDynamicModel<T> sql
        /// </summary>
        /// <typeparam name="T">泛型T</typeparam>
        /// <param name="buildModelFunc">buildModelFunc</param>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="buffered">buffered</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>GetDynamicModel</returns>
        T GetDynamicModel<T>(Func<IEnumerable<dynamic>, T> buildModelFunc, string sql, object param = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);

        /// <summary>
        /// GetMultModelList<T> sql
        /// </summary>
        /// <typeparam name="T">泛型参数T</typeparam>
        /// <param name="sql">sql</param>
        /// <param name="types">types</param>
        /// <param name="map">map</param>
        /// <param name="param">param</param>
        /// <param name="buffered">buffered</param>
        /// <param name="splitOn">splitOn</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>List<T></returns>
        List<T> GetMultModelList<T>(string sql, Type[] types, Func<object[], T> map, object param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);

        /// <summary>
        /// ExecuteCommand sql
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>bool</returns>
        bool ExecuteCommand(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null);

        /// <summary>
        /// ExecuteScalar<T> sql
        /// </summary>
        /// <typeparam name="T">泛型参数T</typeparam>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>T</returns>
        T ExecuteScalar<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null);
        #endregion
    }
}
