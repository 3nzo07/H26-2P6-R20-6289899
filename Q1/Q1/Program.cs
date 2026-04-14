using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Q1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ToDo2();
            
        }
        /// <summary>
        // TODO 2 : Pour chaque Exception prévue dans la classe, écrire du code permettant de :
        // - Déclencher cette exception
        // - intercepter cette exception en affichant un message sur la console pour confirmer
        //   que l'exception a été levée ainsi que le message de l'exception
        /// </summary>
        static void ToDo2()
        {                    
            //Ordinateur Msi = new Ordinateur("Modern B15m", new DateTime(2023,24,12));
            
            

            try
            {
                
                Ordinateur windows = new Ordinateur("", new DateTime(2026, 04, 15));
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Ordinateur Linux = new Ordinateur("Linux", new DateTime(2026, 04, 13));
                Linux.
            }
        }
    }
}
