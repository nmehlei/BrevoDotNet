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
    ///  Class for testing GetAttributesAttributesInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetAttributesAttributesInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetAttributesAttributesInner
        //private GetAttributesAttributesInner instance;

        public GetAttributesAttributesInnerTests()
        {
            // TODO uncomment below to create an instance of GetAttributesAttributesInner
            //instance = new GetAttributesAttributesInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetAttributesAttributesInner
        /// </summary>
        [Fact]
        public void GetAttributesAttributesInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetAttributesAttributesInner
            //Assert.IsType<GetAttributesAttributesInner>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Category'
        /// </summary>
        [Fact]
        public void CategoryTest()
        {
            // TODO unit test for the property 'Category'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

        /// <summary>
        /// Test the property 'Enumeration'
        /// </summary>
        [Fact]
        public void EnumerationTest()
        {
            // TODO unit test for the property 'Enumeration'
        }

        /// <summary>
        /// Test the property 'CalculatedValue'
        /// </summary>
        [Fact]
        public void CalculatedValueTest()
        {
            // TODO unit test for the property 'CalculatedValue'
        }
    }
}
