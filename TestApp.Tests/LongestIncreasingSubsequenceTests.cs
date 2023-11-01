using NUnit.Framework;
using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        //Arrange
        int[]? arr = null;
        //Act & Assert
        Assert.That(()=> LongestIncreasingSubsequence.GetLis(arr), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] arr = { };
        //Act 
        string output = LongestIncreasingSubsequence.GetLis(arr);
        // Assert
        Assert.IsEmpty(output);
    }
        [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        int[] arr = {1};
        //Act 
        string output = LongestIncreasingSubsequence.GetLis(arr);
        // Assert
        Assert.That(output, Is.EqualTo("1"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        int[] arr = { 12, 3, 2, 4 };
        //Act 
        string output = LongestIncreasingSubsequence.GetLis(arr);
        // Assert
        Assert.That(output, Is.EqualTo("3 4"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        int[] arr = { 1, 2, 3, 4};
        //Act 
        string output = LongestIncreasingSubsequence.GetLis(arr);
        // Assert
        Assert.That(output, Is.EqualTo("1 2 3 4"));
    }
}
