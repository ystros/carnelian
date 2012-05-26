using NUnit.Framework;

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
        }
    }
}
