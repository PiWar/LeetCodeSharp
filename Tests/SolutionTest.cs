namespace Tests;

using Solution;

[TestFixture]
public class SolutionTest
{
    [Test]
    public void TestQuality()
    {
        Assert.That(TaskSolution.GetAnswer(), Is.EqualTo(0));
    }
}