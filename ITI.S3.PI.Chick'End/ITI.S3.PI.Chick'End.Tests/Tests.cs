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
            Game g = new Game("Map1.bin");

            Assert.IsNotNull( g.Map );
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
            Map m = new Map();
            m.CreateHen( 7, 7, m );

            Assert.IsNotNull( m.Square[7, 7].Tower );
        }
    }
}
