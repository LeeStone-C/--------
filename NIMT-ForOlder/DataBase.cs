using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NIMT_ForOlder
{
     public class DataBase
    {
        /**
  * Data Source：应用程序连接数据库服务器的名称或IP地址./(local)/127.0.0.1
  * Initial Catalog：所需连接的数据库名称
  * User ID：登录数据库所需的用户名
  * Pwd：登录数据库所需的用户名的密码
  */

        //负责连接数据库   
        static string conn = "Data Source=.;Initial Catalog=YangLaoFuWu;User ID=sa;Pwd=123456";
        //负责对数据库执行命令(SQL语句)
        private SqlConnection connection = new SqlConnection(conn);
        //负责从数据源读取数据    
        private SqlCommand command = null;
        //负责数据集和数据源之间的联系
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = null;
        //独立存放数据源的数据
        private DataSet ds = null;

        /// <summary>
        /// 打开数据库连接代码
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                connection.Open();//打开数据库连接 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);//打印输出异常信息
            }
        }

        /// <summary>
        /// 关闭数据库连接代码
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                if (reader != null)
                {
                    reader.Close();//关闭DataReader对象 reader对象和connection是先打开的后关闭
                }
                if (connection != null)
                {
                    connection.Close();//关闭与数据库之间的连接
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);//打印输出异常信息
            }
        }

        /// <summary>
        /// 执行新增，删除，修改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int IDU(string sql)
        {
            int result = -1;
            try
            {
                this.OpenConnection();
                command = new SqlCommand(sql, connection);
                result = command.ExecuteNonQuery();
                this.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;

        }

        public int Aggregate(string sql)
        {
            int result = -1;
            try
            {
                this.OpenConnection();
                command = new SqlCommand(sql, connection);
                result = (int)command.ExecuteScalar();
                this.CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        /// <summary>
        /// 执行连接式查询
        /// </summary>
        /// <param name="sql">所执行的SQL语句</param>
        /// <returns>DataReader对象</returns>
        public SqlDataReader GetList(string sql)
        {
            try
            {
                this.OpenConnection();
                command = new SqlCommand(sql, connection);
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return reader;
        }

        /// <summary>
        /// 断开式查询
        /// </summary>
        /// <param name="sql">所需执行的SQL语句</param>
        /// <returns>DataSet对象</returns>
        public DataSet GetQuery(string sql)
        {
            try
            {
                ds = new DataSet();
                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(ds, "Info");//Info为临时虚拟表名可自定义
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ds;
        }
    }
}
