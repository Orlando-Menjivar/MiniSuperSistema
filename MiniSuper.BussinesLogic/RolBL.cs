using MiniSuper.Entity;
using System;
using MiniSuper.DataAccess;
using System.Collections.Generic;


namespace MiniSuper.BussinesLogic
{
    public class RolBL
    {
        private readonly RolRepository _Repository;
        public RolBL(RolRepository Repository)
        {
            _Repository = Repository;
        }

        public List<Rol> SelectAll()
        {
            List<Rol> result = null;
            try
            {
                result = _Repository.SelectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public Rol Select(int rolId)
        {
            Rol entity = null;
            try
            {
                entity = _Repository.Select(rolId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public int Insert(Rol entity)
        {
            int result;
            try
            {
                result = _Repository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Update(Rol entity)
        {
            int result;
            try
            {
                result = _Repository.Update(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Delete(int rolId)
        {
            int result;
            try
            {
                result = _Repository.Delete(rolId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }



    }
}
