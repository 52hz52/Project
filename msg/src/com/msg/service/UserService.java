package com.msg.service;

import com.msg.dao.UserDao;
import com.msg.entity.User;

public class UserService {
	
	private UserDao userDao = new UserDao(); // ���������ݷ��ʲ�Ķ���
	
	//ע��
	public int register(User user) {
		return userDao.insertUser(user);
	}

	//��¼
	public User login(String username,String password) {
		return userDao.selectUser(new User(null,username,password,null));
	}
	
}
