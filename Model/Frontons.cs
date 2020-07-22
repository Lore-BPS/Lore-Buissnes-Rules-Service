using System;
using System.Collections.Generic;
using System.Text;
using NodaTime;
using Npgsql.TypeHandlers;

namespace Lore_Buissnes_Rules_Service.Model
{
    class Frontons
    {

        long ActionId;

        int ActionType;

        string ActionName;

        NodaTime.LocalDateTime ActionCreateTime;

        NodaTime.LocalDateTime ActionUpdateTime;

        UuidHandler ActionUuid;

        bool ActionIsActive;

        bool ActionIsDeleted;

    }
}
