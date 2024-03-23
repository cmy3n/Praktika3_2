using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika3_2
{
    internal class Class1
    {
        public int ID_Client;
        public int ID_OrderClients;

        public string ClientSurname { get; private set; }
        public string ClientName { get; private set; }
        public string ClientMiddleName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }


        public string Products { get; private set; }


        public DateTime Receiving_DateTime { get; private set; }


        public Class1(OrdersClients oc)
        {
            Receiving_DateTime = oc.ReceivingDateTime;

            Products = oc.Orders.Products;

            ClientSurname = oc.Clients.ClientSurname;
            ClientName = oc.Clients.ClientName;
            ClientMiddleName = oc.Clients.ClientMiddleName;
            PhoneNumber = oc.Clients.PhoneNumber;
            Email = oc.Clients.Email;
        }

    }
}
