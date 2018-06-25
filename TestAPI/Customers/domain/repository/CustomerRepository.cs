namespace Customer.Domain.Repository
{
    using Customer.Domain.Entity;

    public interface CustomerRepository {
        void save(Customer customer);
    }

}

