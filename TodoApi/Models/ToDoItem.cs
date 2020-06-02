using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class ToDoItem
    {
        //instance field
        private int _id;
        private string _lastbil;
        private string _chauffor;
        private int _antalkm;
        private double _gennemsnit;

        //tom constructor som bruges med databasen og tcp
        public ToDoItem()
        {

        }

        //contructor
        public ToDoItem(int id, string lastbil, string chauffor, int antalkm, double gennemsnit)
        {
            Id = id;
            Lastbil = lastbil;
            Chauffor = chauffor;
            Antalkm = antalkm;
            Gennemsnit = Gennemsnit;

        }

        //properties
        public int Id
        {
            get;
            set;

        }

        public string Lastbil
        {
            get;
            set;
        }

        public string Chauffor
        {
            get;
            set;
        }

        public int Antalkm
        {
            get;
            set;
        }

        public double Gennemsnit
        {
            get;
            set;
        }
    }
}
