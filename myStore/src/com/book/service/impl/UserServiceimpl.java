package com.book.service.impl;
import javax.annotation.Resource;
import org.springframework.stereotype.Service;

import com.book.dao.UserMapper;
import com.book.entity.User;
import com.book.service.UserService;
@Service("UserService")
public class UserServiceimpl implements UserService {
	
	@Resource
	private UserMapper UserDaoMapper;

	@Override // String name, String password,String email , String phone
	public User LoginUser(User user) {
		// TODO Auto-generated method stub
		return UserDaoMapper.selectUser(user);
	}

	@Override
	public int RegUser(User user) {
		// TODO Auto-generated method stub
		return UserDaoMapper.insertUser(user);
	}

	@Override
	public int updateUser(User user) {
		// TODO Auto-generated method stub
		return UserDaoMapper.updateUserInfo(user);
	}

}
