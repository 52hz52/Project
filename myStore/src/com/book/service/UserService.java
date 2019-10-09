package com.book.service;

import com.book.entity.User;

public interface UserService {
	
	
//	用户登录
	public User LoginUser(User user);
//	用户注册
	public int RegUser(User user);
//	更新用户信息
	public int updateUser(User user);
	
}
