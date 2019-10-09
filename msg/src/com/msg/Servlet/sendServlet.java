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
 * Servlet implementation class sendServlet
 */
@WebServlet("/sendServlet")
public class sendServlet extends HttpServlet {
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		int ro = 0;
		HttpSession session = request.getSession();
		User user = (User)session.getAttribute("loginUser");
		String sendto =  request.getParameter("sendto");
		String title = request.getParameter("send_title");
		String send_con = request.getParameter("send_content");

//			1,user.getUsername(),title,send_con,1,sendto,null
		UserDao userdao = new  UserDao();
			Message ms = new Message();
			ms.setTitle(title);
			ms.setUsername(user.getUsername());
			ms.setMsgcontent(send_con);
			ms.setState(1);
			ms.setSendto(sendto);
			ms.setMsgCreateDate(null);
		    ro = userdao.insertMsg(ms);
		    String row = ro+"";
		    
			if(ro>0) {		 	
				 session.setAttribute("row_s", row);
				 response.sendRedirect("admin_bill_list.jsp");
			}
			else{
				session.setAttribute("row_s", null);
				System.out.println("n-u-l-l");
				response.sendRedirect("admin_bill_list.jsp");
			}
	}
	
	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		doGet(request, response);
	}

}
