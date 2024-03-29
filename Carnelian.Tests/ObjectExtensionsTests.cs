﻿using NUnit.Framework;

namespace Carnelian.Tests
{
    namespace ObjectExtensionsTests
    {
        [TestFixture]
        public class TryMethod
        {
            [Test]
            public void it_calls_through_when_the_object_is_not_null()
            {
                var value = "Hello World";
                Assert.AreEqual("HELLO WORLD", value.Try(x => x.ToUpper()));
            }

            [Test]
            public void it_returns_null_when_the_result_is_a_class_and_the_object_is_null()
            {
                string value = null;
                Assert.AreEqual(null, value.Try(x => x.ToUpper()));
            }

            [Test]
            public void it_returns_default_when_the_result_is_a_value_and_the_object_is_null()
            {
                string value = null;
                Assert.AreEqual(0, value.Try(x => x.Length));
            }

            [Test]
            public void it_returns_null_with_nullable_values()
            {
                int? value = null;
                Assert.AreEqual(null, value.Try(x => x.ToString()));
            }

            [Test]
            public void it_calls_through_for_nullable_values()
            {
                int? value = 123;
                Assert.AreEqual("123", value.Try(x => x.ToString()));
            }
        }

        [TestFixture]
        public class IsNullMethod
        {
            [Test]
            public void it_returns_true_if_null()
            {
                string value = null;
                Assert.IsTrue(value.IsNull());
            }

            [Test]
            public void it_returns_false_if_not_null()
            {
                string value = "";
                Assert.IsFalse(value.IsNull());
            }

            [Test]
            public void it_returns_true_if_null_with_nullable_types()
            {
                int? value = null;
                Assert.IsTrue(value.IsNull());
            }

            [Test]
            public void it_returns_false_if_not_null_with_nullable_types()
            {
                int? value = 123;
                Assert.IsFalse(value.IsNull());
            }
        }

        [TestFixture]
        public class IsPresentMethod
        {
            [Test]
            public void it_returns_false_if_null()
            {
                string value = null;
                Assert.IsFalse(value.IsPresent());
            }

            [Test]
            public void it_returns_true_if_not_null()
            {
                string value = "";
                Assert.IsTrue(value.IsPresent());
            }

            [Test]
            public void it_returns_false_if_null_with_nullable_types()
            {
                int? value = null;
                Assert.IsFalse(value.IsPresent());
            }

            [Test]
            public void it_returns_true_if_not_null_with_nullable_types()
            {
                int? value = 123;
                Assert.IsTrue(value.IsPresent());
            }
        }

        [TestFixture]
        public class TapMethod
        {
            [Test]
            public void it_calls_the_specified_block()
            {
                string blockValue = null;
                "hello world".Tap(x => blockValue = x);
                Assert.AreEqual("hello world", blockValue);
            }

            [Test]
            public void it_returns_the_original_object()
            {
                string value = "hello world";
                Assert.AreSame(value, value.Tap(x => {}));
            }
        }
    }
}
