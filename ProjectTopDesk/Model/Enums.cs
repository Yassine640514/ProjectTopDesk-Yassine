using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTopDesk.Model
{
    // enums for incidents
    public enum IncidentType
    {
        Service,
        Software,
        Hardware
    }

    public enum Priority
    {
        Low,
        Normal,
        High
    }

    public enum Deadline
    {
        FourDays,               // 7 days
        FourTeenDays,           // 14 days
        TwentyEightDays,        // 28 days
        SixMonths               // 6 months
    }

    //enums for users
    public enum UserType
    {
        Employee=1,
        ServiceDeskEmployee
    }

    public enum Location
    {
        Haarlem=1,
        Amsterdam,
        Knuppeldam,
        Headquarters
    }

}
