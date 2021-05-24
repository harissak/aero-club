﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public static class ServMBR
    {
        static public List<MBR> Read_MBR_BY_START_NAME(string start_name)
        {
            List<MBR> retval = new List<MBR>();

            retval = DAL.AccesMBR.SelectMbr(start_name);

            return retval;
        }
    }
}
