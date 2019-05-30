using Business.Model;
using Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Data
{
    public class DegreeSubjectData
    {
        public static Boolean Crear(int DegreeId, int SubjectId)
        {
            ApptecEntities data = new ApptecEntities();
            Boolean existe = false;
            var s = new DegreeSubject
            {
               DegreeID=DegreeId,
               SubjectsID=SubjectId
            };
            data.DegreeSubjects.Add(s);
            data.SaveChanges();

            if (s != null)
                existe = true;

            return existe;
        }


        public static List<DegreeSubjectAllModel> Mostrar()
        {
            using (var Contexto = new ApptecEntities())
            {
                var Resultado = (from degreeSubject in Contexto.DegreeSubjects
                                 select new DegreeSubjectAllModel
                                 {
                                     DegreeId=degreeSubject.DegreeID,
                                     SubjectId=degreeSubject.SubjectsID
                                 }).ToList();
                return Resultado;
            }
        }

        public static Boolean Actualizar(int Id, int DegreeId, int SubjectId )
        {
            Boolean existe = false;

            ApptecEntities data = new ApptecEntities();
            var consulta = data.DegreeSubjects.First(d => d.DegreeSubjectsID ==Id);
            if (consulta != null)
            {
                consulta.DegreeID = DegreeId;
                consulta.SubjectsID = SubjectId;
                data.SaveChanges();
                existe = true;
            }

            return existe;
        }

        public static List<DegreeAllModel> GetDegree()
        {
            using (var Contexto = new ApptecEntities())
            {
                var Resultado = (from degree in Contexto.Degrees
                                 select new DegreeAllModel
                                 {
                                     Id = degree.DegreeID,
                                     Nombre = degree.Name
                                 }).ToList();
                return Resultado;
            }
        }

    }
    }

