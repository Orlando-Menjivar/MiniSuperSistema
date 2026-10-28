using MiniSuper.DataAccess;
using MiniSuper.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.BussinesLogic
{
    public class EmpleadoBL
    {
        private readonly EmpleadoRepository _repository;

        public EmpleadoBL(EmpleadoRepository repository)
        {
            _repository = repository;
        }

        public List<Empleado> SelectAll()
        {
            List<Empleado> result = null;
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

        public Empleado Select(int empleadoId)
        {
            Empleado entity = null;
            try
            {
                entity = _repository.Select(empleadoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public int Insert(Empleado entity)
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


        public int Update(Empleado entity)
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


        public int Delete(int empleadoId)
        {
            int result;
            try
            {
                result = _repository.Delete(empleadoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
