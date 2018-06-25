namespace Customer.Api{
	using Customer.Application;
	using Customer.Application.Dto;
	using Common.Application;
	using Common.Application.Dto;
	using Common.Api.Controller;
	using System;
	using Microsoft.AspNetCore.Mvc;
	
	[Route("api/[controller]")]
    public class CustomerController{		
		CustomerApplicationService customerApplicationService;
		
		ResponseHandler responseHandler;
		//@RequestMapping(method = RequestMethod.POST, path = "create", consumes = "application/json; charset=UTF-8", produces = "application/json; charset=UTF-8")
		public ResponseDto performCreate(CustomerDto customerDto)  {
			try {
				customerApplicationService.performCreate(customerDto);
				return this.responseHandler.getOkCommandResponse("Transfer done!");
			} catch(ArgumentException ex) {
				return this.responseHandler.getAppCustomErrorResponse(ex.Message);
			} catch(Exception ex) {
				return this.responseHandler.getAppExceptionResponse();
			}
		}
	}
}

