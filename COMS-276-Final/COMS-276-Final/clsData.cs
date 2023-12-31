﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace COMS_276_Final
{
    class clsData
    {

        string _strConnectionString = clsGlobal.DatabaseConnectionString; // variable to link to connectionstring property
        string _strSQL = ""; // variable to link to sql property
        DataTable dtData; // data table for data from database

        /// <summary>
        /// String to contain connection string to database
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return _strConnectionString;
            }
            set
            {
                _strConnectionString = value;
                FillDataTable();
            }
        }

        /// <summary>
        /// Store query to database
        /// </summary>
        public string SQL
        {
            get
            {
                return _strSQL;
            }
            set
            {
                _strSQL = value;
                FillDataTable(); // fill the data table
            }
        }

        /// <summary>
        /// Data table accessible from application
        /// </summary>
        public DataTable dt
        {
            get
            {
                return dtData;
            }
            set
            {
                dtData = value;
            }
        }


        /// <summary>
        /// Fill datatable with data from database based on properties of SQL and connection string 
        /// </summary>
        private void FillDataTable()
        {
            // if connection string and sql are filled, continue
            if (ConnectionString != "" && SQL != "")
            {
                // create connection to databae
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                // open connection
                conn.Open();
                // create dataset 
                DataSet ds = new DataSet();
                // fill dataset with data adapter
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, ConnectionString);
                adapter.Fill(ds);
                // close connection to database
                conn.Close();
                // fill datatable with data set
                dtData = ds.Tables[0];
            }
        }




        public void UpdateData(DataTable _DataTable, string _SQLStatement)
        {
            // update property with _SQL Statement
            SQL = _SQLStatement;
            // if connection string and sql are filled, continue
            if (ConnectionString != "" && SQL != "")
            {
                // create connection to databae
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                // open connection
                conn.Open();
                // create dataset 
                DataSet ds = new DataSet();
                // fill dataset with data adapter
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, ConnectionString);
                adapter.Fill(ds);
                // create command builder
                System.Data.OleDb.OleDbCommandBuilder cb = new System.Data.OleDb.OleDbCommandBuilder(adapter);
                // update database with datatable
                adapter.Update(_DataTable);
                // close connection to database
                conn.Close();
            }
        }

    }
}
