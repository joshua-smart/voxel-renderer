using NUnit.Framework;
using VoxelRenderer.Domain.Maths;

namespace Domain.UnitTests;

public class Vector3Tests {
    [SetUp]
    public void Setup() {

    }

    [Test]
    public void Add() {
        Vector3 a = new (1, 2, 3);
        Vector3 b = new (4, 3, 1);

        Vector3 sum = a + b;

        Assert.IsTrue(sum == new Vector3 (5, 5, 4));
    }
}
