using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21F_sor_verem_gyak
{
	internal class Program
	{

		/// <summary>
		/// Kiadja a v verem i-edik elemét úgy, hogy a verem a függvény után változatlan marad.
		/// </summary>
		/// <param name="verem"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static string Element_at(Stack<string> v, int i)
		{
			// hibakezelés:
			if (v.Count <= i)
				throw new IndexOutOfRangeException();
			if (i<0)
				throw new IndexOutOfRangeException();

			Stack<string> atmeneti = new Stack<string>();

			for (int j = 0; j < i; j++)
			{
				atmeneti.Push(v.Pop());
			}
			string result = v.Peek();

			for (int j = 0; j < i; j++)
			{
				v.Push(atmeneti.Pop());
			}

			return result;

		}

		/// <summary>
		/// Kiadja az s sor i-edik elemét úgy, hogy a sor a függvény után változatlan marad.
		/// </summary>
		/// <param name="sor"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static string Element_at(Queue<string> s, int i)
		{
			for (int j = 0; j < i; j++)
			{
				s.Enqueue(s.Dequeue());
			}
			string result = s.Peek();
			for (int j = 0; j < s.Count-i; j++)
			{
				s.Enqueue(s.Dequeue());
			}
			return result;
		}


		/// <summary>
		/// Megadja, hogy az e elemet tartalmazza-e a verem
		/// </summary>
		/// <param name="verem"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static bool Contains(Stack<string> v, string e)
		{
			return true;
		}


		/// <summary>
		/// Megadja, hogy az e elemet tartalmazza-e a sor
		/// </summary>
		/// <param name="sor"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static bool Contains(Queue<string> s, string e)
		{
			return true;
		}


		/// <summary>
		/// Kiírja a sor összes elemét
		/// </summary>
		/// <param name="sor"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static void Kiir(Queue<string> s)
		{
			for (int i = 0; i < s.Count; i++)
			{
				string str = s.Dequeue();
				Console.WriteLine($"[{i}]: {str}");
				s.Enqueue(str);
			}
		}

		/// <summary>
		/// Kiírja a verem összes elemét
		/// </summary>
		/// <param name="verem"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static void Kiir(Stack<string> s)
		{
			Stack<string> atmeneti = new Stack<string>();

			int i = 0;
			// átpakoljuk az átmeneti verembe és közben kiírjuk!
			while (s.Count!=0)
			{
				string t = s.Pop();
				Console.WriteLine($"[{i++}]: {t}");
				atmeneti.Push(t);
			}
			// Visszapakolás
			while(atmeneti.Count!=0)
			{
				s.Push(atmeneti.Pop());
			}
		}

		/// <summary>
		/// Megkeresi az első predicate tulajdonságú elemet és visszadja azt.
		/// </summary>
		/// <param name="sor"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static string Keres(Queue<string> s, Func<string, bool> predicate)
		{
			return "";
		}

		/// <summary>
		/// Megkeresi az első predicate tulajdonságú elemet és visszadja azt.
		/// </summary>
		/// <param name="verem"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static string Keres(Stack<string> s, Func<string, bool> predicate)
		{
			return "";
		}


		/// <summary>
		/// Megfordítja az elemek sorrendjét.
		/// </summary>
		/// <param name="verem"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static void Reverse(Stack<string> s)
		{
		}

		/// <summary>
		/// Megfordítja az elemek sorrendjét.
		/// </summary>
		/// <param name="sor"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static void Reverse(Queue<string> s)
		{
		}

		/// <summary>
		/// Kiválogatja a predicate tulajdonságú elemeket, amiket megtart, a többit kidobálja.
		/// </summary>
		/// <param name="verem"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static void Kiválogat(Queue<string> s, Func<string, bool> predicate)
		{
		}

		/// <summary>
		/// Kiválogatja a predicate tulajdonságú elemeket, amiket megtart, a többit kidobálja.
		/// </summary>
		/// <param name="verem"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		static void Kiválogat(Stack<string> s, Func<string, bool> predicate)
		{
		}

		/// <summary>
		/// Kiveszi és eltávolítja a legnagyobb elemet.
		/// </summary>
		static string Max(Stack<string> s, Func<string, string, int> comparator)
		{
			return "";
		}


		/// <summary>
		/// Kiveszi és eltávolítja a legnagyobb elemet.
		/// </summary>
		static string Max(Queue<string> s, Func<string, string, int> comparator)
		{
			return "";
		}

		/// <summary>
		/// Kiveszi és eltávolítja a legnagyobb elemet.
		/// </summary>
		static void Sort(Stack<string> s, Func<string, string, int> comparator)
		{
		}


		/// <summary>
		/// Kiveszi és eltávolítja a legnagyobb elemet.
		/// </summary>
		static void Sort(Queue<string> s, Func<string, string, int> comparator)
		{
		}

		static void Main(string[] args)
		{
			Stack<string> verem = new Stack<string>();
			verem.Push("vödör");
			verem.Push("Skywalker");
			verem.Push("Sigma male");
			verem.Push("hármas villamos");
			verem.Push("sztiktutíciós reakció");
			verem.Push("fototropizmus");


			Queue<string> sor = new Queue<string>();
			sor.Enqueue("tigmonasztia");
			sor.Enqueue("Farkas Péter");
			sor.Enqueue("Mert nem");
			sor.Enqueue("Ferencváros");
			sor.Enqueue("Újpest");
			sor.Enqueue("Tesztoszteron");
			sor.Enqueue("Napóleon");

			Console.WriteLine("-----------------");
			Console.WriteLine("A verem elemei:");
			Kiir(verem);
			//			Console.WriteLine("A sor elemei:");
			//			Kiir(sor);

			Console.WriteLine(Element_at(verem, 0));
			Console.WriteLine(Element_at(verem, 1));
			Console.WriteLine(Element_at(verem, 2));
			Console.WriteLine(Element_at(verem, 3));
			Console.WriteLine(Element_at(verem, 4));
			Console.WriteLine(Element_at(verem, 5));

			Console.WriteLine("-----------------");
			Console.WriteLine("A sor elemei:");
			Kiir(sor);
            Console.WriteLine(Element_at(sor, 2));
			Kiir(sor);

		}
	}
}
