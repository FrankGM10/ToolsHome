using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ToolsHome.Models
{
    public class Tarea
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey,AutoIncrement]

        public int Id { get; set; }

        public string Descripcion {  get; set; }

        public DateTime FechaRegistro { get; set; }

        public string Estado { get; set; }
    }
}
