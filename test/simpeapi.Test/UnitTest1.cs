using System;
using Xunit;
using simpeapi.Controllers;

namespace simpeapi.Test
{
    public class UnitTest1
    {
        ValuesController vcn=new ValuesController();
        [Fact]
        public void GetreturnMyName(){
            var returnval= vcn.Get(1);
            Assert.Equal("les Jackson",returnval.Value);

        }
        [Fact]
        public void Test1()
        {

        }
    }
}
