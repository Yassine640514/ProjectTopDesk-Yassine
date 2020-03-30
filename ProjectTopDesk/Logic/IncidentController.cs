using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTopDesk.Model;
using ProjectTopDesk.DAL;
using MongoDB.Bson;

namespace ProjectTopDesk.Logic
{
    class IncidentController
    {
        incidentDAO incidentDAO = new incidentDAO();
        public int getAmountUnresolvedIncidents()
        {
            int amountUnresolved =  incidentDAO.getAmountUnresolvedIncidents();

            return amountUnresolved;
        }

        public int getAmountTotalIncidents()
        {
            int totalIncidents = incidentDAO.getAmountTotalIncidents();

            return totalIncidents;
        }

        public int getAmountLateIncidents()
        {
            int lateIncidents = incidentDAO.getAmountLateIncidents();

            return lateIncidents;
        }

    }
}
