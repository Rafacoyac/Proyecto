﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Model
{
    public class LessonAllModel
    {

        public string Dia { get; set; }
        public int EmpleadosId { get; set; }
        public TimeSpan HoraIn { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int AulaId { get; set; }
        public int MateriaId { get; set; }
        public int GrupoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaMod { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioMod { get; set; }
        public string Estado { get; set; }
    }
}