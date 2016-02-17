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
		public static void Main()
		{
			try
			{
				Graph G = new Graph();
				Node N1 = G.AddNode(0,0,0);
				Node N2 = G.AddNode(5,0,0);
				Node N3 = G.AddNode(5,5,0);
				Node N4 = G.AddNode(5,5,5);
				G.AddArc(N1,N2,1);
				G.AddArc(N2,N3,1);
				G.AddArc(N3,N4,1);
				G.AddArc(N1,N3,1);

				Console.WriteLine( ListNodesAndArcs(G) );
				Console.WriteLine("- Best path to reach "+N4.ToString()+" from "+N1.ToString()+" :");
				AStar AS = new AStar(G);
				if ( AS.SearchPath(N1, N4) )
					foreach (Arc A in AS.PathByArcs) Console.WriteLine( A.ToString() );
				else Console.WriteLine( "No result !" );

				Console.WriteLine("Serialize and Deserialize: ");
				Stream StreamWrite = File.Create("GraphSaved.bin");
				BinaryFormatter BinaryWrite = new BinaryFormatter();
				BinaryWrite.Serialize(StreamWrite, G);
				StreamWrite.Close();

				Stream StreamRead = File.OpenRead("GraphSaved.bin");
				BinaryFormatter BinaryRead = new BinaryFormatter();
				Graph G2 = (Graph) BinaryRead.Deserialize(StreamRead);
				StreamRead.Close();
				Console.WriteLine( ListNodesAndArcs(G2) );
			}
			catch(Exception e) { Console.Write( "Error :\n\n"+e.ToString() ); }
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
