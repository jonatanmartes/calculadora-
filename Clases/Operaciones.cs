using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones.Clases
{
    /// <summary>
    /// Implementacion de la clase utilizada para realizar las cuatro operaciones básicas
    /// </summary>
    public sealed class Operaciones
    {
        public static double Respuesta;
        /// <summary>
        /// Este método permite sumar dos números
        /// </summary>
        /// <param name="Pnumero">Primer Número</param>
        /// <param name="Snumero">Segundo Número</param>
        /// <param name="Mensaje">Mensaje de Retorno</param>
        /// <returns></returns>
        public static double Sumar(double Pnumero, double Snumero, out string Mensaje)
        {
            try
            {
                Respuesta = Pnumero + Snumero;
                Mensaje = null;
                return Respuesta;
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Respuesta = 0;
                return Respuesta;
            }
        }
        /// <summary>
        /// Este método permite restar dos números
        /// </summary>
        /// <param name="Pnumero">Primer Número</param>
        /// <param name="Snumero">Segundo Número</param>
        /// <param name="Mensaje">Mensaje de Retorno</param>
        /// <returns></returns>
        public static double Restar(double Pnumero, double Snumero, out string Mensaje)
        {
            try
            {
                Respuesta = Pnumero - Snumero;
                Mensaje = null;
                return Respuesta;
            }
            catch(Exception ex)
            {
                Mensaje = ex.Message;
                Respuesta = 0;
                return Respuesta;
            }
        }
        public static double Multiplicar(double Pnumero, double Snumero, out string Mensaje)
        {
            try
            {
                Respuesta = Pnumero * Snumero;
                Mensaje = null;
                return Respuesta;
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Respuesta = 0;
                return Respuesta;
            }
        }
        public static double Dividir(double Pnumero, double Snumero, out string Mensaje)
        {
            try
            {
                Respuesta = Pnumero / Snumero;
                Mensaje = null;
                return Respuesta;
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Respuesta = 0;
                return Respuesta;
            }
        }
    }
}
