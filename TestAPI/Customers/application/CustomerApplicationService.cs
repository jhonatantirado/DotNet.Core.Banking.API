namespace Customer.Application{

    using Customer.Domain.Repository;
    using Customer.Domain.Entity;
    using Common.Application;
    using Customer.Application.Dto;
    using Common.Application.Enumeration;
    using System;
    public class CustomerApplicationService {

	private CustomerRepository customerRepository;
	
	public void performCreate(CustomerDto customerDto)  {
		Notification notification = this.validation(customerDto);
        if (notification.hasErrors()) {
            throw new ArgumentException(notification.errorMessage());
        }	
        
        Customer customer = new Customer();        
        customer.setFirstName(customerDto.getFirstName());
        customer.setLastName(customerDto.getLastName()); 
        this.customerRepository.save(customer);
	}
	
	private Notification validation(CustomerDto customerDto) {
		Notification notification = new Notification();
		if (customerDto == null || customerDto.getRequestBodyType() == RequestBodyType.Invalid) {
			notification.addError("Invalid JSON data in request body.");
		}
		return notification;
	}
}
}

