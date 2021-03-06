using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Net;

namespace IO.Swagger.Attributes
{
    /// <summary>
    /// Model state validation attribute
    /// </summary>
	public class ValidateModelStateAttribute : System.Web.Http.Filters.ActionFilterAttribute 
	// there are two ActionFilterAttribute, one for MVC and another one for REST
	{
		/// <summary>
		/// Called before the action method is invoked
		/// </summary>
		/// <param name="context"></param>
		public override void OnActionExecuting(HttpActionContext context)
		{
            // Per https://blog.markvincze.com/how-to-validate-action-parameters-with-dataannotation-attributes/
			var parameters = context.ActionDescriptor.GetParameters();
			foreach (var p in parameters)
			{
				if (context.ActionArguments.ContainsKey(p.ParameterName))
					Validate(p, context.ActionArguments[p.ParameterName], context.ModelState);
			}

			if (!context.ModelState.IsValid)
			{
				context.Response = context.Request.CreateResponse(
					HttpStatusCode.BadRequest,
					context.ModelState.Select(_ => new { Parameter = _.Key, Errors = _.Value.Errors.Select(e => e.ErrorMessage ?? e.Exception.Message) }),
					context.ControllerContext.Configuration.Formatters.JsonFormatter
				); 
			}
		}

		private void Validate(HttpParameterDescriptor p, object argument, ModelStateDictionary modelState)
		{
			var attributes = p.GetCustomAttributes<ValidationAttribute>();
			foreach (var attr in attributes)
			{
				if (!attr.IsValid(argument))
					modelState.AddModelError(p.ParameterName, attr.FormatErrorMessage(p.ParameterName));
			}
		}
	}
}