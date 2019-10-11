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
	   *    ��ȡ��ҳ
	 */
	
	@Test
	public void TestHTML() {
		
		BaseDao baseDao = new BaseDao();
	
		try {		
			 //����httpClientʵ��
	        CloseableHttpClient httpClient = HttpClients.createDefault();
	        //����httpGetʵ��
	        HttpGet httpGet = new HttpGet("http://www.qianshan.co/");
	        httpGet.setHeader("Content-Type", "application/json;charset=UTF-8");
	        CloseableHttpResponse response = httpClient.execute(httpGet);
	        if (response != null){
	        	 int statusCode = response.getStatusLine().getStatusCode();
	        	 System.out.println("��Ӧ״̬��"+statusCode);
	        	 
	             HttpEntity entity =  response.getEntity();  //��ȡ��ҳ����
	             String result = EntityUtils.toString(entity, "UTF-8");
         
	     //      System.out.println("��ҳ����:"+result);            
	            
//	            
//	           // ͨ��Class��������λԪ�أ���ȡ�������д����class���Եļ���
//	            getElementsByClass()
//	            // ͨ����ǩ��������λԪ�أ���ȡ�������д��������ǩ���ֵ�Ԫ�ؽ��
//	            getElementsByTag();
//	            // ͨ����ǩ��ID����λԪ�أ�����Ǿ�׼��λ����Ϊҳ���ID���������ظ�
//	            getElementById();
//	            // ͨ�����Ժ�����������λԪ�أ���ȡ��Ҳ��һ�����������ļ���;
//	            getElementsByAttributeValue();
//	            // ͨ������ƥ������
//	            getElementsByAttributeValueMatching()
//
//	            
	            String page = result; // ��������csdnҳ���html
	            Document doc = Jsoup.parse(page);   //�õ�document����
	            
	            Element titString = doc.getElementsByTag("title").get(0);	       
	            System.out.println(titString.text());
	            
	            Elements span = doc.getElementsByTag("span");
	            System.out.println(span.text()+",");
	            
	            String sql = null;
	            
	            Elements links = doc.select("a"); //����href���Ե�aԪ��
	            for (int i = 0; i < links.size(); i++) {	            
	            	 System.out.println("����: "+links.get(i).text()+"     URL: "+links.get(i).attr("href"));
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
	   *    ��ȡͼƬ
	 */
	/*
	 * @Test public void TestImg() {
	 * 
	 * try { //ͼƬ·�� String url =
	 * "https://qianshan.sfo2.digitaloceanspaces.com/transparent.png";
	 * //����httpClientʵ�� CloseableHttpClient httpClient =
	 * HttpClients.createDefault(); //����httpGetʵ�� HttpGet httpGet = new
	 * HttpGet(url); //��������ͷ��Ϣ httpGet.setHeader(
	 * "user-Agent","Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36"
	 * ); CloseableHttpResponse response = httpClient.execute(httpGet); //��ȡ.��׺
	 * String fileName = url.substring(url.lastIndexOf("."), url.length());
	 * 
	 * if (response != null){ HttpEntity entity = response.getEntity(); if (entity
	 * != null){
	 * System.out.println("Content-Type:"+entity.getContentType().getValue());
	 * InputStream inputStream = entity.getContent(); //�ļ�����
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
