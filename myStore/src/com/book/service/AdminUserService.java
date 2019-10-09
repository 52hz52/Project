package com.book.service;

import java.util.List;

import com.book.entity.Admin_user;
import com.book.entity.User;

/**
 * @author 17683
 * admin 
 * 2019-09-21
 *
 */
public interface AdminUserService {
	
	public Admin_user adminLogin(Admin_user admin_user);
	
	public int updateAdmin(Admin_user admin_user);
	
	public List<User> getAllUser();

	public int getUserStateNum(int state);
	
}
