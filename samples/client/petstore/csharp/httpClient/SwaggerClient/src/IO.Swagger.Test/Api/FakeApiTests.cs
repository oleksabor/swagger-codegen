/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing FakeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FakeApiTests
    {
        private FakeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FakeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FakeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FakeApi
            //Assert.IsInstanceOfType(typeof(FakeApi), instance, "instance is a FakeApi");
        }

        
        /// <summary>
        /// Test FakeOuterBooleanSerialize
        /// </summary>
        [Test]
        public void FakeOuterBooleanSerializeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OuterBoolean body = null;
            //var response = instance.FakeOuterBooleanSerialize(body);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test FakeOuterCompositeSerialize
        /// </summary>
        [Test]
        public void FakeOuterCompositeSerializeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OuterComposite body = null;
            //var response = instance.FakeOuterCompositeSerialize(body);
            //Assert.IsInstanceOf<OuterComposite> (response, "response is OuterComposite");
        }
        
        /// <summary>
        /// Test FakeOuterNumberSerialize
        /// </summary>
        [Test]
        public void FakeOuterNumberSerializeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OuterNumber body = null;
            //var response = instance.FakeOuterNumberSerialize(body);
            //Assert.IsInstanceOf<decimal?> (response, "response is decimal?");
        }
        
        /// <summary>
        /// Test FakeOuterStringSerialize
        /// </summary>
        [Test]
        public void FakeOuterStringSerializeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OuterString body = null;
            //var response = instance.FakeOuterStringSerialize(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test TestBodyWithQueryParams
        /// </summary>
        [Test]
        public void TestBodyWithQueryParamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //User body = null;
            //string query = null;
            //instance.TestBodyWithQueryParams(body, query);
            
        }
        
        /// <summary>
        /// Test TestClientModel
        /// </summary>
        [Test]
        public void TestClientModelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ModelClient body = null;
            //var response = instance.TestClientModel(body);
            //Assert.IsInstanceOf<ModelClient> (response, "response is ModelClient");
        }
        
        /// <summary>
        /// Test TestEndpointParameters
        /// </summary>
        [Test]
        public void TestEndpointParametersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? number = null;
            //double? _double = null;
            //string patternWithoutDelimiter = null;
            //byte[] _byte = null;
            //int? integer = null;
            //int? int32 = null;
            //long? int64 = null;
            //float? _float = null;
            //string _string = null;
            //byte[] binary = null;
            //DateTime? date = null;
            //DateTime? dateTime = null;
            //string password = null;
            //string callback = null;
            //instance.TestEndpointParameters(number, _double, patternWithoutDelimiter, _byte, integer, int32, int64, _float, _string, binary, date, dateTime, password, callback);
            
        }
        
        /// <summary>
        /// Test TestEnumParameters
        /// </summary>
        [Test]
        public void TestEnumParametersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> enumFormStringArray = null;
            //string enumFormString = null;
            //List<string> enumHeaderStringArray = null;
            //string enumHeaderString = null;
            //List<string> enumQueryStringArray = null;
            //string enumQueryString = null;
            //int? enumQueryInteger = null;
            //double? enumQueryDouble = null;
            //instance.TestEnumParameters(enumFormStringArray, enumFormString, enumHeaderStringArray, enumHeaderString, enumQueryStringArray, enumQueryString, enumQueryInteger, enumQueryDouble);
            
        }
        
        /// <summary>
        /// Test TestInlineAdditionalProperties
        /// </summary>
        [Test]
        public void TestInlineAdditionalPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object param = null;
            //instance.TestInlineAdditionalProperties(param);
            
        }
        
        /// <summary>
        /// Test TestJsonFormData
        /// </summary>
        [Test]
        public void TestJsonFormDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string param = null;
            //string param2 = null;
            //instance.TestJsonFormData(param, param2);
            
        }
        
    }

}
