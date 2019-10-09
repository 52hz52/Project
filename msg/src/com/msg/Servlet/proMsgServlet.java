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
 * Servlet implementation class proMsgServlet
 */
@WebServlet("/proMsgServlet")
public class proMsgServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
    private static List<Message> arrayMsgs;
    /**
     * @see HttpServlet#HttpServlet()
     */
    public proMsgServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//		System.out.println("23232");
			HttpSession session = request.getSession();
			User user = (User)session.getAttribute("loginUser");
			UserDao userdao = new UserDao();
			System.out.println("username======"+user.getUsername());
			arrayMsgs = userdao.selectMsg(user.getUsername()); // 登陆账号的人接收消息
		//	System.out.println(arrayMsgs);
			request.setAttribute("arrayMsgs", arrayMsgs);
		//	response.sendRedirect("providerAdmin.jsp");
			request.getRequestDispatcher("providerAdmin.jsp").forward(request, response);
		//	System.out.println("weq");
			/*	for(Message m: arrayMsgs) {
					System.out.println(m.getState()+"===="+m.getTitle());
				}*/
				// 转发
	
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
