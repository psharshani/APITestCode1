using APITest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APIUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateNewUserTest()
        {
            //calling the class from 
            string jsonString = @"{ ""confirmPassword"": ""Newuser3@123"",
                                  ""firstName"": ""new3"",
                                    ""lastName"": ""user3"",
                                        ""password"": ""Newuser3@123"",
                                        ""username"": ""New3"" }";

            
            //var restUrl = restApi.setUrl("https://k51qryqov3.execute-api.ap-southeast-2.amazonaws.com/prod/users");
            //var restRequest = restApi.CreatePostRequest(jsonString);
            //var response = restApi.GetResponse(restUrl, restRequest);
            var api = new Demo();
            //create object of the class
            var response = api.CreateNewUser(jsonString);
           
            Assert.AreEqual("New3",response.username);
            Assert.AreEqual("user3",response.lastname);

        }
    }
}
