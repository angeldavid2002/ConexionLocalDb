﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class PersonaRepository
    {
        private readonly SqlConnection _connection;

        public PersonaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
    }
}
