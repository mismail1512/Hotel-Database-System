using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Forms
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable getStaffData()
        {
            string StoredProcedureName = StoredProcedures.getStaffData;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable getStaffDatanew(DateTime SWD, DateTime EWD)
        {

            string StoredProcedureName = StoredProcedures.getStaffDatanew;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SWD", SWD);
            Parameters.Add("@EWD", EWD);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getGuestsData()
        {

            string StoredProcedureName = StoredProcedures.getGuestsData;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable getFinanceData()
        {

            string StoredProcedureName = StoredProcedures.getFinanceData;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetUserType(string username, string PASS)
        {

            string StoredProcedureName = StoredProcedures.GetUserType;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@PASS", PASS);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int DeleteGuest(int G_ID)
        {

            string StoredProcedureName = StoredProcedures.DeleteGuest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@G_ID", G_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteStaff(int S_ID)
        {

            string StoredProcedureName = StoredProcedures.DeleteStaff;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID", S_ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeletePayment(int FID)
        {

            string StoredProcedureName = StoredProcedures.DeletePayment;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FID", FID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int CountFinance()
        {

            string StoredProcedureName = StoredProcedures.CountFinance;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int CountGuests()
        {

            string StoredProcedureName = StoredProcedures.CountGuests;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int CountReception()
        {

            string StoredProcedureName = StoredProcedures.CountReception;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int CountStaff()
        {

            string StoredProcedureName = StoredProcedures.CountStaff;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int GetTotalOutputFinance()
        {

            string StoredProcedureName = StoredProcedures.GetTotalOutputFinance;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int GetTotalInputFinance()
        {

            string StoredProcedureName = StoredProcedures.GetTotalInputFinance;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int GetTotalRevenueFinance()
        {

            string StoredProcedureName = StoredProcedures.GetTotalRevenueFinance;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }


        public int InsertGuest11(string z, int a, int b, string c, string e, string f)
        {
            //@G_Name, @G_ID, @NID, @Sex, @Age, @Birth, @City
            string StoredProcedureName = StoredProcedures.InsertGuest1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@G_Name", z); 
            Parameters.Add("@G_ID", a);  
            Parameters.Add("@NID", b);  
            Parameters.Add("@Sex", c);   
            Parameters.Add("@Birth", e);  
            Parameters.Add("@City", f);  
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertUser11(string a, string b, string c, string d)
        {
            //@mail, @username, @PASS, @ty
            string StoredProcedureName = StoredProcedures.InsertUser1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@mail", a);
            Parameters.Add("@username", b);
            Parameters.Add("@PASS", c);
            Parameters.Add("@ty", d);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertAllService11(int a, int b)
        {
            //@Kind, @AID
            string StoredProcedureName = StoredProcedures.InsertAllService1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Kind", a);
            Parameters.Add("@AID", b);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertStaff11(string z, int a, int b, string c, int d, string e, string f, string h, string j, string k, string l)
        {
            //@S_Name, @S_ID, @NID, @Birth, @Salary, @Department, @Sex, @W_Shift, @SWD, @EWD, @City,
            string StoredProcedureName = StoredProcedures.InsertStaff1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_Name", z);
            Parameters.Add("@S_ID", a);
            Parameters.Add("@NID", b);
            Parameters.Add("@Birth", c);
            Parameters.Add("@Salary", d);
            Parameters.Add("@Department", e);
            Parameters.Add("@Sex", f);
            Parameters.Add("@W_Shift", h);
            Parameters.Add("@SWD", j);
            Parameters.Add("@EWD", k);
            Parameters.Add("@City", l);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertReservation11(int a, int b, int c, int d, int e, int f)
        {
            //@RVID, @TypeR, @nDays, @Avl1, @Avl2, @Avl3
            string StoredProcedureName = StoredProcedures.InsertReservation1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RVID", a);
            Parameters.Add("@TypeR", b);
            Parameters.Add("@nDays", c);
            Parameters.Add("@Avl1", d);
            Parameters.Add("@Avl2", e);
            Parameters.Add("@Avl3", f);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertGym11(int a, int b, int d)
        {
            //@GID, @nHours, @No#
            string StoredProcedureName = StoredProcedures.InsertGym1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@GID", a);
            Parameters.Add("@nHours", b);
            Parameters.Add("@No#", d);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertRestaurant11(int a, string b, int f, string g, int h, string j)
        {
            //@RSID, @TypeT, @No#, @Orders, @T_Price, @TypeF
            string StoredProcedureName = StoredProcedures.InsertRestaurant1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RSID", a);
            Parameters.Add("@TypeT", b);
            Parameters.Add("@No#", f);
            Parameters.Add("@Orders", g);
            Parameters.Add("@T_Price", h);
            Parameters.Add("@TypeF", j);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertMenu11(string a, int b, string c)
        {
            //@Nam, @Price, @Typ
            string StoredProcedureName = StoredProcedures.InsertMenu1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Nam", a);
            Parameters.Add("@Price", b);
            Parameters.Add("@Typ", c);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertFinance11(int a, string b, char c, int d)
        {
            //@FID, @Descriptions, @In_OR_Out, @Amount
            string StoredProcedureName = StoredProcedures.InsertFinance1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FID", a);
            Parameters.Add("@Descriptions", b);
            Parameters.Add("@In_OR_Out", c);
            Parameters.Add("@Amount", d);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertDependant11(int a, string b, string c, string d, string f)
        {
            //@S_ID, @Nam, @sex, @Bth, @Relation
            string StoredProcedureName = StoredProcedures.InsertDependant1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID", a);
            Parameters.Add("@Nam", b);
            Parameters.Add("@sex", c);
            Parameters.Add("@Bth", d);
            Parameters.Add("@Relation", f);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertS_phones11(int a, int b)
        {
            //@S_ID, @S_phone
            string StoredProcedureName = StoredProcedures.InsertS_phones1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID1", a);
            Parameters.Add("@S_phone1", b);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertG_phones11(int a, int b)
        {
            //@G_ID, @G_phone
            string StoredProcedureName = StoredProcedures.InsertG_phones1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@G_ID1", a);
            Parameters.Add("@G_phone1", b);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertOffer11(int a, string b)
        {
            //@RID, @MName
            string StoredProcedureName = StoredProcedures.InsertOffer1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", a);
            Parameters.Add("@MName", b);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertOutcome11(int a, int b)
        {
            //@S_ID, @FID
            string StoredProcedureName = StoredProcedures.InsertOutcome1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID", a);
            Parameters.Add("@FID", b);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertBooking_Room11(int a, int b, int c, string d, string e)
        {
            //@RRID, @GID, @FID, @Fromdate, @todate
            string StoredProcedureName = StoredProcedures.InsertBooking_Room1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RRID", a);
            Parameters.Add("@GID", b);
            Parameters.Add("@FID", c);
            Parameters.Add("@Fromdate", d);
            Parameters.Add("@todate", e);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertTraining11(int a, int b, int c, string d)
        {
            //@GYID, @GID, @FID, @Dat
            string StoredProcedureName = StoredProcedures.InsertTraining1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@GYID", a);
            Parameters.Add("@GID", b);
            Parameters.Add("@FID", c);
            Parameters.Add("@Dat", d);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertRequesting_meal11(int a, int b, int c, string d)
        {
            //@RID, @GID, @FID, @Dat
            string StoredProcedureName = StoredProcedures.InsertRequesting_meal1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", a);
            Parameters.Add("@GID", b);
            Parameters.Add("@FID", c);
            Parameters.Add("@Dat", d);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int ModifyGuest11(string z, int a, int b, string c, string e, string f)
        {
            //@G_Name, @G_ID, @NID, @Sex, @Birth, @City, @ZIP, @Street
            string StoredProcedureName = StoredProcedures.ModifyGuest1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@G_Name", z);
            Parameters.Add("@G_ID", a);
            Parameters.Add("@NID", b);
            Parameters.Add("@Sex", c);
            Parameters.Add("@Birth", e);
            Parameters.Add("@City", f);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int ModifyStaff11(string z, int a, int b, string c, int d, string e, string f, string h, string j, string k, string l)
        {
            //@S_ID, @NID, @Birth, @Salary, @Department, @Sex, @W_Shift, @SWD, @EWD, @City
            string StoredProcedureName = StoredProcedures.ModifyStaff1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_Name", z);
            Parameters.Add("@S_ID", a);
            Parameters.Add("@NID", b);
            Parameters.Add("@Birth", c);
            Parameters.Add("@Salary", d);
            Parameters.Add("@Department", e);
            Parameters.Add("@Sex", f);
            Parameters.Add("@W_Shift", h);
            Parameters.Add("@SWD", j);
            Parameters.Add("@EWD", k);
            Parameters.Add("@City", l);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int ModifyFinance11(int a, string b, string c, int d)
        {
            //@FID, @Descriptions, @In_OR_Out, @Amount
            string StoredProcedureName = StoredProcedures.ModifyFinance1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FID", a);
            Parameters.Add("@Descriptions", b);
            Parameters.Add("@In_OR_Out", c);
            Parameters.Add("@Amount", d);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ModifyUser11(string a, string b, string c)
        {
            //@FID, @Descriptions, @In_OR_Out, @Amount
            string StoredProcedureName = StoredProcedures.ModifyUser1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@mail", a);
            Parameters.Add("@username", b);
            Parameters.Add("@PASS", c);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ModifyG_phones11(int a, int b)
        {
            //@G_ID, @G_phone
            string StoredProcedureName = StoredProcedures.ModifyG_phones1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@G_ID1", a);
            Parameters.Add("@G_phone1", b);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ModifyS_phones11(int a, int b)
        {
            //@S_ID, @S_phone
            string StoredProcedureName = StoredProcedures.ModifyS_phones1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID1", a);
            Parameters.Add("@S_phone1", b);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable getOneGuest11(int a)
        {

            string StoredProcedureName = StoredProcedures.getOneGuest1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@G_ID", a);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getOneStaff11(int a)
        {

            string StoredProcedureName = StoredProcedures.getOneStaff1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@S_ID", a);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getOneFinance11(int a)
        {

            string StoredProcedureName = StoredProcedures.getOneFinance1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FID", a);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        //////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////
        public int InsertRoom3(int RVID, string TypeR, int nDays, int Avl1, int Avl2, int Avl3)
        {

            string StoredProcedureName = StoredProcedures.InsertRoom3;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RVID", RVID);
            Parameters.Add("@TypeR", TypeR);
            Parameters.Add("@nDays", nDays);
            Parameters.Add("@Avl1", Avl1);
            Parameters.Add("@Avl2", Avl2);
            Parameters.Add("@Avl3", Avl3);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertBooking_Room(int RRID, int GID, int FID, DateTime Fromdate, DateTime Todate)
        {
            string StoredProcedureName = StoredProcedures.InsertBooking_Room1;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RRID", RRID);
            Parameters.Add("@GID", GID);
            Parameters.Add("@FID", FID);
            Parameters.Add("@Fromdate", Fromdate);
            Parameters.Add("@Todate", Todate);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int InsertGym(int GID, string nHours, int No)
        {

            string StoredProcedureName = StoredProcedures.InsertGym;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@GID", GID);
            Parameters.Add("@nHours", nHours);
            Parameters.Add("@No#", No);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int InsertTraining(int GYID, int GID, int FID, DateTime date)
        {

            string StoredProcedureName = StoredProcedures.InsertTraining;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@GYID", GYID);
            Parameters.Add("@GID", GID);
            Parameters.Add("@FID", FID);
            Parameters.Add("@Dat", date);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertRestaurant(int RSID, string TypeT, int No, string Orders, int T_Price, string TypeF)
        {

            string StoredProcedureName = StoredProcedures.InsertRestaurant;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RSID", RSID);
            Parameters.Add("@TypeT", TypeT);
            Parameters.Add("@No#", No);
            Parameters.Add("@Orders", Orders);
            Parameters.Add("@T_Price", T_Price);
            Parameters.Add("@TypeF", TypeF);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertRequesting_meal(int RID, int GID, int FID, DateTime Dat)
        {

            string StoredProcedureName = StoredProcedures.InsertRequesting_meal;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RID", RID);
            Parameters.Add("@GID", GID);
            Parameters.Add("@FID", FID);
            Parameters.Add("@Dat", Dat);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetCustomerData()
        {
            string StoredProcedureName = StoredProcedures.GetCustomerData;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int GetSingleroomAvail()
        {
            string StoredProcedureName = StoredProcedures.GetSingleroomAvail;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }
        public int GetDoubleroomAvail()
        {
            string StoredProcedureName = StoredProcedures.GetDoubleroomAvail;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }
        public int GetSuiteroomAvail()
        {
            string StoredProcedureName = StoredProcedures.GetSuiteroomAvail;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int InsertCurrentOrder(string servic, int price)
        {

            string StoredProcedureName = StoredProcedures.InsertCurrentOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@servic", servic);
            Parameters.Add("@price", price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetCurrentOrder()
        {
            string StoredProcedureName = StoredProcedures.GetCurrentOrder1;
            //   return (DataTable)dbMan.ExecuteScalar(StoredProcedureName, null);
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public int DeleteCurrentOrder()
        {

            string StoredProcedureName = StoredProcedures.DeleteCurrentOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertFinance(int FID, string Descriptions, char In_OR_Out, int Amount)
        {

            string StoredProcedureName = StoredProcedures.InsertFinance;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FID", FID);
            Parameters.Add("@Descriptions", Descriptions);
            Parameters.Add("@In_OR_Out", In_OR_Out);
            Parameters.Add("@Amount", Amount);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        ////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////

    }
}
