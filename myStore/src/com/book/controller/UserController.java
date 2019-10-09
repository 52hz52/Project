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
	
//	�˳� 
	@RequestMapping("exitLogin")
	public String exitLogin(HttpSession session,HttpServletRequest request) {
		
		
		String nameString = request.getParameter("name");
		User user = new User();
		user.setName(nameString);
		user.setState(1);
		User user2 = userService.LoginUser(user);
//		ͨ��id�������û�
		user.setId(user2.getId());
//	�����û�״̬
	    userService.updateUser(user);
		
		session.removeAttribute("user");
		return "redirect:login.jsp";
	}
	
	
//	��¼
	@RequestMapping(value="/tologin",method = RequestMethod.POST)
	public String login(String name , String password,Model model,HttpServletRequest request) {
		HttpSession session = request.getSession();
		
		User u = new User();
		
//	    ��֤���ֻ���
		String phone = "^((13[0-9])|(15[^4,\\D])|(17[0-9])|(18[0,5-9]))\\d{8}$";
//		����
		String email = "^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
		
		System.out.println("�Ƿ��ֻ���:=== "+name.matches(phone));
		
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
		
//		�����û�  �õ��û�״̬
		User us =  userService.LoginUser(u);
	
//		��¼
		User user = null;
		
		System.out.println("�û�״̬:=====>  "+us.getState());
		
//		�û����ѵ�¼ �ͷ���  ���ܵ�¼
		if(us.getState()==1) {
//			��¼�ɹ�  ���� ״̬   ==> 2 ����     1 ������
			u.setState(2);
			user = userService.LoginUser(u);
			u.setId(user.getId());
//			�����û�״̬
			int row = userService.updateUser(u);
			if(row>0) {
				System.out.println("�޸��û�״̬�ɹ�...");
			}else {
				System.out.println("�޸�ʧ��...");
			}
			
			
			if(null!=user) {
				System.out.println("��¼�ɹ�");

				session.setAttribute("user", user);
				return "redirect:/ findbook?id=1";
				
			}else {
				System.out.println("��¼ʧ��");
				return "redirect:login.jsp";
			}	
	
		}else {
			System.out.println("�û��ѵ�¼...");
			return "redirect:error";
		//	return JavaScript("alert('��֤ʧ�ܣ�)");
		}
	
	}
	
//	ע��
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
			System.out.println("------ ע��ɹ�  ------");
			return "User/index";
		}else {
			System.out.println("------ ע��ʧ��  ------");
			return "../reg";
		}
		
	}
	
	
//	������Ʒ����ҳ
	@RequestMapping(value = "/Product")
	public String toProduct() {

		
		return "User/Product";
	}
	
//	�û�������Ϣ
	@RequestMapping("UserInfo")
	public String UserInfo(Model model,HttpServletRequest request) {
		
		String username = request.getParameter("username");
		
		User us = new User();
		us.setName(username);
		
		User u_info = userService.LoginUser(us);
		
		model.addAttribute("u_info", u_info);
		
		return "User/userInfo";
	}
	
//	������Ϣ
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
