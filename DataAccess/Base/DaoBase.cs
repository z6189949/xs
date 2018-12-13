using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace DataAccess.Base
{
    public class DaoBase<T> : IDisposable
    {
        protected const string Connn_String = "zzzsConn";
        private Database _db;
        public Database Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new Database(Connn_String);
                }
                return _db;
            }
            set
            {
                _db = value;
            }
        }
        /// <summary>
        /// 通过实体类的主键获取实体
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>实体</returns>
        public virtual T GetEntity(object id)
        {
            return Db.SingleOrDefault<T>(id);
        }
        public virtual bool IsNew(T entity) {
            return Db.IsNew(entity);
        }
        public virtual void Save(object entity)
        {
            Db.Save(entity);
        }
        /// <summary>
        /// 通过sql查询语句查询实体
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="args">sql语句需要i的参数</param>
        /// <returns>实体</returns>
        public virtual T ExecuteScalar(string sql, params object[] args)
        {
            return Db.ExecuteScalar<T>(sql, args);
        }
        /// <summary>
        /// 通过sql语句查询实体类的集合
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="args">sql语句需要i的参数集合</param>
        /// <returns></returns>
        public virtual List<T> GetList(string sql, params object[] args)
        {
            return Db.Fetch<T>(sql, args);
        }
        /// <summary>
        /// 返回sql查询结果的分页数据
        /// </summary>
        /// <param name="pageIndex">返回第几页</param>
        /// <param name="pageSize">返回页的数据量</param>
        /// <param name="sql">sql语句</param>
        /// <param name="args">sql语句需要i的参数集合</param>
        /// <returns></returns>
        public virtual Page<T> Page(int pageIndex, int pageSize, string sql, params object[] args)
        {
            return Db.Page<T>(pageIndex, pageSize, sql, args);
        }
        /// <summary>
        /// 添加一条新的纪录
        /// </summary>
        /// <param name="entity">要添加的实体</param>
        /// <returns>该实体的主键</returns>
        public virtual object Insert(T entity)
        {
            return Db.Insert(entity);
        }
        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>修改后影响的行数</returns>
        public virtual int Delete(T entity)
        {
            return Db.Update(entity);
        }
        /// <summary>
        /// 返回sql语句查询结果的第一条实体
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="args">sql语句需要的参数</param>
        /// <returns>实体</returns>
        protected virtual T FirstOrDefault(string sql, params object[] args)
        {
            return Db.FirstOrDefault<T>(sql, args);
        }
        public virtual int Update(T entety)
        {
            return Db.Update(entety);
        }
        /// <summary>
        /// 关闭数据库释放资源
        /// </summary>
        public void Dispose()
        {
            _db.Dispose();
            Db = null;
        }
    }
}
