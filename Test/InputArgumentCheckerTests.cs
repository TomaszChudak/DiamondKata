using System.Collections;
using Xunit;

namespace DiamondKata.Tests
{
    public class InputArgumentCheckerTests
    {
        [Theory]
        [MemberData(nameof(WrongInputArguments))]
        public void CheckIfSingleLetter_WithWrongInput_ReturnsFalse(string[] args)
        {
            Assert.False(InputArgumentChecker.CheckIfSingleLetter(args));
        }

        public static IEnumerable<object[]> WrongInputArguments =>
            new List<object[]>
            {
                new object[] { new string[] { } },
                new object[] { new string[] { null } },
                new object[] { new string[] { string.Empty } },
                new object[] { new string[] { "1" } },
                new object[] { new string[] { "AB" } },
                new object[] { new string[] { "*" } },
                new object[] { new string[] { "A", "B" } },
            };

        [Theory]
        [ClassData(typeof(RightInputArguments))]
        public void CheckIfSingleLetter_WithRightInput_ReturnsTrue(string[] args)
        {
            Assert.True(InputArgumentChecker.CheckIfSingleLetter(args));
        }

        public class RightInputArguments : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                for (var c = 'A'; c <= 'Z'; c++)
                {
                    yield return new object[] { new string[] { c.ToString() } };
                }
                for (var c = 'a'; c <= 'z'; c++)
                {
                    yield return new object[] { new string[] { c.ToString() } };
                }
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}