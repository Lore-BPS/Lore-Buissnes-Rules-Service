using System;
using System.Collections.Generic;
using System.Text;
using Npgsql.Schema;
using Npgsql.TypeHandlers;

namespace Lore_Buissnes_Rules_Service.Model
{
    class Action
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
