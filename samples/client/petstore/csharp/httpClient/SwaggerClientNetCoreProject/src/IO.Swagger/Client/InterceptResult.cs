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

namespace IO.Swagger.Client
{
	/// <summary>
	/// allows interceptor to return some data to the <see cref="ApiClient"/>
	/// </summary>
	class InterceptResult
	{
		/// <summary>
		/// should it retry to send the request
		/// </summary>
		public bool Retry;
	}
}
