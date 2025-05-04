using IV.RSG.Promises.Runtime;

namespace IV.RSG.Promises.Tests;

public class PromiseTests
{
    [Test]
    public void Resolve()
    {
        var promise = new Promise<int>();
        var result = 0;

        promise
            .Then(value => result = value)
            .Catch(e => Assert.Fail("Promise should not be rejected."))
            .Done();

        promise.Resolve(42);

        Assert.That(result, Is.EqualTo(42), "Promise should resolve with the correct value.");
    }
}