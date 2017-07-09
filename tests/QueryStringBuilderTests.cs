using System;
using NUnit.Framework;

// Copyright (c) 2017 Cyotek Ltd.
// http://mantissharp.net/
// Licensed under the MIT License. See LICENSE.txt for the full text.

// If you use this control in your applications, attribution, donations or contributions are welcome.

namespace MantisSharp.Tests
{
  [TestFixture]
  public class QueryStringBuilderTests
  {
    #region  Tests

    [Test]
    public void Add_adds_key_with_integer_value_pair()
    {
      this.RunAddTest(target => target.Add("alpha", 10), "alpha=10");
    }

    [Test]
    public void Add_adds_key_with_string_value_pair()
    {
      this.RunAddTest(target => target.Add("alpha", "beta"), "alpha=beta");
    }

    [Test]
    public void Add_encodes_value()
    {
      this.RunAddTest(target => target.Add("alpha", "beta gamma delta"), "alpha=beta%20gamma%20delta");
    }

    [Test]
    public void Add_includes_pair_separators()
    {
      this.RunAddTest(target => target.Add("alpha", "beta"), target => target.Add("gamma", "delta"), "alpha=beta&gamma=delta");
    }

    [Test]
    public void ToString_returns_empty_string_for_empty_instance()
    {
      // arrange
      QueryStringBuilder target;
      string actual;

      target = new QueryStringBuilder();

      // act
      actual = target.ToString();

      // assert
      Assert.IsEmpty(actual);
    }

    #endregion

    #region Test Helpers

    private void RunAddTest(Action<QueryStringBuilder> test, string expected)
    {
      this.RunAddTest(null, test, expected);
    }

    private void RunAddTest(Action<QueryStringBuilder> setup, Action<QueryStringBuilder> test, string expected)
    {
      // arrange
      QueryStringBuilder target;
      string actual;

      target = new QueryStringBuilder();

      setup?.Invoke(target);

      // act
      test(target);

      // assert
      actual = target.ToString();
      Assert.AreEqual(expected, actual);
    }

    #endregion
  }
}
