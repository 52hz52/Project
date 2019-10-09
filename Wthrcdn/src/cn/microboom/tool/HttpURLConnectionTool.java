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
 * Զ�̷��ʰ�����
 * @author Administrator
 *
 */
public class HttpURLConnectionTool {
	
		/**
		 * ��������Ԥ���ӿ�
		 * @param cityName Ҫ��ĳ�������
		 * @return
		 */
	   public static String httpURLConectionGET(String cityName) {  
		   StringBuilder sb = new StringBuilder();  //����������
	       try {  
	    	   String city= URLEncoder.encode(cityName, "UTF-8");//������ת��
	    	   String get_url="http://wthrcdn.etouch.cn/weather_mini?city="+city;//����Ԥ���ӿ�API
	           URL url = new URL(get_url);    // ���ַ���ת��ΪURL�����ַ  
	           HttpURLConnection connection = (HttpURLConnection) url.openConnection();// ������  
	           connection.connect();// ���ӻỰ  
	           //��������������
	           InputStream inputStream=connection.getInputStream();
	           //��ȡ������
	           InputStreamReader inputStreamReader=new InputStreamReader(unGzip(inputStream),"utf-8");
	           
	           // ��ȡ������  
	           BufferedReader br = new BufferedReader(inputStreamReader);  
	           String line="";  
	           
	           while ((line = br.readLine()) != null) {// ѭ����ȡ��  
	               sb.append(line);  
	           }  
	           br.close();// �ر���  
	           connection.disconnect();// �Ͽ�����  
	       } catch (Exception e) {  
	           e.printStackTrace();  
	           System.out.println("���������Ϣʧ��!");  
	       }  
	       return sb.toString();
	   }  
	   
	   /**
	    * ��ѹGZIP����
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
