using Business.Model;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Data
{
    public class StudentData
    {
        public static Boolean Crear(string Matricula, string Nombre, string Apellidop, string Apellidom, string Telefono, int InstitucionId, int GrupoId, string Password)
        {
            ApptecEntities data = new ApptecEntities();
            Boolean existe = false;
            var s = new Student
            {
                Enrollment=Matricula,
                Name = Nombre,
                LastNameP=Apellidop,
                LastNameM=Apellidom,
                Phone=Telefono,
                InstitutionID=InstitucionId,
                GroupsID=GrupoId,
                Password=Password,
                DateTimeCreation = DateTime.Now,
                DateTimeModification = DateTime.Now,
                UserCreation = "Beatriz",
                UserModification = "Bea",
                Status = "1"
            };
            data.Students.Add(s);
            data.SaveChanges();

            if (s != null)
                existe = true;

            return existe;
        }


        public static List<StudentAllModel> Mostrar()
        {
            using (var Contexto = new ApptecEntities())
            {
                var Resultado = (from student in Contexto.Students
                                 where student.Status == "1"
                                 select new StudentAllModel
                                 {
                                    Matricula=student.Enrollment,
                                    Nombre=student.Name,
                                    Apellidop=student.LastNameP,
                                    Apellidom=student.LastNameM,
                                    Telefono=student.Phone,
                                    InstitucionId=student.InstitutionID,
                                    GrupoId=student.GroupsID,
                                    Password=student.Password
                                 }).ToList();
                return Resultado;
            }
        }

        public static Boolean Actualizar(int Id, string Matricula, string Nombre, string Apellidop, string Apellidom, string Telefono, int InstitucionId, int GrupoId)
        {
            Boolean existe = false;

            ApptecEntities data = new ApptecEntities();
            var consulta = data.Students.First(d => d.StudentsID == Id);
            if (consulta != null)
            {
                consulta.Enrollment=Matricula;
                consulta.Name =Nombre;
                consulta.LastNameP = Apellidop;
                consulta.LastNameM = Apellidom;
                consulta.Phone = Telefono;
                consulta.InstitutionID = InstitucionId;
                consulta.GroupsID = GrupoId;
                // consulta.Password = student.Password;
                consulta.DateTimeModification = DateTime.Now;
                consulta.UserModification = "Nuevo";
                data.SaveChanges();
                existe = true;
            }

            return existe;
        }

        public static Boolean Eliminar(int Id)
        {
            Boolean existe = false;

            ApptecEntities data = new ApptecEntities();
            var consulta = data.Students.First(d => d.StudentsID == Id);
            if (consulta != null)
            {
                consulta.Status = "0";
                data.SaveChanges();
                existe = true;
            }

            return existe;
        }
    }
}