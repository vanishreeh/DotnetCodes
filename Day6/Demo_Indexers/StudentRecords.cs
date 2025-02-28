using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexers
{
    class StudentRecords
    {
        int id;
        string name;

        //constructor
        public StudentRecords(int id,string name)
        {
            this.id= id;
            this.name = name;

        }
        //public int this[int index]
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        //public string this[int index]
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        public object this[int index]
        {
            get 
            {
                if (index == 1) return id;
                if (index == 2) return name;
                return null;
            }
            set 
            {
                if (index == 1)  id=(int)value;
                if (index == 2) name = (string)value;
            }
        }
        //int[] marks = { 30, 60, 90, 80 };

        //indexers
        //public int[] Marks { get; set; }

        //public int this[int index]{get;set:getter and Setter property}
        //public int this[int index] 
        //{
        //    get { return marks[index]; }
        //    set { marks[index]= value; }
        //}
    }
    }
