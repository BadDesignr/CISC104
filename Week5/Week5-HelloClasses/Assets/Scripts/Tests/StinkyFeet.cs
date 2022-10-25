using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class StinkyFeet
{
    Cube myCube = new Cube();
    // A Test behaves as an ordinary method
    [Test]
    public void StinkyFeetSimplePasses()
    {
        // Use the Assert class to test conditions
        
    }

    [Test]
    public void CubeTest()
    {
        Assert.AreEqual(0, myCube.GetLength());
        Assert.AreEqual(0, myCube.GetHeight());
        Assert.AreEqual(0, myCube.GetWidth());
        Assert.AreEqual(0, myCube.GetEdgeLength());
        Assert.AreEqual(0, myCube.GetVolume());
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator StinkyFeetWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
