package com.book.service;

import com.book.entity.User;

public interface UserService {
	
	
//	�û���¼
	public User LoginUser(User user);
//	�û�ע��
	public int RegUser(User user);
//	�����û���Ϣ
	public int updateUser(User user);
	
}
