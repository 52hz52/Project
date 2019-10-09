package com.msg.Servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.msg.dao.UserDao;
import com.msg.entity.User;

/**
 * Servlet implementation class loginOkServlet
 */
@WebServlet("/loginOkServlet")
public class loginOkServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public loginOkServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//String username =  request.getParameter("username");
		
     PrintWriter out = response.getWriter();
		 
		 
     String username =  request.getParameter("u");//ÓÃ»§Ãû
		 UserDao userdao = new UserDao();
			List<User> users =  userdao.selectUsers();
			for(User uname:users) {
				System.out.println(uname.getUsername());
				System.out.println("username==="+username);
		
			if(uname.getUsername().equals(username)) {		
					out.println(1);
				}
			}
			
			out.flush();
			out.close();
		 
		
		
		
		
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
