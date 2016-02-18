using System;
using System.Collections;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using EMK.Cartography;

namespace EMK.Tests
{
	public class TestAStar
	{

        //   0  1  2  3  4
        // 0 __ __ __ N6 __
        // 1 N3 __ N5 __ __
        // 2 __ N2 __ N4 __
        // 3 __ __ N1 __ __
        // 4 __ __ __ __ __
        //
        // Begin:N1
        // Goal:N6
        // Links of Nodes: N3<-N2<-N1->N4->N5->N6
        // Result way:N1->N4->N5->N6


		public static void Main()
		{
			try
			{

                var G = new Graph();

                Node N1 = G.AddNode(2,3,0);
                Node N2 = G.AddNode(1,2,0);
                Node N3 = G.AddNode(0,1,0);
                Node N4 = G.AddNode(3,2,0);
                Node N5 = G.AddNode(2, 1, 0);
                Node N6 = G.AddNode(3, 0, 0);

                G.AddArc(N1,N2,1);
                G.AddArc(N2,N3,1);
                G.AddArc(N1,N4,1);
                G.AddArc(N4,N5,1);
                G.AddArc(N5, N6, 1);

				Console.WriteLine( ListNodesAndArcs(G) );
				Console.WriteLine("Start:"+N1.ToString());
                Console.WriteLine("Goal:" + N6.ToString());

				AStar AS = new AStar(G);
                if (AS.SearchPath(N1, N6))
                {
                    foreach (Arc A in AS.PathByArcs)
                        Console.WriteLine(A.ToString());
                }
                else
                {
                    Console.WriteLine("No result !");
                }

			}
			catch(Exception e) 
            { 
                Console.Write( "Error :\n\n"+e.ToString() ); 
            }
			Console.ReadLine();
		}

		static private string ListNodesAndArcs(Graph GraphToDescribe)
		{
			StringBuilder SB = new StringBuilder("Description of the Graph:\n\tNodes> ");
			foreach (Node N in GraphToDescribe.Nodes) SB.Append( N.ToString()+"; " );
			SB.Append("\n\tArcs> ");
			foreach (Arc A in GraphToDescribe.Arcs) SB.Append( A.ToString()+"; " );
			return SB.ToString();
		}
	}
}
