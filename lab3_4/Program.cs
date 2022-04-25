namespace lab3_4 {
	public static class Program {
		public static void Main(String[] args) {
			HexString h1 = new HexString("1F");
			Console.WriteLine($"1F in decimal: {h1.HexToDecimal()}");
			Console.WriteLine($"31 in hexadecimal: {HexString.DecimalToHex(h1.HexToDecimal()).Symbols}");
			Console.Write("1F in octal: ");
			h1.ShowOct();
			HexString h2 = new HexString(h1);
			HexString h3 = h2 - h1;
			Console.WriteLine($"1F - 1F = {h3.Symbols}");
		}
	}
}