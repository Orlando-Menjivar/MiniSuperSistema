using MiniSuper.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.DataAccess
{
    public class TipoMovimientoInventarioRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public TipoMovimientoInventarioRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<TipoMovimientoInventario> SelectAll()
        {
            List<TipoMovimientoInventario> result = null;
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpTipoMovimientoInventarioSelectAll", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        result = new List<TipoMovimientoInventario>();
                        while (rd.Read())
                        {
                            TipoMovimientoInventario entity = new TipoMovimientoInventario
                            {
                                TipoMovimientoId = rd.GetInt32(0),
                                TipoMovimiento = rd.GetString(1)
                            };
                            result.Add(entity);
                        }
                    }
                }
            }
            return result;
        }

        public TipoMovimientoInventario Select(int tipoMovimientoId)
        {
            TipoMovimientoInventario entity = null;
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpTipoMovimientoInventarioSelect", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoMovimientoId", tipoMovimientoId);
                    conn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (rd.Read())
                        {
                            entity = new TipoMovimientoInventario
                            {
                                TipoMovimientoId = rd.GetInt32(0),
                                TipoMovimiento = rd.GetString(1)
                            };
                        }
                    }
                }
            }
            return entity;
        }

        public int Insert(TipoMovimientoInventario entity)
        {
            int result = 0;
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpTipoMovimientoInventarioInsert", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoMovimiento", entity.TipoMovimiento);
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }

        public int Update(TipoMovimientoInventario entity)
        {
            int result = 0;
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpTipoMovimientoInventarioUpdate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoMovimientoId", entity.TipoMovimientoId);
                    cmd.Parameters.AddWithValue("@TipoMovimiento", entity.TipoMovimiento);
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }

        public int Delete(int tipoMovimientoId)
        {
            int result = 0;
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SpTipoMovimientoInventarioDelete", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoMovimientoId", tipoMovimientoId);
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }
    }
}
