using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Approach
{
    enum VesselNames { Dragon, Discover_Bay, Big_Fish, Aristaios, Cable_Innovator }
    enum ImportType { Machines, Fruits, Medicine}
    enum AgentName
    {
        SEAS_INTERNATIONAL,
        AQUAMARINE_LIMITED,
        BANGLADESH_SHIPPING_CORPORATION,
        Bluewater,
        Matson
    }
    enum FlagName {Bangladesh, USA, LBR, GBR }
    enum Ports { Seattle, Chittagong, Tacoma, Anacortes, Bellingham }
    enum Piers { Anchor, Tesoro, Sperry, WA_United, Bangali }

    interface IImportType
    {
        string ListOfImportType(string importList);
    }
}
