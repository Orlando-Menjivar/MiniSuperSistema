using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;

namespace MiniSuper.BusinessLogic
{
    public class CategoriaBL
    {
        private readonly CategoriaRepository _repository;

        public  CategoriaBL(CategoriaRepository repository)
        {
            _repository = repository;
        }

        public List< Categoria> SelectAll()
        {
            List< Categoria> result = null;
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

        public Categoria Select(int categoriaId)
        {
            Categoria entity = null;
            try
            {
                entity = _repository.Select(categoriaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public int Insert(Categoria entity)
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

        public int Update(Categoria entity)
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

        public int Delete(int categoriaId)
        {
            int result;
            try
            {
                result = _repository.Delete(categoriaId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}