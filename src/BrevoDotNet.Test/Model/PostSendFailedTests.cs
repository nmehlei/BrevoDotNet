/*
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using BrevoDotNet.Model;
using BrevoDotNet.Client;
using System.Reflection;

namespace BrevoDotNet.Test.Model
{
    /// <summary>
    ///  Class for testing PostSendFailed
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PostSendFailedTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PostSendFailed
        //private PostSendFailed instance;

        public PostSendFailedTests()
        {
            // TODO uncomment below to create an instance of PostSendFailed
            //instance = new PostSendFailed();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PostSendFailed
        /// </summary>
        [Fact]
        public void PostSendFailedInstanceTest()
        {
            // TODO uncomment below to test "IsType" PostSendFailed
            //Assert.IsType<PostSendFailed>(instance);
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

        /// <summary>
        /// Test the property 'UnexistingEmails'
        /// </summary>
        [Fact]
        public void UnexistingEmailsTest()
        {
            // TODO unit test for the property 'UnexistingEmails'
        }

        /// <summary>
        /// Test the property 'WithoutListEmails'
        /// </summary>
        [Fact]
        public void WithoutListEmailsTest()
        {
            // TODO unit test for the property 'WithoutListEmails'
        }

        /// <summary>
        /// Test the property 'BlackListedEmails'
        /// </summary>
        [Fact]
        public void BlackListedEmailsTest()
        {
            // TODO unit test for the property 'BlackListedEmails'
        }
    }
}
