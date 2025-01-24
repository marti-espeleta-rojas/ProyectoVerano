﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsCliente.Models
{
    public class Alumno
    {
        [JsonPropertyName("nota")]
        public decimal Nota { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("lu")]
        public int LU { get; set; }
    }
}
