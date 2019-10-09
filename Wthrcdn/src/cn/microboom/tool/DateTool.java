package cn.microboom.tool;

import java.text.SimpleDateFormat;
import java.util.Date;

/**
 * 时间工具类
 * @author Administrator
 *
 */
public class DateTool {
	
	/**
	 * 获得当前系统时间，并转为2019-04-22格式
	 * @return
	 */
	public static String getCurrenTime() {
		//获得当前系统时间
		Date date=new Date();
		//将时间格式化
		SimpleDateFormat simpl=new SimpleDateFormat("yyyy-MM-");
		//获取String类型时间
		String timeStr=simpl.format(date);
		return timeStr;
	}
}
