using NUnit.Framework;

namespace MantisSharp.Tests
{
  [TestFixture]
  public class MantisClientTests
  {
    #region  Tests

    [Test]
    public void Constructor_appends_final_slash()
    {
      // arrange
      MantisClient target;
      string expected;
      string actual;

      expected = "alpha/";

      // act
      target = new MantisClient("alpha", null);

      // assert
      actual = target.BaseUri;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Constructor_sets_api_key()
    {
      // arrange
      MantisClient target;
      string expected;
      string actual;

      expected = "alpha";

      // act
      target = new MantisClient((string)null, expected);

      // assert
      actual = target.ApiKey;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Constructor_sets_base_uri()
    {
      // arrange
      MantisClient target;
      string expected;
      string actual;

      expected = "http://alpha.com/";

      // act
      target = new MantisClient(expected, null);

      // assert
      actual = target.BaseUri;
      Assert.AreEqual(expected, actual);
    }

    #endregion
  }
}
