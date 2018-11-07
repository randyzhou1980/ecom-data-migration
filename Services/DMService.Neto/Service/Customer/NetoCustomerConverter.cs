using DMEntity.Neto;
using System.Collections.Generic;
using System.Linq;

namespace DMService.Neto.Service
{
    public class NetoCustomerConverter: INetoCustomerConverter
    {
        #region BigCommerce
        public Customer ConvertToCustomer(DMEntity.BigCommerce.Customer bcommCustomer)
        {
            var customer = new Customer(bcommCustomer.UserName);

            customer.EmailAddress = bcommCustomer.Email;
            customer.CreditLimit = bcommCustomer.Store_credit;

            customer.BillingAddress = ConvertToBillingAddress(bcommCustomer.CustomerAddresses);
            customer.ShippingAddress = ConvertToShippingAddress(bcommCustomer.CustomerAddresses);

            return customer;
        }

        public BillingAddress ConvertToBillingAddress(IEnumerable<DMEntity.BigCommerce.CustomerAddress> bcommAddresses)
        {
            var commercialAddress = GetBCommAddressByType(bcommAddresses, DMEntity.BigCommerce.CustomerAddress.AddressType.Commercial);
            if (commercialAddress == null)
            {
                return null;
            }


            return new BillingAddress()
            {
                BillFirstName = commercialAddress.First_name,
                BillLastName = commercialAddress.Last_name,
                BillCompany = commercialAddress.Company,
                BillStreetLine1 = commercialAddress.Street_1,
                BillStreetLine2 = commercialAddress.Street_2,
                BillCity = commercialAddress.City,
                BillState = commercialAddress.State,
                BillPostCode = commercialAddress.Zip,
                BillCountry = commercialAddress.Country_iso2,
                BillPhone = commercialAddress.Phone
            };
        }
        public ShippingAddress ConvertToShippingAddress(IEnumerable<DMEntity.BigCommerce.CustomerAddress> bcommAddresses)
        {
            var shippingAddress = GetBCommAddressByType(bcommAddresses, DMEntity.BigCommerce.CustomerAddress.AddressType.Residential);
            if (shippingAddress == null)
            {
                return null;
            }

            return new ShippingAddress()
            {
                ShipFirstName = shippingAddress.First_name,
                ShipLastName = shippingAddress.Last_name,
                ShipCompany = shippingAddress.Company,
                ShipStreetLine1 = shippingAddress.Street_1,
                ShipStreetLine2 = shippingAddress.Street_2,
                ShipCity = shippingAddress.City,
                ShipState = shippingAddress.State,
                ShipPostCode = shippingAddress.Zip,
                ShipCountry = shippingAddress.Country_iso2,
                ShipPhone = shippingAddress.Phone
            };
        }
        private DMEntity.BigCommerce.CustomerAddress GetBCommAddressByType(IEnumerable<DMEntity.BigCommerce.CustomerAddress> bcommAddress, 
            DMEntity.BigCommerce.CustomerAddress.AddressType addressType)
        {
            if (bcommAddress == null)
            {
                return null;
            }

            return bcommAddress.FirstOrDefault(a => a.Address_type.ToLower() == DMEntity.BigCommerce.CustomerAddress.AddressType.Commercial.ToString().ToLower());
        }

        #endregion
    }
}
