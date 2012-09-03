using System;
using DateTimeExamples.Types;
using DateTimeExamples.Types.Days;
using DateTimeExamples.Types.Days.Extensions;
using DateTimeExamples.Types.Months;
using DateTimeExamples.Types.Months.Extensions;
using DateTimeExamples.Types.Week;
using FluentAssertions;
using NUnit.Framework;

namespace DateTimeExamples.Tests
{
    public class Cases
    {
        [Test]
        public void Should_Be_January()
        {
            23.January(1973)
                .Should().BeOfType<January>();
        }

        [Test]
        public void Should_Be_Tuesday()
        {
            23.January(1973).DayName
                .Should().Be("Tuesday");
        }

        [Test]
        public void Days_Of_January_Should_Be_31()
        {
            DaysInMonth.Of(January.In(1973))
                .Should().Be(31);
        }

        [Test]
        public void Days_Of_February_In_1976_Should_Be_29()
        {
            DaysInMonth.Of(February.In(1976))
                .Should().Be(29);
        }

        [Test]
        public void Days_Of_February_In_1973_Should_Be_28()
        {
            DaysInMonth.Of(February.In(1973))
                .Should().Be(28);
        }

        [Test]
        public void Possible_WeekDay_Cases()
        {
            // Make.An.Appointment(Monday.This().Week());

            Monday.ThisWeek()
                .Should().Be(new DateTime(2012, 09, 03));

            Tuesday.NextWeek()
                .Should().Be(new DateTime(2012, 09, 11));
            

            Monday.NextWeek()
                .Should().Be(new DateTime(2012, 09, 10));

            Tuesday.ThisWeek()
                .Should().Be(new DateTime(2012, 09, 04));
            

            Monday.InTwoWeeks()
                .Should().Be(new DateTime(2012, 09, 17));
            
            Tuesday.InTwoWeeks()
                .Should().Be(new DateTime(2012, 09, 18));


        }

        public void Should_Return_Last_Day_Of_Januar()
        {
            //var sut = Last.Day.Of.January.In(2012);

        }


    }
}
