package com.book.service.impl;

import java.util.List;

import javax.annotation.Resource;

import org.springframework.stereotype.Service;

import com.book.dao.AdminUserMapper;
import com.book.entity.Admin_user;
import com.book.entity.User;
import com.book.service.AdminUserService;

@Service("AdminUserService")
public class AdminUserServiceImpl implements AdminUserService {
	
	
	@Resource
	private AdminUserMapper AdminUserMapper;

	@Override
	public Admin_user adminLogin(Admin_user admin_user) {
		// TODO Auto-generated method stub
		return AdminUserMapper.selectAdminUser(admin_user);
	}

	@Override
	public int updateAdmin(Admin_user admin_user) {
		// TODO Auto-generated method stub
		return AdminUserMapper.updateAdminUserInfo(admin_user);
	}

	@Override
	public List<User> getAllUser() {
		// TODO Auto-generated method stub
		return AdminUserMapper.selectAllUser();
	}

	@Override
	public int getUserStateNum(int state) {
		// TODO Auto-generated method stub
		return AdminUserMapper.selectUserStateNum(state);
	}

}
