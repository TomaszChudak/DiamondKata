using System.Collections;
using Xunit;

namespace DiamondKata.Tests
{
    public class DiamondStringCreatorTests
    {
        [Theory]
        [ClassData(typeof(DiamondExamples))]
        public void Create_ReturnsExpectedResult(char inputCharacter, string expectedOutput)
        {
            Assert.Equal(expectedOutput, DiamondStringCreator.Create(inputCharacter));
        }

        public class DiamondExamples : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 'A', "A" };
                yield return new object[] { 'B', 
@" A 
B B
 A " };
                yield return new object[] { 'E', 
@"    A    
   B B   
  C   C  
 D     D 
E       E
 D     D 
  C   C  
   B B   
    A    "};
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}