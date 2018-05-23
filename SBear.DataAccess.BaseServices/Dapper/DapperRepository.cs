//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Text;
//using Microsoft.Extensions.Configuration;
//using SBear.DataAccess.BaseServices.Interface;
//using Dapper;
//using DapperExtensions;

//namespace SBear.DataAccess.BaseServices.Dapper
//{
//    public class DapperRepository<T> : IRepository<T> where T : class
//    {
//        private readonly DapperFactory _dapperFactory;
//        DapperRepository(IConfigurationRoot configuration)
//        {
//            _dapperFactory = new DapperFactory(configuration);
//        }
//        public T Get(object id)
//        {
//            using (var conn = _dapperFactory.CreateDbConnection())
//            {
//                return conn.Get<T>(id);
//            }
//        }
//        public T Insert(T entity)
//        {
//            using (var conn = _dapperFactory.CreateDbConnection())
//            {
//                return conn.Insert(entity);
//            }
//        }
//        public T Update(T entity)
//        {
//            using (var conn = _dapperFactory.CreateDbConnection())
//            {
//                conn.Update(entity);
//                return entity;
//            }
//        }
//        public bool Delete(T entity)
//        {
//            using (var conn = _dapperFactory.CreateDbConnection())
//            {
//                return conn.Delete(entity);
//            }
//        }
//        public bool Delete(object id)
//        {
//            using (var conn = _dapperFactory.CreateDbConnection())
//            {
//                var entity = conn.Get<T>(id);
//                return conn.Delete(entity);
//            }
//        }
//        public IEnumerable<T> GetAll()
//        {
//            throw new NotImplementedException();
//        }
//        public IEnumerable<T> GetList(Expression<Func<T, bool>> @where = null, Expression<Func<T, bool>> order = null)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
