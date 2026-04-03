using STP_2._1._4;

namespace TESTIROVANIELAB2
{
    public class UnitTest1
    {
        [Fact]
        public void test1()
        {
            Room room = new Room();
            room.Init(50.5, 5);
            Assert.NotNull(room);
        }

        [Fact]
        public void test2()
        {
            Room room = new Room();
            room.Init(100, 2);
            double result = room.SizeForOnePeople();
            Assert.Equal(50, result);
        }

        [Fact]
        public void test3()
        {
            Room room = new Room();
            room.area = 100;
            room.people = 5;
            room.Init(-50, 10);
            Assert.Equal(100, room.area);
            Assert.Equal(5, room.people);
        }

        [Fact]
        public void test4()
        {
            Room room = new Room();
            room.Init(42, 1);
            Assert.Equal(42, room.GetArea());
        }

        [Fact]
        public void test5()
        {
            ProRoom proroom = new ProRoom();
            proroom.Init(50, 2, 10.5);
            Assert.Equal(10.5, proroom.additionalArea);
        }

        [Fact]
        public void test6()
        {
            ProRoom proroom = new ProRoom();
            proroom.Init(60, 2, 0);
            Assert.Equal(30, proroom.SizeForOnePeople());
        }

        [Fact]
        public void test7()
        {
            ProRoom proroom = new ProRoom();
            proroom.Init(10, 10, 10);
            Assert.Equal(10, proroom.GetPeople());
        }

        [Fact]
        public void test8()
        {
            RoomAdapter adapter = new RoomAdapter();
            ProRoom proroom = new ProRoom();
            proroom.Init(40, 2, 10);
            double result = adapter.Calc(proroom);
            Assert.NotNull(result);
        }

        [Fact]
        public void test9()
        {
            RoomAdapter adapter = new RoomAdapter();
            ProRoom proroom = new ProRoom();
            proroom.area = 100;
            proroom.people = 5;
            proroom.additionalArea = 10;
            proroom.Init(-50, 10, -20);
            Assert.Equal(100, proroom.area);
            Assert.Equal(5, proroom.people);
            Assert.Equal(10, proroom.additionalArea);
        }

        [Fact]
        public void test10()
        {
            RoomAdapter adapter = new RoomAdapter();
            ProRoom proroom = new ProRoom();
            proroom.Init(100, 0, 50);
            double result = adapter.Calc(proroom);
            Assert.Equal(0, result);
        }
    }
}