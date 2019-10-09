package com.msg.Servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.msg.dao.UserDao;

/**
 * Servlet implementation class contServlet
 */
@WebServlet("/contServlet")
public class contServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public contServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		UserDao userdao = new UserDao();
		String sendto = request.getParameter("sendto");
		String cont = request.getParameter("cont");
		request.setAttribute("userdao", userdao);
	    int i = userdao.UpdateState(sendto,cont);
	    if(i>0) {	    	
	    	request.getRequestDispatcher("contentMsg.jsp").forward(request, response);
	    }
	 
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
