package cn.appsys.controller.developer;

import javax.annotation.Resource;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import cn.appsys.pojo.DevUser;
import cn.appsys.service.developer.DevUserService;
@Controller
public class appUserAddController {
	@Resource
	private DevUserService devUserService;
	
	@RequestMapping("/appReg")
	public String reg() {
		System.out.println("================注册跳转ok");
		return "appUserReg";
	}
	
	
	@RequestMapping(value="/addUserInfo",method=RequestMethod.POST)
	public String regUser(String kuserCodeadd,String kuserNameadd,String kuserPasswordadd,String kuserEmailadd,String kuserInfoadd
			){
		DevUser devUser = new DevUser();
		devUser.setDevCode(kuserCodeadd);
		devUser.setDevName(kuserNameadd);
		devUser.setDevPassword(kuserPasswordadd);
		devUser.setDevEmail(kuserEmailadd);
		devUser.setDevInfo(kuserInfoadd);
		System.out.println("123-----------");
		int row= 0 ;
		try {
			
			row = devUserService.addUser(devUser);
			System.out.println("添加成功");
			
	} catch (Exception e) {
		// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		if(row>0) {
			System.out.println("------ add user is ok ------");
			return "redirect:dev/login";
		}else {
			return "appUserReg";
		}
		
		
		
		
	}

}
