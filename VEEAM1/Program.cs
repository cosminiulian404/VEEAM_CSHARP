﻿namespace VEEAM1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            new AppBuilder(args[1], args[2], Convert.ToInt16(args[3])).Start();
           
          
        }
    }
}

 
