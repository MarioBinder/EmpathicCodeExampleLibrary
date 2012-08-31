using DateTimeExamples.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace DateTimeExamples.Tests
{
    public class Cases
    {
        [Test]
        public void Should_Return_Tuesday()
        {
            var sut = (23.January(1973)).DayName;
            sut.Should().Be("Tuesday");
        }

        [Test]
        public void January_Have_31_Days()
        {
            var sut = (23.January(1973));
            sut.DaysInMonth.Should().Be(31);
        }




    }
}
