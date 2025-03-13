using System;
using System.Runtime.Versioning;

namespace Start // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kollision(2, 4, 8, 3,9);
        }
        static void Kollision(int SetScale, int TopwallY, int TopwallX, int RightwallY, int RightwallX)
        {
            if (KollisionY(TopwallY, TopwallX, SetScale) == true)
            {
                if (KollisionX(RightwallY, RightwallX, SetScale) == true)
                {
                    Console.WriteLine("Boom");
                }
                else
                {
                    Console.WriteLine("nicht Boom");
                }
            }
            else
            {
                Console.WriteLine("nicht Boom");
            }
        }
        static Boolean KollisionY(int x, int y,int z)
        {
            if (Math.Abs(x - y) <= z )
            {
                return true;
            }
            else
            {  
                return false; 
            }
        }
        static Boolean KollisionX(int x, int y, int z)
        {
            if (Math.Abs(x - y) <= z )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
