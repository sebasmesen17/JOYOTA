using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
    public class DAEmpleado
    {
        public static List<Empleado> GetAll()
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<Empleado> emp = null;
            try
            {
                emp = db.Empleado.OrderBy(c => c.IDEmpleado).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return emp;
        }

        public static Empleado GetID(int id)
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            Empleado emp = null;
            try
            {
                emp = db.Empleado.First(c => c.IDEmpleado == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return emp;
        }

        public static void Update(Empleado v)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {

                try
                {
                    Empleado e = db.Empleado.First(c => c.IDEmpleado == v.IDEmpleado);
                    e.nombre = v.nombre;
                    e.salario = v.salario;


                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public static void Delete(Empleado a)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {

                try
                {

                    Empleado emp = new Empleado();
                    emp = db.Empleado.Where(c => c.IDEmpleado == a.IDEmpleado).FirstOrDefault();
                    db.Empleado.Remove(emp);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public static void Insert(Empleado v)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {

                try
                {
                    db.Empleado.Add(v);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
    }
}
