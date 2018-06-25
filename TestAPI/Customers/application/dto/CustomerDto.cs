namespace Customer.Application.Dto
{
using Common.Application.Dto;
using Common.Application.Enumeration;
using System.Collections.Generic;
using Accounts.Application.Dto;
public class CustomerDto: RequestBaseDto {
	private string firstName;
	private string lastName;
	private List<BankAccountDto> bankAccountsDto;

	public string getFirstName() {
		return firstName;
	}

	public void setFirstName(string firstName) {
		this.firstName = firstName;
	}

	public string getLastName() {
		return lastName;
	}

	public void setLastName(string lastName) {
		this.lastName = lastName;
	}

	public List<BankAccountDto> getBankAccountsDto() {
		return bankAccountsDto;
	}

	public void setBankAccountsDto(List<BankAccountDto> bankAccountsDto) {
		this.bankAccountsDto = bankAccountsDto;
	}

	
}

}

