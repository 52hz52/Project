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
		//获得城市天气信息 (城市)
		String json = HttpURLConnectionTool.httpURLConectionGET(name);
		//获取json数据
		JSONObject jsonData = JSONObject.parseObject(json);
		
		ToDay today = new ToDay();
		
		//System.out.println(json);		
		
		// 获得昨天天气
		String high = jsonData.getJSONObject("data").getJSONObject("yesterday").getString("high");
	/*	String obj = jobo.getString("high");	
		today.setCityName(jobo.getString("date"));*/
		System.out.println("------>"+high);
		
		// 获得城市名称
		String cityname = jsonData.getJSONObject("data").getString("city");
		today.setCityName(cityname);
		System.out.println(today.getCityName());
		
		
		//获取天气详情
		JSONArray dataarray = jsonData.getJSONObject("data").getJSONArray("forecast");
		//fastjson反序列化 为 数组
		Forecast[] forecastData= (Forecast[]) dataarray.toJavaObject(Forecast[].class);
		// 将数组转为集合
		List<Forecast> listForecast = new ArrayList<>();
		
		
		String img="";
		for (Forecast forecast : forecastData) {
			
			img = PicTool.getPic(forecast.getType());
		   //设置图片
			forecast.setImg(img);
			listForecast.add(forecast);
			
			System.out.println("img=>"+forecast.getImg());
			
		}
		
		listForecast.remove(0);	
		
	
		
		System.out.println("=========="+listForecast.get(1).getImg());
		// 保存session
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
