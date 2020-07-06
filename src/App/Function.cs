using System;
using System.Diagnostics;
using Amazon.Lambda.Core;
using Microsoft.Net.Http.Headers;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.LambdaJsonSerializer))]

namespace App
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void FunctionHandler(string input, ILambdaContext context)
        {
            var testCookieString = "key=value";
            if (CookieHeaderValue.TryParse(testCookieString, out var cookie))
            {
                Debugger.Log(1, "Function", $"Successfully parsed cookie: {cookie}");
            }
            else
            {
                Debugger.Log(1, "Function", $"Unable to parse cookie");
            }
        }
    }
}
