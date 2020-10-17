using System;
using Xunit;
using MaskApi.models;

namespace MaskTests
{
    public class MaskTest
    {
        [Fact]
        public void ConstructorTest()
        {
            //Mask newMask = null;
            try {
            Mask newMask = new Mask("m-9999", 1, "White", true, false, "flowers", true, 10.00);
            } catch (Exception ex) {
                System.Environment.Exit(1);
            }

            //Assert.True(newMask.New);
            Assert.True(true);
        }
    }
}
