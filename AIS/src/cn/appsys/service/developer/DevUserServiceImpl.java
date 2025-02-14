package cn.appsys.service.developer;

import javax.annotation.Resource;
import org.springframework.stereotype.Service;

import cn.appsys.dao.devuser.DevUserMapper;
import cn.appsys.pojo.DevUser;

@Service
public class DevUserServiceImpl implements DevUserService {
	@Resource
	private DevUserMapper mapper;
	
	public DevUserMapper getMapper() {
		return mapper;
	}
	public void setMapper(DevUserMapper mapper) {
		this.mapper = mapper;
	}
	@Override
	public DevUser login(String devCode, String devPassword) throws Exception {
		// TODO Auto-generated method stub
		DevUser user = null;
		user = mapper.getLoginUser(devCode);
		//匹配密码
		if(null != user){
			if(!user.getDevPassword().equals(devPassword))
				user = null;
		}
		return user;
	}
	@Override
	public DevUser UserInfo(String devCode) throws Exception {
		// TODO Auto-generated method stub
		return mapper.getLoginUser(devCode);
	}
	@Override
	public int updateUserinfo(DevUser devUser) throws Exception {
		// TODO Auto-generated method stub
		return mapper.updateUserInfo(devUser);
	}
	@Override
	public int addUser(DevUser devUser) throws Exception {
		// TODO Auto-generated method stub
		return mapper.insertUser(devUser);
	}

}
