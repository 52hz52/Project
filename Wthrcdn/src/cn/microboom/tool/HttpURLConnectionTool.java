package cn.microboom.tool;

import java.io.BufferedReader;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.DataInputStream;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLEncoder;
import java.util.zip.GZIPInputStream;

/**
 * 远程访问帮助类
 * @author Administrator
 *
 */
public class HttpURLConnectionTool {
	
		/**
		 * 调用天气预报接口
		 * @param cityName 要查的城市名称
		 * @return
		 */
	   public static String httpURLConectionGET(String cityName) {  
		   StringBuilder sb = new StringBuilder();  //保存请求结果
	       try {  
	    	   String city= URLEncoder.encode(cityName, "UTF-8");//将参数转码
	    	   String get_url="http://wthrcdn.etouch.cn/weather_mini?city="+city;//天气预报接口API
	           URL url = new URL(get_url);    // 把字符串转换为URL请求地址  
	           HttpURLConnection connection = (HttpURLConnection) url.openConnection();// 打开连接  
	           connection.connect();// 连接会话  
	           //获得请求的数据流
	           InputStream inputStream=connection.getInputStream();
	           //读取数据流
	           InputStreamReader inputStreamReader=new InputStreamReader(unGzip(inputStream),"utf-8");
	           
	           // 获取输入流  
	           BufferedReader br = new BufferedReader(inputStreamReader);  
	           String line="";  
	           
	           while ((line = br.readLine()) != null) {// 循环读取流  
	               sb.append(line);  
	           }  
	           br.close();// 关闭流  
	           connection.disconnect();// 断开连接  
	       } catch (Exception e) {  
	           e.printStackTrace();  
	           System.out.println("获得天气信息失败!");  
	       }  
	       return sb.toString();
	   }  
	   
	   /**
	    * 解压GZIP数据
	    * @param in
	    * @return
	    */
	   public static InputStream unGzip(InputStream in) {  
	       try {  
	           GZIPInputStream gzip = new GZIPInputStream(in);  
	           byte[] buf = new byte[1024];  
	           int len;  
	           ByteArrayOutputStream baos = new ByteArrayOutputStream();  
	           while ((len = gzip.read(buf)) != -1) {  
	               baos.write(buf, 0, len);  
	           }  
	           byte[] b = baos.toByteArray();  
	           ByteArrayInputStream bs = new ByteArrayInputStream(b);  
	           baos.flush();  
	           baos.close();  
	           gzip.close();  
	           return new DataInputStream(bs);  
	       } catch (Exception e) {  
	           e.printStackTrace();  
	       }  
	       return null;  
	   }  

}
