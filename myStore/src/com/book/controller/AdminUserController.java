package com.book.controller;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

import javax.annotation.Resource;
import javax.servlet.ServletContext;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.context.ContextLoader;
import org.springframework.web.context.WebApplicationContext;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.multipart.MultipartHttpServletRequest;

import com.book.entity.Admin_user;
import com.book.entity.User;
import com.book.entity.book_info;
import com.book.service.AdminUserService;
import com.book.service.bookService;

@Controller
public class AdminUserController {
	
	@Resource
	private AdminUserService adminUserService;
	
	@Resource
	private bookService bookService;
	
//	load 添加书籍页面
	@RequestMapping("addbook")
	public String addbook() {
		return "Admin/AddBookinfos";
	}
	
	
//	添加书籍信息  表单提交  上传文件==>书籍图片
	@RequestMapping(value = "/addBookinfo",method = RequestMethod.POST)
    public String upload(HttpServletRequest req,book_info book_info) throws Exception{
        MultipartHttpServletRequest mreq = (MultipartHttpServletRequest)req;
        MultipartFile file = mreq.getFile("file");
        System.out.println("路径:"+file);
        String fileName = file.getOriginalFilename();
        SimpleDateFormat sdf = new SimpleDateFormat("yyyyMMddHHmmss");  
        
       
        System.out.println("========>"+req.getSession().getServletContext().getRealPath("/"));
        
        String pathString = req.getSession().getServletContext().getRealPath("/")+"statics/img/book_love/";
      
        String nameString = sdf.format(new Date())+fileName.substring(fileName.lastIndexOf('.'));
        System.out.println(nameString);
        
        FileOutputStream fos = new FileOutputStream(pathString+nameString);
        
        fos.write(file.getBytes());
        fos.flush();
        fos.close();
        
        book_info books = new book_info(book_info.getName(),"img/book_love/"+nameString, book_info.getAuthor(), book_info.getHouse(), 
        		book_info.getTime(), book_info.getBookinfo(), book_info.getPrice(),
        		book_info.getDisprice(), book_info.getBooktype(), book_info.getAttrbute());
        int row = bookService.setBookinfo(books);
		if(row>0) {
			 
			 System.out.println("添加书籍成功...");
		  // 保存文件地址 用户jsp页面显示 model.addAttribute("fileUrl", path+newfile); 
			    return	"Admin/AddBookinfos";
		 	} else { System.out.println("添加书籍失败..."); 
		 		return	"Admin/AdminIndex"; 
		 	
		 	}

        
     
    }

//	admin 首页     1,查找用户在线数量  问题 :不能即时刷新   2,
	@RequestMapping("adminIndex")
	public String adminIndex(HttpSession session) {
		
		User u = new User();
		u.setState(2);
		User u2 = new User();	
		
		int num = adminUserService.getUserStateNum(u.getState());
		int allnum = adminUserService.getUserStateNum(u2.getState());
		
		session.setAttribute("num", num);
		session.setAttribute("allnum", allnum);
		System.out.println("在线人数:=====>   "+num);
		System.out.println("用户总人数:=====>   "+allnum);
		
		return "Admin/AdminIndex";
	}
		
//	查找所有用户
	@RequestMapping("findAllUsers")
	public String findAllUsers(Model model,HttpServletRequest request) {
		
		//String idString =request.getParameter("id");
		
     	List<User> userList = adminUserService.getAllUser();
		
     	if(null!=userList) {
     		System.out.println("查找所有用户成功...");
     		model.addAttribute("userList", userList);
     		return "Admin/AllUsers";
     		
     	}else {
     		System.out.println("查找所有用户失败");
     		return "Admin/AllUsers";
		}
     	
		
		
	}
	
	
	
	
	
//	admin 登录
	@RequestMapping(value = "/AdminLogin" , method = RequestMethod.POST )
	public String AdminLogin(String adminname,String adminpassword , Model model,HttpServletRequest request) {
		
		
		HttpSession session = request.getSession();
		Admin_user admin_user = new Admin_user();
		admin_user.setA_password(adminpassword);
		
//	    验证是手机号
		String phone = "^((13[0-9])|(15[^4,\\D])|(17[0-9])|(18[0,5-9]))\\d{8}$";
//		邮箱
		String email = "^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
		
		System.out.println("是否手机号:=== "+adminname.matches(phone));
		
		if(adminname.matches(phone)) {
			admin_user.setA_phone(adminname);
		}
		else if(adminname.matches(email)) {
			admin_user.setA_email(adminname);
		}
		else {
			admin_user.setA_name(adminname);
		}
		System.out.println("adminName:"+adminname+"  adminPassword:"+adminpassword);
		
		Admin_user auser = adminUserService.adminLogin(admin_user);
		
		if(null!=auser) {
			System.out.println("admin 登录成功...");
			session.setAttribute("auser", auser);
			/*
			 * boolean res = out.println();
			 */
			return "redirect:adminIndex";
		}else {
			System.out.println("admin 登录失败...");
			return "redirect:AdminLogin.jsp";
		}

		
	}


}
