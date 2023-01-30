using KevinRosero_ExamenFinal.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinRosero_ExamenFinal.Data
{
    public class PerroDataBaseKR
    {
        string _dbPath;
        private SQLiteConnection conn;
        public PerroDataBaseKR(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Perro>();
        }

        public int AddNewPerro(Perro perro)
        {
            if (perro.Id_KevinR != 0)
                return conn.Update(perro);
            else
                return conn.Insert(perro);
        }

        public int RemovePerro(Perro perro)
        {
            Init();
            return conn.Delete(perro);
        }


        public List<Perro> GetAllPerros()
        {
            Init();
            List<Perro> perros = conn.Table<Perro>().ToList();
            return perros;
        }
    }
}
