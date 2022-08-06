using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld {
	public class Program {
		static int luasPersegiPanjang(int panjang, int lebar) {
			return panjang * lebar;
		}

		public static void Main(string[] args) {
			Console.WriteLine("Hello, World!");
			
			String nama = "mamat nata";
			int selingkuhan = 0;
			
			if (selingkuhan <= 0) Console.WriteLine("Aman");
			else if (selingkuhan == 1) Console.WriteLine("Playboy");
			else Console.WriteLine("Gak ketolong lagi dah ni anak");
			
			for (int i = 0; i < 5; i++) {
				Console.WriteLine("perulangan ke-" + i);
			} 
			Console.WriteLine(luasPersegiPanjang(5, 2));
		}
	}
}