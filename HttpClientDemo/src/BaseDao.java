
import java.io.IOException;
import java.sql.*;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Properties;


public class BaseDao {
	
	private static String DRIVER;
	private static String URL;
	private static String USER;
	private static String PWD;
	
	static {
		Properties prop = new Properties();
		try {
			prop.load(BaseDao.class.getResourceAsStream("db.properties"));
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		DRIVER = prop.getProperty("DRIVER");
		URL = prop.getProperty("URL");
		USER = prop.getProperty("USER");
		PWD = prop.getProperty("PWD");
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
	
	//1.ִ������ɾ����
	public int executeNonQuery(String sql,Object...params) {
		int rows = 0;
		Connection conn = null;
		PreparedStatement pstmt = null;
		conn = getConnection();
		try {
			pstmt = conn.prepareStatement(sql);
			for(int i=0;i<params.length;i++) {
				pstmt.setObject(i+1, params[i]);
			}
			rows = pstmt.executeUpdate(); //ִ�����ӣ�ɾ�����޸�
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			closeAll(null, pstmt, conn);
		}
		return rows;
	}
	
	public List<Map<String, Object>> executeSelect(String sql,Object...params) {
		List<Map<String, Object>> dataRows = new ArrayList<>();
		Map<String, Object> row = null;
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet res = null;
		conn = getConnection();
	
		try {
			pstmt = conn.prepareStatement(sql);
			for (int i = 0; i < params.length; i++) {
				pstmt.setObject(i+1, params[i]);
			}
			res = pstmt.executeQuery(); //ִ�в�ѯ
			
			//�õ�������� Ԫ���� = �������ݵ�����
			ResultSetMetaData md =  res.getMetaData();
			int colCount = md.getColumnCount();
			
			while(res.next()) {
				row = new HashMap<>(); //����һ������
				//Ϊһ��������� k-v  keyΪ����    v = ĳ��ĳ�е�ֵ
 				for(int cindex = 1;cindex <= colCount;cindex++) {
					String colName = md.getColumnName(cindex);
					row.put(colName, res.getObject(colName));
				}
				
				dataRows.add(row); //��һ��������ӵ�������
			}

		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			closeAll(res, pstmt, conn);//�ر�
		}	
		return dataRows;
	}
	
	
	public static void main(String[] args) {
		System.out.println(new BaseDao().getConnection());
	}

}
