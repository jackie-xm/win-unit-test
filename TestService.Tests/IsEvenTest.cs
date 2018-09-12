using Microsoft.VisualStudio.TestTools.UnitTesting;  

using Test.Services; 

namespace Test.UnitTests.Services { 

    [TestClass] 

    public class  TestService_IsEven { 

        private readonly  TestService _testService; 

        public TestService_IsEven() { 

                _testService = new  TestService(); 

            } 

            [TestMethod] 

        public void  ReturnIsEven() { 

            var result = _testService.IsEven(2); 

            Assert.IsTrue(result, "2 is even");  

        } 

    } 

}