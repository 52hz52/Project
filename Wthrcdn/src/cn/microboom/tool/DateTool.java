package cn.microboom.tool;

import java.text.SimpleDateFormat;
import java.util.Date;

/**
 * ʱ�乤����
 * @author Administrator
 *
 */
public class DateTool {
	
	/**
	 * ��õ�ǰϵͳʱ�䣬��תΪ2019-04-22��ʽ
	 * @return
	 */
	public static String getCurrenTime() {
		//��õ�ǰϵͳʱ��
		Date date=new Date();
		//��ʱ���ʽ��
		SimpleDateFormat simpl=new SimpleDateFormat("yyyy-MM-");
		//��ȡString����ʱ��
		String timeStr=simpl.format(date);
		return timeStr;
	}
}
