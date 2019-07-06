using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControlProject_VS
{
    public interface IPerson
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string PhoneNumber { get; set; }

        string EmailAddress { get; set; }

    }
}
