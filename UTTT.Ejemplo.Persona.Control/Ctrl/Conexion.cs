﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace UTTT.Ejemplo.Persona.Control.Ctrl
{
    public class Conexion
    {
        #region Variables
     
        #endregion

        #region Constructores
        public Conexion()
        {
        }       
        #endregion


        public SqlConnection sqlConnection()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-UO7C7U71\\SQLEXPRESS;Initial Catalog=Persona;User ID=sa;Password=1234");
                return conexion;
            }
            catch (Exception _e)
            { 
            
            }
            return null;
        }
    }
}
