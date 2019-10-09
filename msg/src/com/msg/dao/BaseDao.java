package com.msg.dao;

import java.io.IOException;
import java.sql.*;
import java.util.Properties;


public class BaseDao {
	
	private static String DRIVER; 
	private static String URL;
	private static String USER;
	private static String PWD;
	
	static {
		Properties pro = new Properties();
		try {
			pro.load(BaseDao.class.getResourceAsStream("db.properties"));
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		DRIVER = pro.getProperty("DRIVER");
		URL = pro.getProperty("URL");
		USER = pro.getProperty("USER");
		PWD = pro.getProperty("PWD");
		
	}
	
	public Connection getConnection() {
		Connection conn = null;
		try {
			Class.forName(DRIVER);
			conn = DriverManager.getConnection(URL, USER, PWD);
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return conn;
	}
	
	
	public void closeAll(ResultSet res,PreparedStatement pstmt,Connection conn) {
		try {
			if(res!=null) {
				res.close();
			}
			
			if(pstmt!=null) {
				pstmt.close();
			}
			
			if(conn!=null) {
				conn.close();
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	/*public static void main(String[] args) {
		System.out.println(new BaseDao().getConnection());
	}
*/
}
