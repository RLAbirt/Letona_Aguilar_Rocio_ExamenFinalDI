using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using ObjetosTransferencia.DTO;

namespace BusinessLogicLayer
{
    public static class ControladorBLL
    {

        #region Atributos


        #endregion

        #region Constructores

        #endregion

        #region Propiedades

        #endregion

        #region Metodos


        /// <summary>
        /// Pedir datos de la lista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public static List<ClienteDTO> PedirListaClientes()
        {
            // TODO: llama al metodo que pide la lista de clientes
            List<ClienteDTO> listaC;
            try
            {
                listaC = AccesoDatosDAL.ListadoClientesNorthWind();
            }
            catch (Exception e)
            {
                throw new Exception("No se ha podido estabecer la conexion con la BD!" + e.Message);

            }

            return listaC;

        }


        /// <summary>
        /// Pedir la lista de pedidos de un clientelista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public static List<PedidoDTO> ListarPedidosCliente(String nombreCliente)
        {
            // TODO: llamar al metodo que lista los pedidos
            List<PedidoDTO> listaP;
            try
            {
               listaP = AccesoDatosDAL.ListadoPedidosCliente(nombreCliente);
            }
            catch (Exception e)
            {
                throw new Exception("No se ha podido estabecer la conexion con la BD!" + e.Message);

            }
  

            return listaP;
        }


        #endregion


    }
}
