namespace Customer.Domain.Entity{
    using BankAccount.Domain.Entity;
    using System.Collections.Generic;
    public class Customer {
        private long id;
        private string firstName;
        private string lastName;
        private List<BankAccount> bankAccounts;

        public Customer() {
        }

        public string getFullName() {
            return string.Concat("%s, %s", this.lastName, this.firstName);
        }

        public long getId() {
            return id;
        }

        public void setId(long id) {
            this.id = id;
        }

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

        public List<BankAccount> getBankAccounts() {
            return bankAccounts;
        }

        public void setBankAccounts(List<BankAccount> bankAccounts) {
            this.bankAccounts = bankAccounts;
        }
    }

}
