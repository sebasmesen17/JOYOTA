using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntity;

namespace DataAccess
{
    public class DADepartamento
    {
        public static List<Departamento> GetAll()
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<Departamento> d = null;
            try
            {
                d = db.Departamento.OrderBy(c => c.IDDepartamento).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return d;
        }
        public static int GenID()
        {
            ModelJoyotaSa db = new ModelJoyotaSa();
            List<Departamento> v = null;
            try
            {

                v = db.Departamento.OrderBy(c => c.IDDepartamento).ToList();
                if (v.Count != 0)
                {
                    return v.Max(c => c.IDDepartamento) + 1;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return v.Count + 1;
        }

        public static void Update(Departamento v)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    Departamento d = db.Departamento.FirstOrDefault(c => c.IDDepartamento == v.IDDepartamento);
                    d.nombreDepartamento = v.nombreDepartamento;
                    //db.Departamento.Add(d);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public static void Delete(Departamento departamento)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {

                try
                {
                    Departamento v = new Departamento();
                    v = db.Departamento.Where(c => c.IDDepartamento == departamento.IDDepartamento).FirstOrDefault();
                    db.Departamento.Remove(v);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
        }

        public static Departamento GetID(int id)
        {

            ModelJoyotaSa db = new ModelJoyotaSa();
            Departamento v = null;

            try
            {
                v = db.Departamento.First(c => c.IDDepartamento == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return v;
        }

        public static void Insert(Departamento v)
        {
            using (ModelJoyotaSa db = new ModelJoyotaSa())
            {
                try
                {
                    db.Departamento.Add(v);
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
