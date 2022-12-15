using Dapper;
using MySqlConnector;
using QL.MUSIC.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.MUSIC.DL
{
    public class AdminAcoountDl : BaseDL<adminaccount>, IAdminAccountDL
    {
        public PagingData<adminaccount> FilterAdminAccounts(PagingSong pagingSong)
        {
            // Chuẩn bị tham số đầu vào cho procedure
            var parameters = new DynamicParameters();
            parameters.Add("v_Offset", (pagingSong.page - 1) * pagingSong.limit);
            parameters.Add("v_Limit", pagingSong.limit);
            parameters.Add("v_Sort", "");

            var whereConditions = new List<string>();
            var listDepartmentId = new List<string>();
            var listCategoryId = new List<string>();
            if (pagingSong.keyword != null) whereConditions.Add($" accountName LIKE \'%{pagingSong.keyword}%\' ");

            string whereClause = string.Join(" AND ", whereConditions);

            parameters.Add("v_Where", whereClause);

            // Khai báo tên prodecure Insert
            string storedProcedureName = "Proc_adminaccount_GetPaging";

            // Khởi tạo kết nối tới DB MySQL
            string connectionString = DataContext.MySqlConnectionString;
            var filterResponse = new PagingData<adminaccount>();
            using (var mysqlConnection = new MySqlConnection(connectionString))
            {
                // Thực hiện gọi vào DB để chạy procedure
                var multiAssets = mysqlConnection.QueryMultiple(storedProcedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);

                // Xử lý dữ liệu trả về
                var assets = multiAssets.Read<adminaccount>();
                var totalCount = multiAssets.Read<long>().Single();

                filterResponse = new PagingData<adminaccount>(assets, totalCount);
            }

            return filterResponse;
        }
    }
}
