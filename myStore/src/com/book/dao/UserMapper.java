package com.book.dao;

import org.apache.ibatis.annotations.Param;

import com.book.entity.User;

public interface UserMapper {
	
	
	//�����û�
	public User selectUser(User user);
	
	//����û�
	public int insertUser(User user);
	
	//�����û���Ϣ
	public int updateUserInfo(User user);
	
	
	
	
}
