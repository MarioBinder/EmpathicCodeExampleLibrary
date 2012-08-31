using DateTimeExamples.Extensions;
using DateTimeExamples.Types;
using DateTimeExamples.Types.Months;
using FluentAssertions;
using NUnit.Framework;

namespace DateTimeExamples.Tests
{
    public class Cases
    {
        [Test]
        public void Should_Return_Tuesday()
        {
            (23.January(1973)).DayName.Should().Be("Tuesday");
        }

        [Test]
        public void DaysOf_January_Should_Be_31()
        {
            DaysInMonth.Of(January.In(1973)).Should().Be(31);
        }

        [Test]
        public void DaysOf_February_In_1976_Should_Be_29()
        {
            DaysInMonth.Of(February.In(1976)).Should().Be(29);
        }

        [Test]
        public void DaysOf_February_In_1973_Should_Be_28()
        {
            DaysInMonth.Of(February.In(1973)).Should().Be(28);
        }



    }
}
