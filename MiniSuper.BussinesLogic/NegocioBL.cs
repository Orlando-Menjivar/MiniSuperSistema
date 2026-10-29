using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;

namespace MiniSuper.BusinessLogic
{
    public class NegocioBL
    {
        private readonly NegocioRepository _repository;

        public NegocioBL(NegocioRepository repository)
        {
            _repository = repository;
        }

        public List<Negocio> SelectAll()
        {
            List<Negocio> result = null;
            try
            {
                result = _repository.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public Negocio Select(int negocioId)
        {
            Negocio entity = null;
            try
            {
                entity = _repository.Select(negocioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }


        public int Insert(Negocio entity)
        {
            int result;
            try
            {
                result = _repository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public int Update(Negocio entity)
        {
            int result;
            try
            {
                result = _repository.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public int Delete(int negocioId)
        {
            int result;
            try
            {
                result = _repository.Delete(negocioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
