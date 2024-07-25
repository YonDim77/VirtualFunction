using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{

    class People
    {
        public People(string nm, string e)
        {
            name = nm;
            egn = e;
        }
        public virtual void print()
        {
            Console.WriteLine(" Name: " + name + " EGN: " + egn);
        }

        string name;
        string egn;

    }
    class Student : People
    {
        int facNum;
        string address;
        public Student(string nm, string e, int fn, string ad) : base(nm, e)
        {

            facNum = fn;
            address = ad;

        }
        public override void print()
        {
            base.print();
            Console.WriteLine(" FacNum: " + facNum + " Address: " + address);
        }
    }
    class Pstudent : Student
    {
        double fee;
        public Pstudent(string nm, string e, int fn, string ad, double f) : base(nm, e, fn, ad)
        {
            fee = f;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine(" Fee " + fee);
        }
    }
    class Program

    {
        static void Main(string[] args)
        {
            Pstudent ps = new Pstudent("Yonko", "1234567890", 23345, "Dobri Voinikov street 18", 345.0);
            ps.print();
        }
    }
}

