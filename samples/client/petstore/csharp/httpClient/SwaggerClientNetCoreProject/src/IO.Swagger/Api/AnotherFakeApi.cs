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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnotherFakeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">client model</param>
        /// <returns>ModelClient</returns>
        ModelClient TestSpecialTags (ModelClient body);

        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">client model</param>
        /// <returns>ApiResponse of ModelClient</returns>
        ApiResponse<ModelClient> TestSpecialTagsWithHttpInfo (ModelClient body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">client model</param>
        /// <returns>Task of ModelClient</returns>
        System.Threading.Tasks.Task<ModelClient> TestSpecialTagsAsync (ModelClient body);

        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">client model</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelClient>> TestSpecialTagsAsyncWithHttpInfo (ModelClient body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AnotherFakeApi : IAnotherFakeApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnotherFakeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AnotherFakeApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnotherFakeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AnotherFakeApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// To test special tags To test special tags
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">client model</param>
        /// <returns>ModelClient</returns>
        public ModelClient TestSpecialTags (ModelClient body)
        {
             ApiResponse<ModelClient> localVarResponse = TestSpecialTagsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// To test special tags To test special tags
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">client model</param>
        /// <returns>ApiResponse of ModelClient</returns>
        public ApiResponse< ModelClient > TestSpecialTagsWithHttpInfo (ModelClient body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AnotherFakeApi->TestSpecialTags");

            var localVarPath = "./another-fake/dummy";

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var requestParameters = new RequestParameters(Configuration, contentTypes: localVarHttpContentTypes, accepts: localVarHttpHeaderAccepts);

            requestParameters.AddBody(body); // body parameter


            // make the HTTP request
            var localVarResponse = this.Configuration.ApiClient.CallApi(localVarPath,
                new HttpMethod("PATCH"), requestParameters);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TestSpecialTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.ToHeaders(),
                this.Configuration.ApiClient.Deserialize<ModelClient>(localVarResponse));
        }

        /// <summary>
        /// To test special tags To test special tags
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">client model</param>
        /// <returns>Task of ModelClient</returns>
        public async System.Threading.Tasks.Task<ModelClient> TestSpecialTagsAsync (ModelClient body)
        {
             ApiResponse<ModelClient> localVarResponse = await TestSpecialTagsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// To test special tags To test special tags
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">client model</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelClient>> TestSpecialTagsAsyncWithHttpInfo (ModelClient body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AnotherFakeApi->TestSpecialTags");

            var localVarPath = "./another-fake/dummy";

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var requestParameters = new RequestParameters(Configuration, contentTypes: localVarHttpContentTypes, accepts: localVarHttpHeaderAccepts);

			requestParameters.AddBody(body);


            // make the HTTP request
            var localVarResponse = await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                new HttpMethod("PATCH"), requestParameters);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TestSpecialTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.ToHeaders(),
                this.Configuration.ApiClient.Deserialize<ModelClient>(localVarResponse));
        }

    }
}
