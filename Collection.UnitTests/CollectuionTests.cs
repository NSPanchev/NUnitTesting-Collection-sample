
using Collections;

namespace Collection.UnitTests
{
    public class CollectuionTests
    {

        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            var coll = new Collection<int>();

            Assert.AreEqual(coll.ToString(), "[]");

        }

        [Test]
        public void Test_Collection_ConstructorsSingleItem()
        {
            var coll = new Collection<int>(5);
            Assert.AreEqual(coll.ToString(), "[5]");
        }

        [Test]
        public void Test_Collection_ConstructorsMultipleItems()
        {
            var coll = new Collection<int>(6, 7);
            Assert.AreEqual(coll.ToString(), "[6, 7]");
        }

        [Test]
        public void Test_Collection_Add()
        {
            var coll = new Collection<int>(1, 2);
            coll.Add(3);
            Assert.AreEqual(coll.ToString(), "[1, 2, 3]");
        }

        [Test]
        public void Test_Collection_AddWithGrow()
        {
            var nums = new Collection<int>();
            int oldCapacity = nums.Capacity;
            var newNums = Enumerable.Range(1000, 2000).ToArray();
            nums.AddRange(newNums);
            string expextedNums = "[" + string.Join(", ", newNums) + "]";
            Assert.That(nums.ToString(), Is.EqualTo(expextedNums));
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(oldCapacity));
            Assert.That(nums.Capacity, Is.GreaterThanOrEqualTo(nums.Count));
        }
        [Test]
        public void Test_Collection_AddRange()
        {

        }

        [Test]
        public void Test_Collection_GetByIndexNums()
        {
            var collection = new Collection<int>(5, 6, 7);
            var item = collection[1];
            Assert.That(item.ToString(), Is.EqualTo("6"));
        }

        [Test]
        public void Test_Collection_GetByIndexNames()
        {
            var names = new Collection<String>("Nedko", "Dragomir", "Ivan");
            var itemFirst = names[0];
            var itemSecond = names[1];
            var itemThird = names[2];

            Assert.That(itemFirst.ToString(), Is.EqualTo("Nedko"));
            Assert.That(itemSecond.ToString(), Is.EqualTo("Dragomir"));
            Assert.That(itemThird.ToString(), Is.EqualTo("Ivan"));
        }


        [Test]
        public void Test_Collection_GetByInvalidIndex()
        {
            var coll = new Collection<String>("Georgi", "Nikolay");
            Assert.That(() => { var item = coll[2]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var item = coll[-1]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var item = coll[20]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());

        }

        [Test]
        public void Test_Collection_SetByIndex()
        {
            var collection = new Collection<int>(5, 6, 7);
            collection[1] = 888;
            Assert.That(collection.ToString(), Is.EqualTo("[5, 888, 7]"));
        }

        [Test]
        public void Test_Collection_SetByInvalidIndexNumbers()
        {
            var coll = new Collection<String>("1", "2");
            Assert.That(() => { var item = coll[2]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var item = coll[-1]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var item = coll[20]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());

        }

        [Test]
        public void Test_Collection_SetByInvalidIndexNames()
        {
            var coll = new Collection<String>("Georgi", "Nikolay");
            Assert.That(() => { var item = coll[2]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var item = coll[-1]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var item = coll[20]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
        }
        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            var coll = new Collection<int>(6, 7);
            Assert.AreEqual(coll.Count, 2, "Check for count");
            Assert.That(coll.Capacity, Is.GreaterThanOrEqualTo(coll.Count));
        }
        [Test]
        public void Test_Collection_InsertAtStart() {
            var collection = new Collection<int>(6, 7, 8, 9, 10);
            collection.InsertAt(0, 1);
            Assert.That(collection.ToString(), Is.EqualTo("[1, 6, 7, 8, 9, 10]"));

        }
        [Test]
        public void Test_Collection_InsertAtEnd() {
            var collection = new Collection<int>(6, 7, 8, 9, 10);
            collection.InsertAt(4, 1);
            Assert.That(collection.ToString(), Is.EqualTo("[6, 7, 8, 9, 1, 10]"));
        }

        [Test]
        public void Test_Collection_InsertAtMiddle() {
            var collection = new Collection<int>(6, 7, 8, 9, 10);
            collection.InsertAt(2, 1);
            Assert.That(collection.ToString(), Is.EqualTo("[6, 7, 1, 8, 9, 10]"));

        }

        [Test]
        public void Test_Collection_InsertAtWithGrow() {

        }

        [Test]
        public void Test_Collection_InsertAtInvalidIndex() {
        
        }

        [Test]
        public void Test_Collection_ExchangeMiddle() {

            var collection = new Collection<int>(5, 6, 7, 8);
            collection.Exchange(1,2);
            Assert.That(collection.ToString(), Is.EqualTo("[5, 7, 6, 8]"));
        }

        [Test]
        public void Test_Collection_ExchangeFirstLast() {
            var collection = new Collection<int>(5, 6, 7, 8);
            collection.Exchange(0, 3);
            Assert.That(collection.ToString(), Is.EqualTo("[8, 6, 7, 5]"));
        }

        [Test]
        public void Test_Collection_ExchangeInvalidIndexes() {
            var collection = new Collection<int>(5, 6, 7, 8);
            collection.Exchange(3, 4);
            Assert.That(() => { var item = collection[4]; },
                  Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void Test_Collection_RemoveAtStart() {
            var collection = new Collection<int>(5, 6, 7, 8);
            collection.RemoveAt(0);
            Assert.That(collection.ToString(), Is.EqualTo("[6, 7, 8]"));
        }

        [Test]
        public void Test_Collection_RemoveAtEnd() {
            var collection = new Collection<int>(5, 6, 7, 8);
            collection.RemoveAt(3);
            Assert.That(collection.ToString(), Is.EqualTo("[5, 6, 7]"));

        }

        [Test]
        public void Test_Collection_RemoveAtMiddle() {
            var collection = new Collection<int>(5, 6, 7, 8, 9);
            collection.RemoveAt(2);
            Assert.That(collection.ToString(), Is.EqualTo("[5, 6, 8, 9]"));

        }

        [Test]
        public void Test_Collection_RemoveAtInvalidIndex() {
            var collection = new Collection<int>(5, 6, 7, 8);
            collection.RemoveAt(6);
            Assert.That(() => { var item = collection[6]; },
                  Throws.InstanceOf<ArgumentOutOfRangeException>());

        }

        [Test]
        public void Test_Collection_RemoveAll() {
         

        }

        [Test]
        public void Test_Collection_Clear() {

            var collection = new Collection<int>(1, 2, 3, 4);
            collection.Clear();
           

        }

        [Test]
        public void Test_Collection_ToStringEmpty() {
            var coll = new Collection<string>();

            Assert.AreEqual(coll.ToString(), "[]");
        }

        [Test]
        public void Test_Collection_ToStringSingle() {
            var name= new Collection<string>("Nedko");
            Assert.That(name, Is.EqualTo(name));
        }
      

        [Test]
        public void Test_Collection_ToStringMultiple() {
            var names = new Collection<string>("Petar", "Vesko");
            Assert.That(names, Is.EqualTo(names));

        }

        [Test]
        public void Test_Collection_ToStringNestedCollections() { 
            var names = new Collection<string>("Nedko", "Maria", "Monika", "Drago");
            var age = new Collection<int>(34, 35, 30, 33);
            var date = new Collection<DateTime>();
            var nested = new Collection<object>(names, age, date);
            string nestedToString = nested.ToString();  
            Assert.That(nestedToString, 
                Is.EqualTo("[[Nedko, Maria, Monika, Drago], [34, 35, 30, 33], []]"));
        }

        [Test]
        public void Test_Collection_1MillionItems() {
            const int itemsCount = 1000000;
            var nums = new Collection<int>();
            nums.AddRange(Enumerable.Range(1, itemsCount).ToArray());
            Assert.That(nums.Count == itemsCount);
            Assert.That(nums.Capacity >= nums.Count);
            for (int i = itemsCount - 1; i >= 0; i--)
                nums.RemoveAt(i);
            Assert.That(nums.ToString() == "[]");
            Assert.That(nums.Capacity >= nums.Count);

        }
    }
}