using Collections;

namespace Collection_Test
{
    public class CollectionTests
    {


        [Test]
        public void Test_Collection_EmptyConstructor()
        {

            var collection = new Collection<int>();

            Assert.AreEqual(collection.ToString(), "[]");

        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            var collection = new Collection<int>(5);
            var actual = collection.ToString();
            var expected = "[5]";
            Assert.AreEqual(actual, expected);

        }

        [Test]

        public void Test_Collection_ConstructorMultipleItems()
        {
            var collection = new Collection<int>(2, 6);
            Assert.AreEqual(collection.ToString(), "[2, 6]");
        }

        [Test]
        public void Test_Collection_Add()
        {
            var collection = new Collection<int>();
            collection.Add(1);
            Assert.That(collection.Count, Is.EqualTo(1));
            Assert.That(collection[0], Is.EqualTo(1));

        }

        [Test]

        public void Test_Collection_AddWithGrow()
        {

            var collection = new Collection<int>(new int[] { 1, 2, 3 });
            int expectedCount = 6;
            collection.Add(4);
            collection.Add(5);
            collection.Add(6);

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Test_Collection_AddRange()
        {
            var collection = new Collection<int>(new int[] { 1, 2, 3 });
            int expectedCount = 6;
            collection.AddRange(new int[] { 4, 5, 6 });

            Assert.That(collection.Count, Is.EqualTo(expectedCount));

        }

        [Test]
        public void Test_Collection_GetByIndex()
        {
            var collection = new Collection<int>(1, 2, 3);
            Assert.That(collection[0], Is.EqualTo(1));
            Assert.That(collection[1], Is.EqualTo(2));
            Assert.That(collection[2], Is.EqualTo(3));
        }
        [Test]
        public void Test_Collection_GetByInvalidIndex()
        {
            var collection = new Collection<int>(1, 2, 3);
            int invalidIndex = 4;

            Assert.That(() => { int item = collection[invalidIndex]; }, Throws.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void Test_Collection_ExchangeFirstLast()
        {
            var collection = new Collection<int>(1, 2, 3);
            int index1 = 0;
            int index2 = 2;
            int expectedCount = 3;
            collection.Exchange(index1, index2);
            Assert.AreEqual(collection.ToString(), "[3, 2, 1]");

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }
        [Test]
        public void Test_Collection_ExchangeFirstSecond()
        {
            var collection = new Collection<int>(1, 2, 3);
            int index1 = 0;
            int index2 = 1;
            int expectedCount = 3;
            collection.Exchange(index1, index2);
            Assert.AreEqual(collection.ToString(), "[2, 1, 3]");

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }
        [Test]
        public void Test_Collection_ExchangeInvalidIndex()
        {
            var collection = new Collection<int>(1, 2, 3);
            int expectedCount = 3;

            Assert.That(() => { collection.Exchange(4, 5); }, Throws.InstanceOf<ArgumentOutOfRangeException>());

            Assert.That(collection.Count, Is.EqualTo(expectedCount));

        }
        [Test]
        public void Test_Collection_InsertAtEnd()
        {
            var collection = new Collection<int>(1, 2, 3);
            int index1 = 3;
            int number = 4;
            int expectedCount = 4;
            collection.InsertAt(index1, number);

            Assert.AreEqual(collection.ToString(), "[1, 2, 3, 4]");

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }
        [Test]
        public void Test_Collection_InsertAtStart()
        {
            var collection = new Collection<int>(1, 2, 3);
            int index1 = 0;
            int number = 4;
            int expectedCount = 4;
            collection.InsertAt(index1, number);

            Assert.AreEqual(collection.ToString(), "[4, 1, 2, 3]");

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }
        [Test]
        public void Test_Collection_InsertAtMiddle()
        {
            var collection = new Collection<int>(1, 2, 3);
            int index1 = 1;
            int number = 4;
            int expectedCount = 4;
            collection.InsertAt(index1, number);

            Assert.AreEqual(collection.ToString(), "[1, 4, 2, 3]");

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }
        [Test]
        public void Test_Collection_InsertInvalIndex()
        {
            var collection = new Collection<int>(1, 2, 3);
            int expectedCount = 3;
            Assert.That(() => { collection.InsertAt(4, 5); }, Throws.InstanceOf<ArgumentOutOfRangeException>());

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }
        [Test]
        public void Test_Collection_InsertAtWithGrow()
        {
            var collection = new Collection<int>(1, 2, 3);
            int expectedCount = 6;
            int index4 = 4;
            int index3 = 3;
            int index5 = 5;
            int number1 = 4;
            int number2 = 5;
            int number3 = 6;

            collection.InsertAt(index3, number1);
            collection.InsertAt(index4, number2);
            collection.InsertAt(index5, number3);

            Assert.AreEqual(collection.ToString(), "[1, 2, 3, 4, 5, 6]");

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }
      
        [Test]
        public void Test_RemoveAll()
        {
            var collection = new Collection<int>(1, 2, 3);

            Assert.That(() => collection.RemoveAll(), Throws.TypeOf<NotImplementedException>());
           
        }

        [Test]
        public void Test_RemoveAtEnd()
        {
            var collection = new Collection<int>(1, 2, 3);
            int index = 2;
            collection.RemoveAt(index);
            int expectedCount = 2;
            Assert.That(collection.Count, Is.EqualTo(expectedCount));
            Assert.AreEqual(collection.ToString(), "[1, 2]");

        }
        [Test]
        public void Test_RemoveAtStart()
        {
            var collection = new Collection<int>(1, 2, 3);
            int index = 0;
            collection.RemoveAt(index);
            int expectedCount = 2;
            Assert.That(collection.Count, Is.EqualTo(expectedCount));
            Assert.AreEqual(collection.ToString(), "[2, 3]");

        }
        [Test]
        public void Test_RemoveAtMiddle()
        {
            var collection = new Collection<int>(1, 2, 3);
            int index = 1;
            collection.RemoveAt(index);
            int expectedCount = 2;
            Assert.That(collection.Count, Is.EqualTo(expectedCount));
            Assert.AreEqual(collection.ToString(), "[1, 3]");

        }
        [Test]
        public void Test_RemoveAtInvalidIndex()
        {
            var collection = new Collection<int>(1, 2, 3);
          
            int expectedCount = 3;
            Assert.That(collection.Count, Is.EqualTo(expectedCount));
            Assert.That(() => collection.RemoveAt(4), Throws.TypeOf<ArgumentOutOfRangeException>());

        }
        [Test]
        public void Test_SetByIndex()
        {
            var collection = new Collection<int>(1, 2, 3);
            int index = 0;
            int num = 2;
            collection.SetBy(index);
            var expcted = (index = num);
            int expectedCount = 3;
            Assert.That(collection.Count, Is.EqualTo(expectedCount));
            Assert.AreEqual(collection.ToString(), "2, 1, 3");

        }




    }

}