using Essentials.Types;
using System;
using System.Collections.Generic;
using Xunit;

namespace Types.Tests
{
    public class DoubleTest
    {
        public static IEnumerable<object[]> Get_ToDouble_Data_Passing()
        {
            yield return new object[] { "1.234" };
            yield return new object[] { "1122.334455" };
        }

        [Theory]
        [MemberData(nameof(Get_ToDouble_Data_Passing))]
        public void ToDouble_Passing(string text)
        {
            double? parse = text.ToDouble();
            Assert.NotNull(parse);
            Assert.Equal(double.Parse(text), parse);
        }

        public static IEnumerable<object[]> Get_ToDouble_Data_Failing()
        {
            // Can't convert empty string into a double
            yield return new object[] { string.Empty };
            // Can't convert string containing letters into a double
            yield return new object[] { "l3.3t" };
            // Can't convert letters into a double
            yield return new object[] { "This. is not a number" };
            // Can't convert null into a double
            yield return new object[] { null };
        }

        [Theory]
        [MemberData(nameof(Get_ToDouble_Data_Failing))]
        public void ToDouble_Failing(string text)
        {
            Assert.Throws<FormatException>(() => text.ToDouble());
        }
    }
}
