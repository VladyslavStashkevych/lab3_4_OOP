namespace lab3_4 {
	public class HexString : SymString {
		public HexString() : base() { }
		public HexString(string s) : base(s) { }
		public HexString(HexString h) : base(h) { }

		public static int CharToInt(char c) {
			if (char.IsDigit(c))
				return Int32.Parse(c.ToString());
			else
				return c switch {
					'A' => 10,
					'B' => 11,
					'C' => 12,
					'D' => 13,
					'E' => 14,
					'F' => 15,
					'G' => 16,
					_ => 0,
				};
		}
		public static char IntToChar(int i) {
			if (i < 10)
				return char.Parse(i.ToString());
			else
				return i switch {
					10 => 'A',
					11 => 'B',
					12 => 'C',
					13 => 'D',
					14 => 'E',
					15 => 'F',
					16 => 'G',
					_ => '0',
				};
		}
		public int HexToDecimal() {
			int result = 0;
			char[] ch = this.Symbols.ToUpper().ToCharArray();
			for (int i = 0; i < this.Symbols.Length; i++) {
				result += CharToInt(ch[ch.Length - 1 - i]) * (int)Math.Pow(16, i);
			}
			return result;
		}
		public static HexString DecimalToHex(int s) {
			List<char> ch = new List<char>();
			while (s > 0) {
				ch.Add(IntToChar(s % 16));
				s /= 16;
			}
			ch.Reverse();
			if (ch.Count == 0) 
				ch.Add('0');
			return new HexString(new string(ch.ToArray()));
		}
		public static string DecimalToOct(int s) {
			List<char> ch = new List<char>();
			while (s > 0) {
				ch.Add(IntToChar(s % 8));
				s /= 8;
			}
			ch.Reverse();
			return new string(ch.ToArray());
		}

		public static HexString operator -(HexString h1, HexString h2) {
			int res = h1.HexToDecimal() - h2.HexToDecimal();
			return DecimalToHex(res);
		}
		public void ShowOct() {
			Console.WriteLine(DecimalToOct(this.HexToDecimal()));
		}
	}
}
