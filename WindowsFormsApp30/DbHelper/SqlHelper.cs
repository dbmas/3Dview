using DapperExtensions;
using DapperExtensions.Mapper;
using DapperExtensions.Predicate;
using DapperExtensions.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace DbHelper
{
    public class SqlHelper : ISqlHelper
    {
        private readonly IDapperImplementor _dapper;

        private IDbTransaction _transaction;

        /// <summary>
        /// 访问数据库实例
        /// </summary>
        public static SqlHelper GetSqlHelper(string url)
        {
            return new SqlHelper(url);
        }

        /// <summary>
        /// 构造函数 SqlHelper
        /// </summary>
        public SqlHelper(string url)
        {
            var connectionString = url;

            var connection = new SqlConnection(connectionString);
            var config = new DapperExtensionsConfiguration(typeof(AutoClassMapper<>), new List<Assembly>(), new SqlServerDialect());
            var sqlGenerator = new SqlGeneratorImpl(config);

            _dapper = new DapperImplementor(sqlGenerator);
            Connection = connection;

            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        public IDbConnection Connection { get; private set; }

        /// <summary>
        /// 资源释放
        /// </summary>
        public virtual void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                if (_transaction != null)
                {
                    _transaction.Rollback();
                }
                Connection.Close();
            }
        }

        #region orm


        /// <summary>
        /// 获取一个对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="id">dynamic</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <returns>T</returns>
        public T Get<T>(dynamic id, int? commandTimeout) where T : class
        {
            return (T)_dapper.Get<T>(Connection, id, _transaction, commandTimeout);
        }

        /// <summary>
        /// 新增对象（无返回值）
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="entities">泛型集合</param>
        /// <param name="commandTimeout">sql超时时间</param>
        public void Insert<T>(IEnumerable<T> entities, int? commandTimeout) where T : class
        {
            _dapper.Insert<T>(Connection, entities, _transaction, commandTimeout);
        }

        /// <summary>
        /// 新增对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="entity">泛型参数·</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <returns>dynamic</returns>
        public dynamic Insert<T>(T entity, int? commandTimeout) where T : class
        {
            return _dapper.Insert<T>(Connection, entity, _transaction, commandTimeout);
        }

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="entity">更新对象</param>
        /// <param name="updateProperties">更新的属性</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <param name="ignoreAllKeyProperties"></param>
        /// <returns>bool</returns>
        public bool Update<T>(T entity, List<string> updateProperties, int? commandTimeout, bool ignoreAllKeyProperties = false) where T : class
        {
            return _dapper.Update<T>(Connection, entity, _transaction, commandTimeout, ignoreAllKeyProperties);
            //return _dapper.Update<T>(Connection, entity, updateProperties, _transaction, commandTimeout, ignoreAllKeyProperties);
        }

        /// <summary>
        /// 删除对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="entity">删除对象</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <returns>bool</returns>
        public bool Delete<T>(T entity, int? commandTimeout) where T : class
        {
            return _dapper.Delete(Connection, entity, _transaction, commandTimeout);
        }

        /// <summary>
        /// 根据条件删除对象
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="predicate">条件</param>
        /// <param name="commandTimeout">sql超时时间</param>
        /// <returns>bool</returns>
        public bool Delete<T>(object predicate, int? commandTimeout) where T : class
        {
            return _dapper.Delete<T>(Connection, predicate, _transaction, commandTimeout);
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="sort"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="buffered"></param>
        /// <returns>IEnumerable<T></returns>
        public IEnumerable<T> GetList<T>(object predicate, IList<ISort> sort, int? commandTimeout, bool buffered) where T : class
        {
            return _dapper.GetList<T>(Connection, predicate, sort, _transaction, commandTimeout, false);
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="resultsPerPage"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="buffered"></param>
        /// <returns>IEnumerable<T></returns>
        public IEnumerable<T> GetPage<T>(object predicate, IList<ISort> sort, int page, int resultsPerPage, int? commandTimeout, bool buffered) where T : class
        {
            return _dapper.GetPage<T>(Connection, predicate, sort, page, resultsPerPage, _transaction, commandTimeout, buffered);
        }

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
        /// <returns>IEnumerable<T></returns>
        public IEnumerable<T> GetSet<T>(object predicate, IList<ISort> sort, int firstResult, int maxResults, int? commandTimeout, bool buffered) where T : class
        {
            return _dapper.GetSet<T>(Connection, predicate, sort, firstResult, maxResults, _transaction, commandTimeout, buffered);
        }

        /// <summary>
        /// 聚合函数 Count
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public int Count<T>(object predicate, int? commandTimeout) where T : class
        {
            return _dapper.Count<T>(Connection, predicate, _transaction, commandTimeout);
        }

        /// <summary>
        /// 返回多个结果集
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        public IMultipleResultReader GetMultiple(GetMultiplePredicate predicate, int? commandTimeout)
        {
            return _dapper.GetMultiple(Connection, predicate, _transaction, commandTimeout);
        }

        /// <summary>
        /// 清除缓存
        /// </summary>
        public void ClearCache()
        {
            _dapper.SqlGenerator.Configuration.ClearCache();
        }

        /// <summary>
        /// 生成GUID对象
        /// </summary>
        /// <returns></returns>
        public Guid GetNextGuid()
        {
            return _dapper.SqlGenerator.Configuration.GetNextGuid();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IClassMapper GetMap<T>() where T : class
        {
            return _dapper.SqlGenerator.Configuration.GetMap<T>();
        }
        #endregion

        #region sql语句
        /// <summary>
        /// 获取第一个字段第一个值（sql）
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="sql">sql</param>
        /// <param name="param">查询参数</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <param name="commandType">commandType</param>
        /// <returns>T</returns>
        T ISqlHelper.GetValue<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.ExecuteScalar<T>(Connection, sql, param, _transaction, commandTimeout, commandType);
        }

        /// <summary>
        /// 获取list泛型集合
        /// </summary>
        /// <typeparam name="T">泛型对象</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="param">查询参数</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <param name="commandType">commandType</param>
        /// <returns>List<T></returns>
        List<T> ISqlHelper.Query<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<T>(Connection, sql, param, _transaction, true, commandTimeout, commandType).ToList();
        }

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
        Dictionary<dynamic, dynamic> ISqlHelper.GetDic<T1, T2>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var dict = Dapper.SqlMapper.Query(Connection, sql, param, _transaction, true, commandTimeout, commandType).ToDictionary(
                    row => (dynamic)row.ID,
                    row => (dynamic)row.Name);
            return dict;
        }

        /// <summary>
        /// Dictionary<string, dynamic> sql
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>Dictionary<string, dynamic></returns>
        Dictionary<string, dynamic> ISqlHelper.GetFirstValues(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            Dictionary<string, dynamic> firstValues = new Dictionary<string, dynamic>();
            List<string> indexColNameMappings = new List<string>();
            int rowIndex = 0;
            using (var reader = Dapper.SqlMapper.ExecuteReader(Connection, sql, param, _transaction, commandTimeout, commandType))
            {
                while (reader.Read())
                {
                    if ((++rowIndex) > 1) break;
                    if (indexColNameMappings.Count == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            indexColNameMappings.Add(reader.GetName(i));
                        }
                    }
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        firstValues[indexColNameMappings[i]] = reader.GetValue(i);
                    }
                }
                reader.Close();
            }
            return firstValues;
        }

        /// <summary>
        /// GetModel<T> sql
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>T</returns>
        T ISqlHelper.GetModel<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstOrDefault<T>(Connection, sql, param, _transaction, commandTimeout, commandType);
        }

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
        List<T> ISqlHelper.GetModelList<T>(string sql, object param = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            var list = Dapper.SqlMapper.Query<T>(Connection, sql, param, _transaction, buffered, commandTimeout, commandType).ToList();
            if (list == null)
            {
                list = new List<T>();
            }
            return list;
        }

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
        T ISqlHelper.GetDynamicModel<T>(Func<IEnumerable<dynamic>, T> buildModelFunc, string sql, object param = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return default(T);
        }

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
        List<T> ISqlHelper.GetMultModelList<T>(string sql, Type[] types, Func<object[], T> map, object param = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<T>(Connection, sql, types, map, param, _transaction, buffered, splitOn, commandTimeout, commandType).ToList();
        }

        /// <summary>
        /// ExecuteCommand sql
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>bool</returns>
        bool ISqlHelper.ExecuteCommand(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            int result = Dapper.SqlMapper.Execute(Connection, sql, param, _transaction, commandTimeout, commandType);
            return (result > 0);
        }

        /// <summary>
        /// ExecuteScalar<T> sql
        /// </summary>
        /// <typeparam name="T">泛型参数T</typeparam>
        /// <param name="sql">sql</param>
        /// <param name="param">param</param>
        /// <param name="commandTimeout">commandTimeout</param>
        /// <param name="commandType">commandType</param>
        /// <returns>T</returns>
        T ISqlHelper.ExecuteScalar<T>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            T result = Dapper.SqlMapper.ExecuteScalar<T>(Connection, sql, param, _transaction, commandTimeout, commandType);
            return result;
        }
        #endregion
    }

}
