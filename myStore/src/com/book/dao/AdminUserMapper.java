package com.book.dao;

import java.util.List;

import org.apache.ibatis.annotations.Param;

import com.book.entity.Admin_user;
import com.book.entity.User;

public interface AdminUserMapper {
	
//	��¼
	public Admin_user selectAdminUser(Admin_user admin_user);
	
//	����admin ��Ϣ
	public int updateAdminUserInfo(Admin_user admin_user);
	
//	��������user�û�
	public List<User> selectAllUser();
	
//	���������û�����
	public int selectUserStateNum(@Param("state")Integer state);

}
