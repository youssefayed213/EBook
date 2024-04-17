using System;
using System.Collections.Generic;
using Ebook.Models.DAL;
using Ebook.Models.Entity.Document;
using Ebook.Models.Entity.Statistics;

namespace Ebook.Models.BLL
{
    public class BllStatistics
    {
        public static int GetTotalUsers()
        {
            return DALStatistics.GetTotalUsers();
        }
        
        public static int GetTodayUsers()
        {
            return DALStatistics.GetTodayUsers();
        }
        
        public static int GetTotalDocuments()
        {
            return DALStatistics.GetTotalDocuments();
        }
        
        public static int GetTodaySales()
        {
            return DALStatistics.GetTodaySales();
        }
        public static int GetTotalSales()
        {
            return DALStatistics.GetTotalSales();
        }

        public static List<Tuple<int, DocumentInfo>> TopSoldDocuments()
        {
            return DALStatistics.TopSoldDocuments();
        }

        public static Dictionary<string,int> GetVisitorCounter()
        {
            return DALStatistics.GetVisitorCounter();
        }
        
        public static List<int> GetSalesPerMonth(string DocumentType)
        {
            return DALStatistics.GetSalesPerMonth(DocumentType);
        }
        
        public static int GetTotalUserType(string type)
        {
            return DALStatistics.GetTotalUserType(type);
        }
        
        public static Statistics StatisticsApi()
        {
            var statstics = new Statistics()
            {
                TotalUsers = GetTotalUsers(),
                TodayUsers = GetTodayUsers(),
                TotalDocuments = GetTotalDocuments(),
                TotalSales = GetTotalSales(),
                TodaySales = GetTodaySales(),
                TopDocuments = TopSoldDocuments(),
                SalesByMonthEbook = GetSalesPerMonth("Ebook"),
                SalesByMonthEjournal = GetSalesPerMonth("Ejournal"),
                TotalEditors = GetTotalUserType("Editor"),
                TotalOrganizations = GetTotalUserType("Organization"),
                TotalIndividuals = GetTotalUserType("Individual"),
                VisitorCounter = GetVisitorCounter(),


            };
            return statstics;
        }
    }
}