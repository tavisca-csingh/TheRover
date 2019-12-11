using System;
using TheRover.Interfaces;
using Xunit;

namespace TheRover.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void WHEN_USER_GIVES_VALID_COMMAND_AND_DIRECTION()
        {
            PositionDetector positionDetector = new PositionDetector();
            Exception expectedExcetpion = null;
            string position = "0,0,N";
            string commands = "MMM";
    
            //WHEN
                var Expected = positionDetector.GetFinalPosition(position, commands);
            //then
            Assert.Equal(Expected,"0,3,N");
        }
        [Fact]
        public void WHEN_USER_GIVES_INVALID_COMMAND()
        {
            PositionDetector positionDetector = new PositionDetector();
            Exception expectedExcetpion = null;
            string position = "0,0,N";
            string commands = "dash1dhja";
            //WHEN
            var Expected = positionDetector.GetFinalPosition(position, commands);
            //then
            Assert.Equal(Expected,"0,0,N");
        }
        [Fact]
        public void WHEN_USER_GIVES_INVALID_POSITIONS()
        {
            //GIVEN
            PositionDetector positionDetector = new PositionDetector();
            Exception expectedExcetpion = null;
            string position = "a,h,k";
            string commands = "MMM";
            //WHEN
            try
            {
                var expected = positionDetector.GetFinalPosition(position, commands);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }
            //then
            Assert.NotNull(expectedExcetpion);
        }
        [Fact]
        public void WHEN_USER_GIVES_INVALID_COMMAND_AND_DIRECTION()
        {
            PositionDetector positionDetector = new PositionDetector();
            Exception expectedExcetpion = null;
            string position = "a,h,k";
            string commands = "MhgjM";
            //WHEN
            try
            {
                var expected = positionDetector.GetFinalPosition(position, commands);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }
            //then
            Assert.NotNull(expectedExcetpion);
        }
    }
}
