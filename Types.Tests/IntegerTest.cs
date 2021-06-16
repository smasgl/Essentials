using Essentials.Types;
using System;
using System.Collections.Generic;
using Xunit;

namespace Types.Tests
{
    public class IntegerTest
    {
        public static IEnumerable<object[]> Get_ToInt_Data_Passing()
        {
            yield return new object[] { "1234" };
            yield return new object[] { "1122334455" };
        }

        [Theory]
        [MemberData(nameof(Get_ToInt_Data_Passing))]
        public void ToInt_Passing(string text)
        {
            int? parse = text.ToInt();
            Assert.NotNull(parse);
            Assert.Equal(int.Parse(text), parse);
        }

        public static IEnumerable<object[]> Get_ToInt_Data_Failing()
        {
            // Can't convert empty string into a integer
            yield return new object[] { string.Empty };
            // Can't convert string containing letters into a integer
            yield return new object[] { "l33t" };
            // Can't convert letters into a integer
            yield return new object[] { "This is not a number" };
            // Can't convert too big numbers into a integer
            yield return new object[] { "112233445566778899" };
            // Can't convert null into a integer
            yield return new object[] { null };
        }

        [Theory]
        [MemberData(nameof(Get_ToInt_Data_Failing))]
        public void ToInt_Failing(string text)
        {
            Assert.Throws<FormatException>(() => text.ToInt());
        }

    }
}
