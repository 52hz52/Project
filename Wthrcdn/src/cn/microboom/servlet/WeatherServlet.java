package cn.microboom.servlet;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.websocket.Session;

import com.alibaba.fastjson.JSON;
import com.alibaba.fastjson.JSONArray;
import com.alibaba.fastjson.JSONObject;

import cn.microboom.entity.Forecast;
import cn.microboom.entity.ToDay;
import cn.microboom.tool.HttpURLConnectionTool;
import cn.microboom.tool.PicTool;

/**
 * Servlet implementation class WeatherServlet
 */
@WebServlet("/WeatherServlet")
public class WeatherServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public WeatherServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	/* (non-Javadoc)
	 * @see javax.servlet.http.HttpServlet#doGet(javax.servlet.http.HttpServletRequest, javax.servlet.http.HttpServletResponse)
	 */
	/* (non-Javadoc)
	 * @see javax.servlet.http.HttpServlet#doGet(javax.servlet.http.HttpServletRequest, javax.servlet.http.HttpServletResponse)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		response.setCharacterEncoding("UTF-8");
		request.setCharacterEncoding("UTF-8");
		
		String name = request.getParameter("cityName");
		//��ó���������Ϣ (����)
		String json = HttpURLConnectionTool.httpURLConectionGET(name);
		//��ȡjson����
		JSONObject jsonData = JSONObject.parseObject(json);
		
		ToDay today = new ToDay();
		
		//System.out.println(json);		
		
		// �����������
		String high = jsonData.getJSONObject("data").getJSONObject("yesterday").getString("high");
	/*	String obj = jobo.getString("high");	
		today.setCityName(jobo.getString("date"));*/
		System.out.println("------>"+high);
		
		// ��ó�������
		String cityname = jsonData.getJSONObject("data").getString("city");
		today.setCityName(cityname);
		System.out.println(today.getCityName());
		
		
		//��ȡ��������
		JSONArray dataarray = jsonData.getJSONObject("data").getJSONArray("forecast");
		//fastjson�����л� Ϊ ����
		Forecast[] forecastData= (Forecast[]) dataarray.toJavaObject(Forecast[].class);
		// ������תΪ����
		List<Forecast> listForecast = new ArrayList<>();
		
		
		String img="";
		for (Forecast forecast : forecastData) {
			
			img = PicTool.getPic(forecast.getType());
		   //����ͼƬ
			forecast.setImg(img);
			listForecast.add(forecast);
			
			System.out.println("img=>"+forecast.getImg());
			
		}
		
		listForecast.remove(0);	
		
	
		
		System.out.println("=========="+listForecast.get(1).getImg());
		// ����session
		HttpSession session = request.getSession();
		session.setAttribute("listForecast", listForecast);
		response.sendRedirect("index.jsp");	 
		
		
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
