using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.BussinesLogic
{
    public class TipoMovimientoInventarioBL
    {
        private readonly TipoMovimientoInventarioRepository _repository;

        public TipoMovimientoInventarioBL(TipoMovimientoInventarioRepository repository)
        {
            _repository = repository;
        }

        public List<TipoMovimientoInventario> SelectAll()
        {
            List<TipoMovimientoInventario> result = null;
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

        public TipoMovimientoInventario Select(int tipoMovimientoInventarioId)
        {
            TipoMovimientoInventario entity = null;
            try
            {
                entity = _repository.Select(tipoMovimientoInventarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }


        public int Insert(TipoMovimientoInventario entity)
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

        public int Update(TipoMovimientoInventario entity)
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

        public int Delete(int tipoMovimientoInventarioId)
        {
            int result;
            try
            {
                result = _repository.Delete(tipoMovimientoInventarioId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
