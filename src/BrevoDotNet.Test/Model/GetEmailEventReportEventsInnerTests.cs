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
    ///  Class for testing GetEmailEventReportEventsInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetEmailEventReportEventsInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetEmailEventReportEventsInner
        //private GetEmailEventReportEventsInner instance;

        public GetEmailEventReportEventsInnerTests()
        {
            // TODO uncomment below to create an instance of GetEmailEventReportEventsInner
            //instance = new GetEmailEventReportEventsInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetEmailEventReportEventsInner
        /// </summary>
        [Fact]
        public void GetEmailEventReportEventsInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetEmailEventReportEventsInner
            //Assert.IsType<GetEmailEventReportEventsInner>(instance);
        }

        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }

        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Fact]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
        }

        /// <summary>
        /// Test the property 'MessageId'
        /// </summary>
        [Fact]
        public void MessageIdTest()
        {
            // TODO unit test for the property 'MessageId'
        }

        /// <summary>
        /// Test the property 'Event'
        /// </summary>
        [Fact]
        public void EventTest()
        {
            // TODO unit test for the property 'Event'
        }

        /// <summary>
        /// Test the property 'Subject'
        /// </summary>
        [Fact]
        public void SubjectTest()
        {
            // TODO unit test for the property 'Subject'
        }

        /// <summary>
        /// Test the property 'Reason'
        /// </summary>
        [Fact]
        public void ReasonTest()
        {
            // TODO unit test for the property 'Reason'
        }

        /// <summary>
        /// Test the property 'Tag'
        /// </summary>
        [Fact]
        public void TagTest()
        {
            // TODO unit test for the property 'Tag'
        }

        /// <summary>
        /// Test the property 'Ip'
        /// </summary>
        [Fact]
        public void IpTest()
        {
            // TODO unit test for the property 'Ip'
        }

        /// <summary>
        /// Test the property 'Link'
        /// </summary>
        [Fact]
        public void LinkTest()
        {
            // TODO unit test for the property 'Link'
        }

        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            // TODO unit test for the property 'From'
        }
    }
}
