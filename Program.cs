using System;
using ProjetoAMT.src.Entities;

namespace projetoamt
{
    class Program
    {
        static void Main(string[]args)
        {
            Analyst junior = new Analyst("Pedro", 1, "Front");
            Analyst full = new Analyst("Carla", 2, "Mobile");
            Manager senior = new Manager("Miguel", 3, "Projetos");
            
            Console.WriteLine(junior.Target());
            Console.WriteLine(full.Target());
            Console.WriteLine(senior.Target(10));

        }
    }
}