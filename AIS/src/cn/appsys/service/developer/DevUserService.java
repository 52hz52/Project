package cn.appsys.service.developer;

import cn.appsys.pojo.DevUser;

public interface DevUserService {
	/**
	 * 用户登录
	 * @param devCode
	 * @param devPassword
	 * @return
	 */
	public DevUser login(String devCode,String devPassword) throws Exception;
	
	public DevUser UserInfo(String devCode) throws Exception;
	
	public int updateUserinfo(DevUser devUser) throws Exception;
	
	public int addUser(DevUser devUser) throws Exception;
	
}
