﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using TygaSoft.Model;

namespace TygaSoft.IDAL
{
    public partial interface IVehicle
    {
        #region IVehicle Member

        int Insert(VehicleInfo model);

        int InsertByOutput(VehicleInfo model);

        int Update(VehicleInfo model);

        int Delete(Guid id);

        bool DeleteBatch(IList<object> list);

        VehicleInfo GetModel(Guid id);

        IList<VehicleInfo> GetList(int pageIndex, int pageSize, out int totalRecords, string sqlWhere, params SqlParameter[] cmdParms);

        IList<VehicleInfo> GetList(int pageIndex, int pageSize, string sqlWhere, params SqlParameter[] cmdParms);

        IList<VehicleInfo> GetList(string sqlWhere, params SqlParameter[] cmdParms);

        IList<VehicleInfo> GetList();

        #endregion
    }
}
