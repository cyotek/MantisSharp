using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;

namespace MantisSharp.Tests
{
  [TestFixture]
  public class LookupCacheTests
  {
    #region  Tests

    [Test]
    public void Get_constructs_object_from_properties_dictionary()
    {
      // arrange
      LookupCache<AccessLevel> target;
      Dictionary<string, object> props;
      AccessLevel expected;
      AccessLevel actual;

      target = new LookupCache<AccessLevel>(null);

      props = new Dictionary<string, object>
              {
                {
                  "id", 90
                },
                {
                  "name", "alpha"
                },
                {
                  "label", "beta"
                }
              };

      expected = new AccessLevel
                 {
                   Id = 90,
                   Name = "alpha",
                   Label = "beta"
                 };

      // act
      actual = target.Get(props);

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Get_returns_existing_item_from_id()
    {
      // arrange
      LookupCache<AccessLevel> target;
      AccessLevel expected;
      AccessLevel actual;
      Dictionary<int, AccessLevel> dict;

      target = new LookupCache<AccessLevel>(null);

      dict = (Dictionary<int, AccessLevel>)target.GetType().GetField("_cache", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(target);

      expected = new AccessLevel
                 {
                   Id = 90,
                   Name = "alpha",
                   Label = "beta"
                 };

      dict.Add(expected.Id, expected);

      // act
      actual = target.Get(expected.Id);

      // assert
      Assert.AreSame(expected, actual);
    }

    [Test]
    public void Get_returns_same_object_for_same_id()
    {
      // arrange
      LookupCache<AccessLevel> target;
      Dictionary<string, object> props;
      AccessLevel expected;
      AccessLevel actual;

      target = new LookupCache<AccessLevel>(null);

      props = new Dictionary<string, object>
              {
                {
                  "id", 90
                },
                {
                  "name", "alpha"
                },
                {
                  "label", "beta"
                }
              };

      expected = target.Get(props);

      // act
      actual = target.Get(expected.Id);

      // assert
      Assert.AreSame(expected, actual);
    }

    #endregion
  }
}
