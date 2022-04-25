using Xunit;
using lab3_4;

namespace lab3_4_Tests {
	public class ReturnValuesTest {
		[Theory]
		[InlineData("sdddf", "ddd")]
		[InlineData("acdc", "c")]
		public void SymString_Correct(string s1, string s2) {
			string result = s1.Replace(s2, "");
			SymString actual;
			SymString ss1 = new SymString(s1);
			SymString ss2 = new SymString(s2);

			actual = ss1 - ss2;

			Assert.Equal(result, actual.Symbols);
		}
	}
}