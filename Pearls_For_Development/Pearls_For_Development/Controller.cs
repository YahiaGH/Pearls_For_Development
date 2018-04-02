using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Pearls_For_Development
{
    //--->> if you need any function you have wrote before you will find it down below commented ..... 
    public class Controller
    {
        // Please Write A Brief Description For Every Function You Make.
        // write extra notes and commments inside the fucntions to illustrate what you have done 
        //[Some of the marks will be on this part so please write notes and comments].

        // Like This Format  --> 
        //[ below format is used for documentation of functions this means that if hover over a function you will see what you have wrote]
        /*
         * This Function Used in .......
        */
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //public int CheckUser(string name, string pass, int num)
        //{
        //    string StoredProcedureName;
        //    if(num==1)
        //    {
        //        StoredProcedureName = StoredProcedures.CheckUserEmp;
        //    }
        //    else if(num==2)
        //    {
        //       StoredProcedureName = StoredProcedures.CheckUserMember;
        //    }
        //    else
        //    {
        //        StoredProcedureName = StoredProcedures.CheckUserInv;
        //    }

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@username", name);
        //    Parameters.Add("@password", pass);
        //    if (dbMan.ExecuteScalar(StoredProcedureName, Parameters)== null) 
        //    {
        //        return -1;
        //    }
        //    else 
        //    {
        //        return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        //    }
        //}

        //public int GetUserID(string name,int ID, int num)
        //{
        //    string StoredProcedureName="";
        //    if (num == 1)
        //    {
        //        StoredProcedureName = StoredProcedures.GetUserIDEmp;
        //    }
        //    else if (num == 2)
        //    {
        //        StoredProcedureName = StoredProcedures.GetUserIDMember;
        //    }
        //    else
        //    {
        //        StoredProcedureName = StoredProcedures.GetUserIDInvestor;
        //    }

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@username", name);
        //    Parameters.Add("@ID", ID);
        //    if (dbMan.ExecuteScalar(StoredProcedureName, Parameters) == null)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        //    }
        //}

        //public int MaxEmployeeID()
        //{

        //   string StoredProcedureName = StoredProcedures.MaxEmployeeID;     
        //   return (int)dbMan.ExecuteScalar(StoredProcedureName,null);
        //}

        //public int GetPerson(int ID,int num)
        //{
        //    string StoredProcedureName="";
        //    if (num == 1) // Employee
        //    {
        //        StoredProcedureName = StoredProcedures.GetEmployee;
        //    }
        //    else if (num == 2) // Member
        //    {
        //        StoredProcedureName = StoredProcedures.GetMember;
        //    }

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    if (dbMan.ExecuteScalar(StoredProcedureName, Parameters) == null)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        //    }
        //}
        //public int ManagerDepNum(int ID)
        //{
        //    string StoredProcedureName = StoredProcedures.ManagerDepNum;

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    if (dbMan.ExecuteScalar(StoredProcedureName, Parameters) == null)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        //    }

        //}

        //public int PricePlayGround(int pno,string sport)
        //{
        //    string StoredProcedureName = StoredProcedures.PricePlayGround;

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@PNO", pno);
        //    Parameters.Add("@Sport", sport);
        //    if (dbMan.ExecuteScalar(StoredProcedureName, Parameters) == null)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        //    }

        //}

        //public int Update_Password( int ID, string Pass, int num)
        //{
        //    string StoredProcedureName = "";
        //    if (num == 1) // Employee
        //    {
        //        StoredProcedureName = StoredProcedures.Update_PasswordEmployee;
        //    }
        //    else if (num == 2) // Member
        //    {
        //        StoredProcedureName = StoredProcedures.Update_PasswordMember;
        //    }
        //    else if (num == 3)
        //    {
        //        StoredProcedureName = StoredProcedures.Update_PasswordInvestor;
        //    }

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@Password", Pass);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public int InsertNewUser(string username, int ID ,string Pass,int priv ,int num)
        //{
        //    string StoredProcedureName = "";
        //    if (num == 1) // Employee
        //    {
        //        StoredProcedureName = StoredProcedures.InsertUserEmployee;
        //    }
        //    else if (num == 2) // Member
        //    {
        //        StoredProcedureName = StoredProcedures.InsertUserMember;
        //    }
        //    else if(num==10)
        //    {
        //        StoredProcedureName = StoredProcedures.InsertUserInvestor;
        //    }

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@username", username);
        //    Parameters.Add("@Password", Pass);
        //    Parameters.Add("@priv", priv);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}
        //public int InsertEmployee(int ID, string Address, int Salary,DateTime birth, string fname, string Mname, string Lname, int Dnum)
        //{
        //    string StoredProcedureName ;
        //    StoredProcedureName = StoredProcedures.InsertUserMember;

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@Address", Address);
        //    Parameters.Add("@salary", Salary);
        //    Parameters.Add("@birth", birth);
        //    Parameters.Add("@Firstname", fname);
        //    Parameters.Add("@Midname", Mname);
        //    Parameters.Add("@Lastname", Lname);
        //    Parameters.Add("@Dnum", Dnum);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public int RemoveEmployee(int ID,  int Dno)
        //{
        //    string StoredProcedureName;
        //    StoredProcedureName = StoredProcedures.RemoveEmployee;

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@DNO", Dno);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public DataTable isManager(int ID)
        //{
        //    String StoredProcedureName = StoredProcedures.isManager;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}

        //public DataTable SearchEmployeeName(string name, int Dno)
        //{
        //    String StoredProcedureName = StoredProcedures.SearchEmployeeName;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Fname", name);
        //    Parameters.Add("@DNO", Dno);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable Check_ifRentedPlayGround(int pno,string sport,string time,string date)
        //{
        //    String StoredProcedureName = StoredProcedures.Check_ifRentedPlayGround;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@PNO", pno);
        //    Parameters.Add("@Sport", sport);
        //    Parameters.Add("@Time", time);
        //    Parameters.Add("@Date", date);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}

        //public int AddRent_PlayGround(int ID, int pno, string sport, string time, string date)
        //{
        //    string StoredProcedureName ;
        //    StoredProcedureName = StoredProcedures.AddRent_PlayGround;

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@PNO", pno);
        //    Parameters.Add("@Sport", sport);
        //    Parameters.Add("@Time ", time);
        //    Parameters.Add("@Date ", date);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}
        //public DataTable GetEmployeeInfo(int ID)
        //{
        //    String StoredProcedureName = StoredProcedures.GetEmployeeInfo;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}

        //public DataTable ShowRentedPlayGrounds(string sport,string time,string date)
        //{
        //    String StoredProcedureName = StoredProcedures.ShowRentedPlayGrounds;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Sport", sport);
        //    Parameters.Add("@Time", time);
        //    Parameters.Add("@Date", date);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable ShowMy_RentedPlayGrounds(int ID,string sport, string time, string date)
        //{
        //    String StoredProcedureName = StoredProcedures.ShowMy_RentedPlayGrounds;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@Sport", sport);
        //    Parameters.Add("@Time", time);
        //    Parameters.Add("@Date", date);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable ShowMy_RentingHistory_PlayGrounds(int ID, string sport)
        //{
        //    String StoredProcedureName = StoredProcedures.ShowMy_RentingHistory_PlayGrounds;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@Sport", sport);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public int CancelRent_PlayGrounds(int ID, int pno, string sport, string time, string date)
        //{
        //    string StoredProcedureName ;
        //    StoredProcedureName = StoredProcedures.CancelRent_PlayGrounds;

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@PNO", pno);
        //    Parameters.Add("@Sport", sport);
        //    Parameters.Add("@Time ", time);
        //    Parameters.Add("@Date ", date);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}
        //public int Update_PlayGrounds(int pno, string sport,int Price, string Qal)
        //{
        //    string StoredProcedureName ;
        //    StoredProcedureName = StoredProcedures.Update_PlayGrounds;

        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@PNO", pno);
        //    Parameters.Add("@Sport", sport);
        //    Parameters.Add("@Price ", Price);
        //    Parameters.Add("@Qal ", Qal);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public DataTable All_PlayGrounds(string sport)
        //{
        //    String StoredProcedureName = StoredProcedures.All_PlayGrounds;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Sportname", sport);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable GetAllSports()
        //{
        //    String StoredProcedureName = StoredProcedures.GetAllSports;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}
        //public DataTable Sport_PlayGrounds(string Sportname)
        //{
        //    String StoredProcedureName = StoredProcedures.Sport_PlayGrounds;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Sportname", Sportname);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable SearchEmployee_M_FName(string fname, string Mname, int Dno)
        //{
        //    String StoredProcedureName = StoredProcedures.SearchEmployee_M_FName;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Fname", fname);
        //    Parameters.Add("@Mname", Mname);
        //    Parameters.Add("@DNO", Dno);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable SearchEmployee_F_M_LName(string fname, string Mname, string Lname,int Dno)
        //{
        //    String StoredProcedureName = StoredProcedures.SearchEmployee_F_M_LName;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Fname", fname);
        //    Parameters.Add("@Mname", Mname);
        //    Parameters.Add("@Lname", Lname);
        //    Parameters.Add("@DNO", Dno);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable Avalible_PlayGrounds(int Pno, string Sport, string Time, string Date)
        //{
        //    String StoredProcedureName = StoredProcedures.Avalible_PlayGrounds;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@PNO", Pno);
        //    Parameters.Add("@Sport", Sport);
        //    Parameters.Add("@Time", Time);
        //    Parameters.Add("@Date", Date);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable GetEmp(string name)
        //{
        //    String StoredProcedureName = StoredProcedures.GetEmp;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@name", name);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}

        //public int InsFeedback(string feed, int MID, string name)
        //{
        //    int EID;
        //    string StoredProcedureName1 = StoredProcedures.GetEmpID;
        //    Dictionary<string, object> Parameters1 = new Dictionary<string, object>();
        //    Parameters1.Add("@name", name);
        //    EID = (int)(dbMan.ExecuteScalar(StoredProcedureName1, Parameters1));
        //    DateTime date = new DateTime();
        //    date = DateTime.Now;
        //    string d = date.ToString("yyyy-MM-dd hh:mm:ss");
        //    string StoredProcedureName = StoredProcedures.InsFeedback;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@EID", EID);
        //    Parameters.Add("@MID", MID);
        //    Parameters.Add("@ED", d);
        //    Parameters.Add("@feed", feed);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}
        //public DataTable isPlayer(int ID)
        //{
        //    String StoredProcedureName = StoredProcedures.isPlayer;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable GetTraining(string sport, string day)
        //{
        //    String StoredProcedureName = StoredProcedures.GetTraining;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@sport", sport);
        //    Parameters.Add("@day", day);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable GetSportByID(int ID)
        //{

        //    String StoredProcedureName = StoredProcedures.GetSportByID;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);

        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        //}
        //public int InsertSchedule(string sport, string day, int index)
        //{
        //    string time;
        //    if (index == 0)
        //        time = "06:00:00";
        //    else if (index == 1)
        //        time = "08:00:00";
        //    else if (index == 2)
        //        time = "18:00:00";
        //    else if (index == 3)
        //        time = "20:00:00";
        //    else
        //        return 5;
        //    string StoredProcedureName = StoredProcedures.InsertSchedule;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@sport", sport);
        //    Parameters.Add("@day", day);
        //    Parameters.Add("@time", time);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public DataTable GetScheduleBySport(string sport)
        //{
        //    String StoredProcedureName = StoredProcedures.GetScheduleBySport;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@sport", sport);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable GetScheduleDay(string sport)
        //{
        //    String StoredProcedureName = StoredProcedures.GetScheduleDay;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@sport", sport);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable GetMySchedule(int ID)
        //{
        //    String StoredProcedureName = StoredProcedures.GetMySchedule;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public DataTable ViewContract(int ID)
        //{
        //    String StoredProcedureName = StoredProcedures.ViewContract;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
        //public int UpdateSchedule(string sport, string day, int index)
        //{
        //    string time;
        //    if (index == 0)
        //        time = "06:00:00";
        //    else if (index == 1)
        //        time = "08:00:00";
        //    else if (index == 2)
        //        time = "18:00:00";
        //    else if (index == 3)
        //        time = "20:00:00";
        //    else if (index == 4)
        //    {
        //        return DeleteTraining(sport, day);
        //    }
        //    else
        //        return 5;
        //    string StoredProcedureName = StoredProcedures.UpdateSchedule;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@sport", sport);
        //    Parameters.Add("@day", day);
        //    Parameters.Add("@time", time);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        //}
        //public int DeleteTraining(string sport, string day)
        //{
        //    string StoredProcedureName = StoredProcedures.DeleteTraining;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@sport", sport);
        //    Parameters.Add("@day", day);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}
        //public DataTable SelectAvailableShops()
        //{

        //    string StoredProcedureName = StoredProcedures.GetAvShops;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}

        //public DataTable GetRentingInformation(int Id)
        //{
        //    String StoredProcedureName = StoredProcedures.GetRentingInfo;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@Investorid", Id);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}

        //public DataTable SelectAvailableShopIds()
        //{
        //    string StoredProcedureName = StoredProcedures.GetAvShopsIds;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}

        //public int RentingShops(string StartDate, string EndDate, int ShopId, int Investorid)
        //{

        //    string StoredProcedureName = StoredProcedures.RentShops;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@startdate", StartDate);
        //    Parameters.Add("@enddate", EndDate);
        //    Parameters.Add("@shopid", ShopId);
        //    Parameters.Add("@investorid", Investorid);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public DataTable GetAllRentedShops()
        //{
        //    string StoredProcedureName = StoredProcedures.GetRentedShops;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}

        //public DataTable GetAllRentedShopsIds()
        //{
        //    string StoredProcedureName = StoredProcedures.GetRentedShopsIds;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}

        //public int GiveShopEvaluation(int ShopId, int MemberId, DateTime FeedbackDate, string FeedbackDegree)
        //{
        //    string StoredProcedureName = StoredProcedures.ShopEvaluation;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ShopId", ShopId);
        //    Parameters.Add("@MemberId", MemberId);
        //    Parameters.Add("@FeedbackDate", FeedbackDate);
        //    Parameters.Add("@FeedbackDegree", FeedbackDegree);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public DataTable GetAllTripIdsForAMember(int MemberID, DateTime TodaysDate)
        //{
        //    string StoredProcedureName = StoredProcedures.GetTripIds;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@MemberId", MemberID);
        //    Parameters.Add("@FeedbackDate", TodaysDate);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}

        //public DataTable GetTripData(int MemberId, DateTime TodaysDate)
        //{
        //    string StoredProcedureName = StoredProcedures.GetTripData;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@MemberId", MemberId);
        //    Parameters.Add("@FeedbackDate", TodaysDate);
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}

        //public int GiveTripFeedBack(string FeedBack, int TripNumber, int MemberID)
        //{
        //    string StoredProcedureName = StoredProcedures.TripFeedBack;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@FeedbackDegree", FeedBack);
        //    Parameters.Add("@TripNumber", TripNumber);
        //    Parameters.Add("@MemberId", MemberID);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public DataTable RentedShopsNames()
        //{
        //    string StoredProcedureName = StoredProcedures.RentedShopsNames;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}
        ///// <summary>
        ///// //
        ///// </summary>
        ///// <returns></returns>
        //public DataTable PendingShopNameAndId()
        //{
        //    string StoredProcedureName = StoredProcedures.PendingShopNameAndId;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}

        //public int AcceptShopStatus(int ShopId)
        //{
        //    string StoredProcedureName = StoredProcedures.AcceptShopStatus;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@shopid", ShopId);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public int RejectShopStatus(int ShopId)
        //{
        //    string StoredProcedureName = StoredProcedures.RejectShopStatus;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@shopid", ShopId);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}
        /////
        //public int InsertMember(int ID, String FName, string MName, String LName, DateTime Start_Date, DateTime End_Date, string Adress, String Member_Ship, DateTime Birth_Date, String test)
        //{

        //    string StoredProcedureName = StoredProcedures.AddNewMember;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@FName", FName);
        //    Parameters.Add("@MName", MName);
        //    Parameters.Add("@LName", LName);
        //    Parameters.Add("@Start_Date", Start_Date);
        //    Parameters.Add("@End_Date", End_Date);
        //    Parameters.Add("@Adress", Adress);
        //    Parameters.Add("@Member_Ship", Member_Ship);
        //    Parameters.Add("@Birth_Date", Birth_Date);
        //    Parameters.Add("@test", test);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}
        //public int GetMaxID()
        //{
        //    string StoredProcedureName = StoredProcedures.GetMaxID;
        //    return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        //}
        //public int GetMaxTripNo()
        //{
        //    string StoredProcedureName = StoredProcedures.GetMaxTripNo;
        //    return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        //}
        //public int UpdateMember(int ID, DateTime Start_Date, DateTime End_Date)
        //{
        //    string StoredProcedureName = StoredProcedures.UpdateMember;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@Start_Date", Start_Date);
        //    Parameters.Add("@End_Date", End_Date);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        //}
        //public bool IsMember(int ID)
        //{
        //    String StoredProcedureName = StoredProcedures.IsMember;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    DataTable DT = dbMan.ExecuteReader(StoredProcedureName, Parameters);

        //    if (DT == null)
        //        return false;
        //    return true;
        //}
        //public int AddTeamMember(int ID, String PlayerRole, int Experience, int Salary, int TshirtNum, string SportName)
        //{

        //    string StoredProcedureName = StoredProcedures.AddTeamMember;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@P_Role", PlayerRole);
        //    Parameters.Add("@Experience", Experience);
        //    Parameters.Add("@Salary ", Salary);
        //    Parameters.Add("@TShirt_Num ", TshirtNum);
        //    Parameters.Add("@S_Name", SportName);

        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}
        //public DataTable GetSports()
        //{
        //    String StoredProcedureName = StoredProcedures.GetSPorts;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}
        //public DataTable GetAllMembers()
        //{
        //    String StoredProcedureName = StoredProcedures.GetAllMembers;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}
        //public DataTable GetAllTrips()
        //{
        //    String StoredProcedureName = StoredProcedures.GetAllTrips;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);
        //}
        //public DataTable GetMemberByID(int ID)
        //{
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    String StoredProcedureName = StoredProcedures.GetMemberByID;
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}


        //public int UpdateTeamMember(int ID, String PlayerRole, int Experience, int Salary, int TshirtNum)
        //{

        //    string StoredProcedureName = StoredProcedures.UpdateTeamMember;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    Parameters.Add("@P_Role", PlayerRole);
        //    Parameters.Add("@Experience", Experience);
        //    Parameters.Add("@Salary ", Salary);
        //    Parameters.Add("@TShirt_Num ", TshirtNum);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}


        //public int AddTrip(int TripNo, int TripPrice, string Destination_City, DateTime DepartDate, DateTime ArrivalDate, int Emp_ID)
        //{
        //    string StoredProcedureName = StoredProcedures.AddTrip;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@TripNo", TripNo);
        //    Parameters.Add("@TripPrice", TripPrice);
        //    Parameters.Add("@Destination_City", Destination_City);
        //    Parameters.Add("@DepartDate ", DepartDate);
        //    Parameters.Add("@ArrivalDate ", ArrivalDate);
        //    Parameters.Add("@Emp_ID", Emp_ID);

        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        //}

        //public DataTable GetMemberByFullName(String FirstName, string MiddleName, string LastName)
        //{
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@FirstName", FirstName);
        //    Parameters.Add("@MiddleName", MiddleName);
        //    Parameters.Add("@LastName ", LastName);
        //    String StoredProcedureName = StoredProcedures.GetMemberByFullName;
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}

        //public DataTable GetMemberByFNameAndMName(String FirstName, string MiddleName)
        //{
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@FirstName", FirstName);
        //    Parameters.Add("@MiddleName", MiddleName);
        //    String StoredProcedureName = StoredProcedures.GetMemberByFNameAndMName;
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        //}

        //public DataTable GetMemberByFName(String FirstName)
        //{
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@FirstName", FirstName);
        //    String StoredProcedureName = StoredProcedures.GetMemberByFName;
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        //}

        //public bool IsEmployee(int ID)
        //{
        //    String StoredProcedureName = StoredProcedures.IsEmployee;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@ID", ID);
        //    DataTable DT = dbMan.ExecuteReader(StoredProcedureName, Parameters);

        //    if (DT == null)
        //        return false;
        //    return true;
        //}

        //public DataTable GetEmpolyeesNameAndID()
        //{
        //    String StoredProcedureName = StoredProcedures.GetEmpolyeesNameAndID;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);

        //}
        //public DataTable GetMemberNameAndID()
        //{
        //    String StoredProcedureName = StoredProcedures.GetMemberNameAndID;
        //    return dbMan.ExecuteReader(StoredProcedureName, null);

        //}
        //public int MemberJoinsTrip(int MID, int T_No)
        //{
        //    string StoredProcedureName = StoredProcedures.MemberJoinsTrip;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("@M_ID", MID);
        //    Parameters.Add("@T_No", T_No);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);


        //}
        //public int AddContract(int ID, DateTime Start_Date, DateTime End_Date)
        //{
        //    string StoredProcedureName = StoredProcedures.AddContract;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();

        //    Parameters.Add("@StartDate", Start_Date);
        //    Parameters.Add("@EndDate", End_Date);
        //    Parameters.Add("@M_ID", ID);
        //    return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        //}
        //public DataTable GetAchievments(string SportName)
        //{
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    Parameters.Add("Sport_Name", SportName);
        //    String StoredProcedureName = StoredProcedures.ViewAchievments;
        //    return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        //}
    }
}
