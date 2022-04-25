namespace lab3_4 {
	public class SymString {
		private string symbols = "";

		public string Symbols { get => symbols; set => symbols = value; }

		public SymString() => this.Symbols = "";
		public SymString(string symbols) => this.Symbols = symbols;
		public SymString(SymString s) => this.Symbols = s.Symbols;

		public static SymString operator -(SymString s1, SymString s2)
			=> new SymString(s1.Symbols.Replace(s2.Symbols, ""));
	}
}