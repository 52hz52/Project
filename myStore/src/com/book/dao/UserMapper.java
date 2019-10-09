package com.book.dao;

import org.apache.ibatis.annotations.Param;

import com.book.entity.User;

public interface UserMapper {
	
	
	//查找用户
	public User selectUser(User user);
	
	//添加用户
	public int insertUser(User user);
	
	//更新用户信息
	public int updateUserInfo(User user);
	
	
	
	
}
