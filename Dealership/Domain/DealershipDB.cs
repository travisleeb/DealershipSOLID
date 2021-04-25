using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClosedXML.Excel;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace Dealership.Domain
{
    public class DealershipDB
    {
        private string excelFile = Directory.GetCurrentDirectory() + "DealershipDB.xlsx";
        private string conn = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;

        private DataTable _dtDealership = new DataTable("Dealership");
        private DataTable _dtVehicle = new DataTable("Vehicle");


        #region "Properties"
        public DataTable DealershipTable
        {
            get { return _dtDealership; }
        }

        public DataTable VehicleTable
        {
            get { return _dtVehicle; }
        }
        #endregion

        public DealershipDB()
        {
            conn = string.Format(conn, excelFile);
            InitializeDealershipTable();
            InitializeVehicleTable();
            
        }

        private void InitializeDealershipTable()
        {
            _dtDealership.Columns.AddRange(new DataColumn[3] { new DataColumn("ID"),
                                                              new DataColumn("Name"),
                                                              new DataColumn("OpenHours") });

            LoadInitialData(_dtDealership, "DEALERSHIP");
        }

        private void InitializeVehicleTable()
        {
            _dtVehicle.Columns.AddRange(new DataColumn[10] { new DataColumn("ID"),
                                                           new DataColumn("DealershipID"),
                                                           new DataColumn("Year"),
                                                           new DataColumn("Make"),
                                                           new DataColumn("Name"),
                                                           new DataColumn("CTSO"),
                                                           new DataColumn("IsNew"),
                                                           new DataColumn("Types"),
                                                           new DataColumn("DOORS"),
                                                           new DataColumn("Wheels") });

            LoadInitialData(_dtVehicle, "VEHICLE");
        }

        public void SaveChanges()
        {
            
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(_dtDealership);
                wb.Worksheets.Add(_dtVehicle);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);

                }
            }
        }

        private void LoadInitialData(DataTable dt, string tableName)
        {
            using (OleDbConnection connExcel = new OleDbConnection(conn))
            {
                using (OleDbCommand cmdExcel = new OleDbCommand())
                {
                    using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                    {
                        cmdExcel.Connection = connExcel;

                        connExcel.Open();
                        cmdExcel.CommandText = "Select * From ["+tableName+"]";
                        odaExcel.SelectCommand = cmdExcel;
                        odaExcel.Fill(dt);
                        connExcel.Close();
                    }
                }
            }
        }

    }
}