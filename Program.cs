using System;

namespace Equalsand__
{
    class Program
    {
        static void Main(string[] args)
        {
            int ia = 1;
            int ib = 1;
            //值类型Equals和==都是比较对象的值
            Console.WriteLine(string.Format("int ==:{0}", ia == ib));//True
            Console.WriteLine(string.Format("int equals:{0}\r\n", ia.Equals(ib)));//True
            //字符串类型Equals和==都是比较对象的值
            string str1 = new string("1");
            string stra = str1;
            string strb = new string(new char[] { '1' });
            Console.WriteLine(string.Format("str1 == stra:{0}", str1 == stra));//True
            Console.WriteLine(string.Format("str1 == strb:{0}", str1 == strb));//True
            Console.WriteLine(string.Format("str1 Equals stra:{0}", str1.Equals(stra)));//True
            Console.WriteLine(string.Format("str1 Equals strb:{0}", str1.Equals(strb)));//True
            Console.WriteLine(string.Format("stra == strb:{0}", stra == strb));//True
            Console.WriteLine(string.Format("stra Equals strb:{0}\r\n", stra.Equals(strb)));//True
            //非字符串引用类型Equals和==都是比较对象的引用
            TestEntity testEntity = new TestEntity();
            testEntity.ia = 1;
            testEntity.stra = "1";
            TestEntity testEntity2 = testEntity;
            TestEntity testEntity3 = testEntity;
            Console.WriteLine(string.Format("testEntity == testEntity2:{0}", testEntity == testEntity2));//True
            Console.WriteLine(string.Format("testEntity == testEntity3:{0}", testEntity == testEntity3));//True
            Console.WriteLine(string.Format("testEntity Equals testEntity2:{0}", testEntity.Equals(testEntity2)));//True
            Console.WriteLine(string.Format("testEntity Equals testEntity3:{0}", testEntity.Equals(testEntity3)));//True
            Console.WriteLine(string.Format("testEntity2 == testEntity3:{0}", testEntity2 == testEntity3));//True
            Console.WriteLine(string.Format("testEntity2 Equals testEntity3:{0}\r\n", testEntity2.Equals(testEntity3)));//True
            TestEntity testEntity22 = new TestEntity();
            testEntity22 = testEntity;
            TestEntity testEntity33 = new TestEntity();
            testEntity33 = testEntity;
            Console.WriteLine(string.Format("testEntity == testEntity22:{0}", testEntity == testEntity22));//True
            Console.WriteLine(string.Format("testEntity == testEntity33:{0}", testEntity == testEntity33));//True
            Console.WriteLine(string.Format("testEntity Equals testEntity22:{0}", testEntity.Equals(testEntity22)));//True
            Console.WriteLine(string.Format("testEntity Equals testEntity3:{0}", testEntity.Equals(testEntity33)));//True
            Console.WriteLine(string.Format("testEntity22 == testEntity3:{0}", testEntity22 == testEntity33));//True
            Console.WriteLine(string.Format("testEntity22 Equals testEntity3:{0}\r\n", testEntity22.Equals(testEntity33)));//True
            TestEntity2 test = new TestEntity2(1, "1");
            TestEntity2 test2 = new TestEntity2(1, "1");
            Console.WriteLine(string.Format("test == test2:{0}", test == test2));//False
            Console.WriteLine(string.Format("test Equals test2:{0}\r\n", test.Equals(test2)));//False
            var testv = new TestEntity2(1, "1");
            var testv2 = new TestEntity2(1, "1");
            Console.WriteLine(string.Format("testv == testv2:{0}", testv == testv2));//False
            Console.WriteLine(string.Format("testv Equals testv2:{0}\r\n", testv.Equals(testv2)));//False
            //匿名类Equals笔记俩个对象的状态，对象值都相同则返回true;==比较对象的引用
            var testv3 = new { ia = 1, stra = "1" };
            var testv4 = new { ia = 1, stra = "1" };
            var testv5 = testv3;
            Console.WriteLine(string.Format("testv3 == testv4:{0}", testv3 == testv4));//False
            Console.WriteLine(string.Format("testv3 Equals testv4:{0}\r\n", testv3.Equals(testv4)));//True
            Console.WriteLine(string.Format("testv5 == testv3:{0}\r\n", testv5 == testv3));//True
            Console.ReadKey();
        }
    }

    class TestEntity
    {
        public int ia;
        public string stra;
    }

    class TestEntity2
    {
        public TestEntity2(int i, string str)
        {
            ia = i;
            stra = str;
        }
        public int ia { get; set; }
        public string stra { get; set; }
    }

}
