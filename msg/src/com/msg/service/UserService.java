package com.msg.service;

import com.msg.dao.UserDao;
import com.msg.entity.User;

public class UserService {
	
	private UserDao userDao = new UserDao(); // 依赖于数据访问层的对象
	
	//注册
	public int register(User user) {
		return userDao.insertUser(user);
	}

	//登录
	public User login(String username,String password) {
		return userDao.selectUser(new User(null,username,password,null));
	}
	
}
