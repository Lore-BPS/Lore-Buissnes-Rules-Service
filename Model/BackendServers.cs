using System;
using System.Collections.Generic;
using System.Text;
using NodaTime;
using Npgsql.TypeHandlers;

namespace Lore_Buissnes_Rules_Service.Model
{
    class BackendServers
    {

        long BackendServersId;

        int BackendServersType;

        string BackendServersName;

        NodaTime.LocalDateTime BackendServersCreateTime;

        NodaTime.LocalDateTime BackendServersUpdateTime;

        UuidHandler BackendServersUuid;

        bool BackendServersIsActive;

        bool BackendServersIsDeleted;

    }
}
