using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using EMK.Collections;


namespace EMK.Tests
{
	/// <summary>
	/// Simple test for the SortableList class.
	/// Shows the way to use the basic properties and methods.
	/// </summary>
	public class TestSortedList
	{
		/// <summary>
		/// Icomparer to provide to the SortableList constructor
		/// </summary>
		[Serializable]
		class AntiAlphabeticalComparer: IComparer
		{
			public int Compare(object O1, object O2)
			{
				string S1 = O1.ToString();
				string S2 = O2.ToString();
				return -String.Compare(S1, S2);
			}
		}

		/// <summary>
		/// Entry point for the SortableList use case.
		/// </summary>
		public static void Main()
		{
			try
			{
				Console.WriteLine("You create a new SortableList." );
				SortableList SL = new SortableList();

				Console.Write("You set the KeepSorted property to false and you fill it with the strings X, B, A, D: " );
				SL.KeepSorted = false;
				SL.Add("X");
				SL.Add("B");
				SL.Add("A");
				SL.Add("D");
				Console.WriteLine(SL);

				Console.Write("You can insert or set elements where you want since KeepSorted==false. Let's set 'C' to index 4: ");
				SL[3] = "C";
				Console.WriteLine(SL);

				Console.Write("You decide to sort the list: ");
				SL.Sort();
				Console.WriteLine(SL);

				Console.Write("You now set the KeepSorted property to true and add some new strings: ");
				SL.KeepSorted = true;
				SL.Add("J");
				SL.Add("E");
				SL.Add("E");
				SL.Add("B");
				SL.Add("X");
				SL.Add("E");
				SL.Add("E");
				Console.WriteLine(SL);

				Console.WriteLine("'E' is found at index "+SL.IndexOf("E").ToString());
				Console.WriteLine("Is the list containing an 'X' value ?: "+SL.Contains("X").ToString());
				Console.WriteLine("Is the list containing an 'M' value ?: "+SL.Contains("M").ToString());

				Console.Write("You limit the number of occurrences of 'E' to 2: ");
				SL.LimitNbOccurrences("E", 2);
				Console.WriteLine(SL);

				Console.Write("After all you do not want any duplicates: ");
				SL.RemoveDuplicates();
				Console.WriteLine(SL);

				Console.Write("You set the AddDuplicates property to false and try to add J and E again: ");
				SL.AddDuplicates = false;
				SL.Add("J");
				SL.Add("E");
				Console.WriteLine(SL);

				Console.WriteLine("Now you create another SortableList but this time you give it an IComparer class which is the anti-alphabetical order." );
				SL = new SortableList( new AntiAlphabeticalComparer() );

				Console.Write("You fill the list by adding a range of vowels in alphabetical order. Result: " );
				string[] Vowels = new string[] {"A", "E", "I", "O", "U"};
				SL.AddRange(Vowels);
				Console.WriteLine(SL);

				Console.Write("Serialize and Deserialize: ");
				Stream StreamWrite = File.Create("SortableListSaved.bin");
				BinaryFormatter BinaryWrite = new BinaryFormatter();
				BinaryWrite.Serialize(StreamWrite, SL);
				StreamWrite.Close();

				Stream StreamRead = File.OpenRead("SortableListSaved.bin");
				BinaryFormatter BinaryRead = new BinaryFormatter();
				SortableList SL2 = (SortableList) BinaryRead.Deserialize(StreamRead);
				StreamRead.Close();
				Console.WriteLine(SL2);
			}
			catch(Exception e) { Console.Write( "Error :\n\n"+e.ToString() ); }

			Console.ReadLine();
		}		
	}
}
