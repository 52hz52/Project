package com.msg.Servlet;

import java.io.IOException;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import com.msg.dao.UserDao;
import com.msg.entity.Message;
import com.msg.entity.User;

/**
 * Servlet implementation class delMsg
 */
@WebServlet("/delMsg")
public class delMsg extends HttpServlet {
	UserDao userdao = new UserDao();
	List<Message> arrayMsgs;
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doPost(request, response);
	}
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String i = request.getParameter("id");
		int id = Integer.parseInt(i);
		int row = userdao.deleteMsg(id);
		
		if(row>0) {
					
			response.sendRedirect("providerAdmin.jsp");
			
			HttpSession session = request.getSession();
			User user = (User)session.getAttribute("loginUser");
			UserDao userdao = new UserDao();
			System.out.println("username======"+user.getUsername());
			arrayMsgs = userdao.selectMsg(user.getUsername());
		}
		
		
	

	}

}
