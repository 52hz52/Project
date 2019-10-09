package com.msg.dao;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

import com.msg.entity.Message;
import com.msg.entity.User;

public class UserDao extends BaseDao {
	
	Connection conn = null;
	PreparedStatement pstat = null;
	ResultSet res = null;
	
	
	//插入用户
	public int insertUser(User user) {
		int rows = 0;
		conn = getConnection();
		String sql = "insert into msg_userinfo(`username`,`password`,`email`)" + 
				"values(?,?,?)";
		try {
			pstat = conn.prepareStatement(sql);
			pstat.setString(1, user.getUsername());
			pstat.setString(2, user.getPassword());
			pstat.setString(3, user.getEmail());
			rows = pstat.executeUpdate(); //执行增加，删除，修改
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			closeAll(null, pstat, conn);
		}
		return rows;
	}
	
	
	//查找用户
	public User selectUser(User condition) {
		User user = null;
		conn = getConnection();
		String sql = "select * from msg_userinfo where username = ? and password = ?";
		try {
			pstat = conn.prepareStatement(sql);
			pstat.setString(1, condition.getUsername());
			pstat.setString(2, condition.getPassword());
			res = pstat.executeQuery(); //执行查询
			if(res.next()) {
				user = new User(res.getInt("uid"),
						res.getString("username"), 
						res.getString("password"), 
						res.getString("email"));
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			closeAll(res, pstat, conn);
		}
		
		return user;
	}
	
	// 发送消息
	public int insertMsg(Message message) {
		int row = 0;
		conn = getConnection();
		String sql = "insert into msg(username,title,msgcontent,state,sendto)"
				+ " VALUES (?,?,?,?,? )";
		try {
			pstat = conn.prepareStatement(sql);
			pstat.setString(1, message.getUsername());
			pstat.setString(2, message.getTitle());
			pstat.setString(3, message.getMsgcontent());
			pstat.setInt(4, message.getState());
			pstat.setString(5, message.getSendto());
			row = pstat.executeUpdate();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}finally {
			closeAll(res, pstat, conn);
		}	
		return row ;
	}
	
	//接收消息
	public List<Message> selectMsg(String name ) {
		List<Message> listMsg = new ArrayList<>();
		Message mess = null;
		conn = getConnection();
		String sql = "select * from msg where sendto = ? ";
		try {
			pstat = conn.prepareStatement(sql);
			pstat.setString(1, name);
			res = pstat.executeQuery(); //执行查询
			while(res.next()) {
				mess = new Message(res.getInt("msgid"),res.getString("username"),
						res.getString("title"),res.getString("msgcontent"),
						res.getInt("state"),res.getString("sendto"),res.getTimestamp("msgCreateDate"));
				listMsg.add(mess);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			closeAll(res, pstat, conn);
		}
		
		return listMsg;
	}

	//修改 state 状态 已读为0
	public int UpdateState(String Sendto , String Msgcontent) {
		conn = getConnection();
		int row = 0 ;
		String sql = "UPDATE msg set state = ? where sendto = ? and msgcontent = ? ";
		try {
			pstat = conn.prepareStatement(sql);
			pstat.setInt(1, 0);
			pstat.setString(2,Sendto);
			pstat.setString(3,Msgcontent);
			row = pstat.executeUpdate();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}finally {
			closeAll(null, pstat, conn);
		}
		return row;
	}
	
	//所有用户
	public List<User> selectUsers() {
		List<User> listUsers = new ArrayList<>();
		User user = null;
		conn = getConnection();
		String sql = "select * from msg_userinfo ";
		try {
			pstat = conn.prepareStatement(sql);
			res = pstat.executeQuery(); //执行查询
			while(res.next()) {
				user = new User(res.getInt("uid"),
						res.getString("username"), 
						res.getString("password"), 
						res.getString("email"));
				listUsers.add(user);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} finally {
			closeAll(res, pstat, conn);
		}
		
		return listUsers;
	}
	
	//已发消息
		public List<Message> selectAllMsg(String name) {
			List<Message> listMsg = new ArrayList<>();
			Message mess = null;
			conn = getConnection();
			String sql = "select * from msg where username = ? ";
			try {
				pstat = conn.prepareStatement(sql);
				pstat.setString(1, name);
				res = pstat.executeQuery(); //执行查询
				while(res.next()) {
					mess = new Message(res.getInt("msgid"),res.getString("username"),
							res.getString("title"),res.getString("msgcontent"),
							res.getInt("state"),res.getString("sendto"),res.getTimestamp("msgCreateDate"));
					listMsg.add(mess);
				}
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} finally {
				closeAll(res, pstat, conn);
			}
			
			return listMsg;
		}
		
	//删除消息
/*		uuid=a 数据库的id字段

				system_option 表明

				delete from system_option where uuid = a

				update system_option set uuid = uuid-1 where uuid > a*/
		public int deleteMsg(int msgid) {
			conn = getConnection();
			PreparedStatement pstat1 = null;
			int row = 0 ;
			String sql = "delete from msg where msgid = ? ";
			String sql1 = " update msg set msgid = msgid-1 where msgid > ? ";
			try {
				pstat = conn.prepareStatement(sql);
				pstat1 = conn.prepareStatement(sql1);
				pstat.setInt(1, msgid);
				pstat1.setInt(1, msgid);
				row = pstat.executeUpdate();
				pstat1.executeUpdate();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}finally {
				closeAll(null, pstat, conn);
			}
			return row;
		
		}
		
	
	/*public static void main(String[] args) {
		int m = new UserDao().deleteMsg(2);
		System.out.println(m);
	}*/
}




