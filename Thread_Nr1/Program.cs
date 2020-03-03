using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Nr1 {
    class Program {
        static void Main ( string [] args ) {
            
            //Thread 1
            ThreadStart thstart = new ThreadStart (Hallo);
            Thread meinThread = new Thread (thstart);
            
            meinThread.Start ();
            meinThread.Join ();
            

            // Thead 2
            ParameterizedThreadStart pts = new ParameterizedThreadStart (Hallo);
            Thread meinZweiterThread = new Thread (pts);
            meinZweiterThread.Start ("Hallo Welt");
            meinZweiterThread.Join ();

            Console.WriteLine ("Hi");
            Console.Read ();
        }

        // Klassenmethode
        private static void Hallo () {
            for ( int i = 0 ; i < 10 ; i++ ) {
                Console.WriteLine ( "wichtige thread-Information" );
            }
        }
        // Klassenmethode
        private static void Hallo (object o) {
            for ( int i = 0 ; i < 10 ; i++ ) {
                Console.WriteLine ( "total wichtige thread-Information {0}", (string) o );
            }
        }
    }
}
