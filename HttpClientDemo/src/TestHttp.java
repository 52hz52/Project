import java.io.File;
import java.io.InputStream;
import java.util.ArrayList;

import org.apache.commons.io.FileUtils;
import org.apache.http.HttpEntity;
import org.apache.http.client.methods.CloseableHttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClients;
import org.apache.http.util.EntityUtils;
import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;
import org.junit.Test;


public class TestHttp {
	
	
	/**
	 * @author Administrator
	   *    爬取网页
	 */
	
	@Test
	public void TestHTML() {
		
		BaseDao baseDao = new BaseDao();
	
		try {		
			 //创建httpClient实例
	        CloseableHttpClient httpClient = HttpClients.createDefault();
	        //创建httpGet实例
	        HttpGet httpGet = new HttpGet("http://www.qianshan.co/");
	        httpGet.setHeader("Content-Type", "application/json;charset=UTF-8");
	        CloseableHttpResponse response = httpClient.execute(httpGet);
	        if (response != null){
	        	 int statusCode = response.getStatusLine().getStatusCode();
	        	 System.out.println("响应状态："+statusCode);
	        	 
	             HttpEntity entity =  response.getEntity();  //获取网页内容
	             String result = EntityUtils.toString(entity, "UTF-8");
         
	     //      System.out.println("网页内容:"+result);            
	            
//	            
//	           // 通过Class属性来定位元素，获取的是所有带这个class属性的集合
//	            getElementsByClass()
//	            // 通过标签名字来定位元素，获取的是所有带有这个标签名字的元素结合
//	            getElementsByTag();
//	            // 通过标签的ID来定位元素，这个是精准定位，因为页面的ID基本不会重复
//	            getElementById();
//	            // 通过属性和属性名来定位元素，获取的也是一个满足条件的集合;
//	            getElementsByAttributeValue();
//	            // 通过正则匹配属性
//	            getElementsByAttributeValueMatching()
//
//	            
	            String page = result; // 假设这是csdn页面的html
	            Document doc = Jsoup.parse(page);   //得到document对象
	            
	            Element titString = doc.getElementsByTag("title").get(0);	       
	            System.out.println(titString.text());
	            
	            Elements span = doc.getElementsByTag("span");
	            System.out.println(span.text()+",");
	            
	            String sql = null;
	            
	            Elements links = doc.select("a"); //带有href属性的a元素
	            for (int i = 0; i < links.size(); i++) {	            
	            	 System.out.println("名称: "+links.get(i).text()+"     URL: "+links.get(i).attr("href"));
	            	 sql = "  insert into info(title,content,url) VALUES (?,?,?)  ";	            	 
	            	 baseDao.executeNonQuery(sql,titString.text(),links.get(i).text(),links.get(i).attr("href"));
	            	 
	            }
	        
    
	            
	        }
	        if (response != null){
	            response.close();
	        }
	        if (httpClient != null){
	            httpClient.close();
	        }
			
			
			
		} catch (Exception e) {
			// TODO: handle exception
		}
		
	
	}
	
	
	
	/**
	 * @author Administrator
	   *    爬取图片
	 */
	/*
	 * @Test public void TestImg() {
	 * 
	 * try { //图片路径 String url =
	 * "https://qianshan.sfo2.digitaloceanspaces.com/transparent.png";
	 * //创建httpClient实例 CloseableHttpClient httpClient =
	 * HttpClients.createDefault(); //创建httpGet实例 HttpGet httpGet = new
	 * HttpGet(url); //设置请求头消息 httpGet.setHeader(
	 * "user-Agent","Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36"
	 * ); CloseableHttpResponse response = httpClient.execute(httpGet); //获取.后缀
	 * String fileName = url.substring(url.lastIndexOf("."), url.length());
	 * 
	 * if (response != null){ HttpEntity entity = response.getEntity(); if (entity
	 * != null){
	 * System.out.println("Content-Type:"+entity.getContentType().getValue());
	 * InputStream inputStream = entity.getContent(); //文件复制
	 * FileUtils.copyToFile(inputStream,new File("D:love"+fileName)); } } if
	 * (response != null){ response.close(); } if (httpClient != null){
	 * httpClient.close(); }
	 * 
	 * 
	 * 
	 * } catch (Exception e) { // TODO: handle exception }
	 * 
	 * }
	 * 
	 */
}
