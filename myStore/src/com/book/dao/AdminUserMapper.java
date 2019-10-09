package com.book.dao;

import java.util.List;

import org.apache.ibatis.annotations.Param;

import com.book.entity.Admin_user;
import com.book.entity.User;

public interface AdminUserMapper {
	
//	登录
	public Admin_user selectAdminUser(Admin_user admin_user);
	
//	更新admin 信息
	public int updateAdminUserInfo(Admin_user admin_user);
	
//	查找所有user用户
	public List<User> selectAllUser();
	
//	查找在线用户数量
	public int selectUserStateNum(@Param("state")Integer state);

}
