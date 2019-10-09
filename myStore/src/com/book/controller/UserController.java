package com.book.controller;

import javax.annotation.Resource;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.book.entity.User;
import com.book.service.UserService;

@Controller
public class UserController {

	
	@Resource
	private UserService userService;
	
	@RequestMapping("error")
	public String Error() {
		return "404";
	}
	
//	退出 
	@RequestMapping("exitLogin")
	public String exitLogin(HttpSession session,HttpServletRequest request) {
		
		
		String nameString = request.getParameter("name");
		User user = new User();
		user.setName(nameString);
		user.setState(1);
		User user2 = userService.LoginUser(user);
//		通过id来更新用户
		user.setId(user2.getId());
//	更新用户状态
	    userService.updateUser(user);
		
		session.removeAttribute("user");
		return "redirect:login.jsp";
	}
	
	
//	登录
	@RequestMapping(value="/tologin",method = RequestMethod.POST)
	public String login(String name , String password,Model model,HttpServletRequest request) {
		HttpSession session = request.getSession();
		
		User u = new User();
		
//	    验证是手机号
		String phone = "^((13[0-9])|(15[^4,\\D])|(17[0-9])|(18[0,5-9]))\\d{8}$";
//		邮箱
		String email = "^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
		
		System.out.println("是否手机号:=== "+name.matches(phone));
		
		if(name.matches(phone)) {
			u.setPhone(name);
		}
		else if(name.matches(email)) {
			u.setEmail(name);
		}
		else {
			u.setName(name);
		}
		System.out.println("name:"+name+"  password:"+password);
	
		u.setPassword(password);
		
//		查找用户  得到用户状态
		User us =  userService.LoginUser(u);
	
//		登录
		User user = null;
		
		System.out.println("用户状态:=====>  "+us.getState());
		
//		用户若已登录 就返回  不能登录
		if(us.getState()==1) {
//			登录成功  设置 状态   ==> 2 在线     1 不在线
			u.setState(2);
			user = userService.LoginUser(u);
			u.setId(user.getId());
//			设置用户状态
			int row = userService.updateUser(u);
			if(row>0) {
				System.out.println("修改用户状态成功...");
			}else {
				System.out.println("修改失败...");
			}
			
			
			if(null!=user) {
				System.out.println("登录成功");

				session.setAttribute("user", user);
				return "redirect:/ findbook?id=1";
				
			}else {
				System.out.println("登录失败");
				return "redirect:login.jsp";
			}	
	
		}else {
			System.out.println("用户已登录...");
			return "redirect:error";
		//	return JavaScript("alert('验证失败！)");
		}
	
	}
	
//	注册
	@RequestMapping(value ="/toReg",method = RequestMethod.POST)
	public String Reg(String name ,String phone ,String Email , String password,Model model) {
		System.out.println("name:"+name+"  password:"+password);
		User user = new User();
		user.setName(name);
		user.setPhone(phone);
		user.setEmail(Email);
		user.setPassword(password);
		int row  = userService.RegUser(user);
		System.out.println("row======>  "+row);
		if(row>0) {
			System.out.println("------ 注册成功  ------");
			return "User/index";
		}else {
			System.out.println("------ 注册失败  ------");
			return "../reg";
		}
		
	}
	
	
//	进入商品详情页
	@RequestMapping(value = "/Product")
	public String toProduct() {

		
		return "User/Product";
	}
	
//	用户基本信息
	@RequestMapping("UserInfo")
	public String UserInfo(Model model,HttpServletRequest request) {
		
		String username = request.getParameter("username");
		
		User us = new User();
		us.setName(username);
		
		User u_info = userService.LoginUser(us);
		
		model.addAttribute("u_info", u_info);
		
		return "User/userInfo";
	}
	
//	更新信息
	@RequestMapping(value = "/updateUserINFO" , method = RequestMethod.POST)
	public String updateUser(String id ,String name,String email ,String phone,String password,String address,Model model,HttpServletRequest request) {
		
		User u = new User();
		System.out.println("id ==============> "+id +"   "+ address);
		int nid = Integer.parseInt(id);
		u.setId(nid);
		u.setName(name);
		u.setEmail(email);
		u.setPhone(phone);
		u.setPassword(password);
		u.setAddress(address);
		userService.updateUser(u);
		
		return "redirect:/ findbook?id=1";
	}
	
	
	
}
