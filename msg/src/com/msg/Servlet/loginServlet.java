package com.msg.Servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;

import javax.jws.WebService;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.msg.dao.UserDao;
import com.msg.entity.Message;
import com.msg.entity.User;
import com.msg.service.UserService;

@WebServlet("/dologin")
public class loginServlet extends HttpServlet {

	@Override
	protected void doGet(HttpServletRequest request, HttpServletResponse response ) throws ServletException, IOException {
		response.setCharacterEncoding("UTF-8");
		request.setCharacterEncoding("UTF-8");
		response.setContentType("text/html; charset=UTF-8");
		HttpSession session = request.getSession(true);
		 String username =  request.getParameter("userName");//用户名
		 String password =  request.getParameter("passWord");
		 
		 // 查找用户返回集合 保存ssession
		 UserDao userdao = new UserDao();
		 List<User> listuser = userdao .selectUsers();
		  session.setAttribute("listuser", listuser);
		 
		 
		  
		 UserService us = new UserService();
		 User user = us.login(username, password);
		 if(user!=null){
			 session.setAttribute("loginUser", user);
		 	 response.sendRedirect("admin_index.jsp");
		 	 
		 } else {
			 response.sendRedirect("login.jsp");
		 }
		 
		// 查看所以消息 保存session
		  List<Message> listMsg = userdao.selectAllMsg(user.getUsername());
		  session.setAttribute("listMsg", listMsg);
	}
	
	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		doGet(req, resp);
	}
}
