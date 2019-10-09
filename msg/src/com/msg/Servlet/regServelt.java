package com.msg.Servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.msg.dao.UserDao;
import com.msg.entity.User;
import com.msg.service.UserService;

@WebServlet("/doreg")
public class regServelt extends HttpServlet{
  
	
	@Override
	protected void doGet(HttpServletRequest request, HttpServletResponse response ) throws ServletException, IOException {
		response.setCharacterEncoding("UTF-8");
		request.setCharacterEncoding("UTF-8");
		response.setContentType("text/html; charset=UTF-8");
		HttpSession session = request.getSession(true);
		String username =  request.getParameter("username");
		String password =  request.getParameter("password");
		String email  = request.getParameter("email");	
		//
		UserService us = new UserService();

		int rows = us.register(new User(null,username,password,email));
		if(rows>0){
			session.setAttribute("reginfo", "注册成功");
			response.sendRedirect("login.jsp");
		}else{
			session.setAttribute("reginfo", "注册失败");
			response.sendRedirect("userAdd.jsp");
		}
		
	}
	
	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse resp) throws ServletException, IOException {
		doGet(req, resp);
	}
	
}
