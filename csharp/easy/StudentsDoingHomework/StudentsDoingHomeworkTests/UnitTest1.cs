using System;
using Xunit;
using static StudentsDoingHomework.Program;

namespace StudentsDoingHomeworkTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 3, 2, 7 }, 4, 1)]
        [InlineData(new int[] { 4 }, new int[] { 4 }, 5, 0)]
        [InlineData(new int[] { 1, 1, 1, 1 }, new int[] { 1, 3, 2, 4 }, 7, 0)]
        [InlineData(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10 }, 5, 5)]
        public void CanReturnCorrectNumberOfStudents(int[] startTime, int[] endTime, int queryTime, int answer)
        {
            // arrange & act
            int students = BusyStudent(startTime, endTime, queryTime);

            // assert
            Assert.Equal(answer, students);
        }
    }
}