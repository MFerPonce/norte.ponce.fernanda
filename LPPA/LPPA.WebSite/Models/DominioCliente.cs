﻿using System.Collections.Generic;

namespace LPPA.WebSite.Models
{
    public class DominioCliente
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static void Add(Cliente cli)
        {
            clientes.Add(cli);
        }

        public static List<Cliente> Get()
        {
            return clientes;
        }
    }
}