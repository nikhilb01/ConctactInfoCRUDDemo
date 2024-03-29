﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfo.BL.BusinessInterfaces
{
    public interface IContactInfoBL
    {
        List<DBEntities.Entities.ContactInfo> GetAllContactInfo();

        bool SaveContactInfo(DBEntities.Entities.ContactInfo contactInfo);

        bool EditContactInfo(DBEntities.Entities.ContactInfo contactInfo);

        bool DeleteContactInfo(int id);
    }
}
