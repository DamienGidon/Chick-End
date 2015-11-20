using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ITI.S3.PI.Chick_End.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Properties_of_class_Game_work_correcty()
        {
            Game g = new Game();

            Assert.IsNotNull( g.Map );
            Assert.IsNotNull( g.Stopwatch );
        }

        [Test]
        public void Map_is_created_correctly()
        {
            Map m = new Map();

            //Assert.AreEqual("grass", )
        }

        [Test]
        public void Create_new_hen()
        {
            Hen h = new Hen();

            Assert.IsNotNull(h);
        }
    }
}
