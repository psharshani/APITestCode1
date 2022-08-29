using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest
{
   

    public class Demo
    {
        private Helper helper;

        public Demo()
        {
            helper = new Helper();
        }

       
        public CreateUserRes CreateNewUser(string jsonString)
        {

            var client = helper.setUrl("");
            var request = helper.CreatePostRequest(jsonString);
            var response = helper.GetResponse(client, request);
            var createuser = helper.GetContent<CreateUserRes>(response);
            return createuser;


        }
    }
}
